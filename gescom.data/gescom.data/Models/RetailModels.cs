using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace gescom.data.Models
{
    public static class RetailHelpers
    {
        public static IEnumerable<RetailItem> Get(long id)
        {
            var cart = new RetailCart();
            return cart.Retails.Where(item => item.Numero == id);
        }

        public static void CleanPrtTemp()
        {
            CleanTables("TicketTemp");
            CleanTables("BonTemp");
        }

        private static void CleanTables(string tableName)
        {
            var query = new MssqlQuery(tableName);
            if (query.CountRecords() < 1)
            {
                return;
            }
            var sb = new StringBuilder();
            sb.Append(@"DELETE FROM ");
            sb.Append(tableName);
            sb.Append(@" WHERE ");
            sb.Append(tableName);
            sb.Append(".Datum < '");
            sb.Append(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            sb.Append("'");
            string commande = sb.ToString();
            query.Command.CommandText = commande;
            query.ExecuterQuery();
        }

        public static string GetAmountText(long id)
        {
            float total = GetAmountTotal(id);
            string result = StdCalcul.DoubleToSpaceFormat(total);
            return result;
        }

        public static float GetAmountTotal(long id)
        {
            return GetList(id).Sum(retailModel => retailModel.Produit);
        }

        public static IEnumerable<RetailText> GetFromModel(List<RetailModel> liste)
        {
            var result = new List<RetailText>();
            foreach (RetailModel model in liste)
            {
                var text = new RetailText();
                text.Copy(model);
                result.Add(text);
            }
            return result;
        }

        public static RetailItem GetItem(long id)
        {
            var reptory = new RetailRepository();
            var item = reptory.Get(id);
            return item;
        }

        public static List<RetailModel> GetList(long id)
        {
            return GetRetail(id).ToList();
        }

        public static RetailModel GetModel(long id)
        {
            var model = new RetailModel();
            foreach (RetailModel item in GetList(id).Where(item => item.Numero == id))
            {
                model = item;
            }
            return model;
        }

        public static IEnumerable<RetailModel> GetRetail(long id)
        {
            return GetRetailModels().Where(model => model.Numero == id);
        }

        public static string GetRetailAdresse(long id)
        {
            return GetItem(id).AdrKil;
        }

        public static IEnumerable<RetailText> GetRetailItems(long id)
        {
            string numero = id.ToString(CultureInfo.InvariantCulture);
            return GetRetailTexts().Where(retailText => retailText.Numero == numero);
        }

        public static IEnumerable<RetailModel> GetRetailModels()
        {
            var result = new List<RetailModel>();
            var cart = new RetailCart();
            foreach (RetailItem item in cart.Retails)
            {
                var model = new RetailModel();
                model.Copy(item);
                result.Add(model);
            }
            return result;
        }

        public static string GetRetailName(long id)
        {
            return GetItem(id).NomKil;
        }

        public static IEnumerable<RetailText> GetRetailTexts()
        {
            var result = new List<RetailText>();
            foreach (RetailModel model in GetRetailModels())
            {
                var item = new RetailText();
                item.Copy(model);
                result.Add(item);
            }
            return result;
        }

        public static float GetTaxAmount(long id)
        {
            var cart = new RetailCart();
            return cart.Retails.Where(item => item.Numero == id).Sum(item => item.Tva);
        }

        public static void Update(RetailItem item)
        {
            var reptory = new RetailRepository();
            reptory.Update(item);
        }
    }

    public class RetailCart : IEnumerable<RetailItem>
    {
        public RetailCart()
        {
            Retails = new List<RetailItem>();
            var repository = new RetailRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (RetailItem element in repository.Retails())
            {
                RetailItem item = element;
                float price = 0;
                float quantite = 0;
                if (item.Quantity != null) quantite = (float)item.Quantity;
                if (item.Price != null) price = (float)item.Price;
                long id = 0;
                if (element.Numero != null) id = (long)element.Numero;
                if (id > 0)
                {
                    long b = 0;
                    long ndx = item.Ndx;
                    ArticleItem article = ArticleHelpers.Get(ndx);
                    long forme = 0;
                    if (article.Forme != null) forme = (long)article.Forme;
                    long? taxable = article.Taxable;
                    if (taxable != null) b = (long)taxable;
                    if (forme == 0)
                    {
                        item.Cview = item.Codes + @"-I";
                        item.Price = price;
                        item.Tva = 0;
                    }
                    if (forme == 1)
                    {
                        if (b == 0)
                        {
                            item.Cview = item.Codes + @"-X";
                        }
                        if (b == 1)
                        {
                            item.Cview = item.Codes + @"-T";
                        }
                    }
                    if (b == 1)
                    {
                        float tva = PriceHelpers.CalculReboursTva(price);
                        item.Price = price - tva;
                        item.Tva = tva * quantite;
                    }
                }
                item.Info = element.Operateur + @" " + element.Daty;
                Retails.Add(item);
            }
        }

        public List<RetailItem> Retails { get; set; }

        public IEnumerator<RetailItem> GetEnumerator()
        {
            return Retails.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class RetailItem
    {
        public string Info { get; set; }

        public float PrixHt { get; set; }

        public string Cview { get; set; }

        public float Taxe { get; set; }

        public float Tva { get; set; }

        public void Copy(RetailModel model)
        {
            Numero = model.Numero;
            Daty = model.Daty;
            Operateur = model.Operateur;
            Terminal = model.Terminal;
            Price = model.Price;
            Quantity = model.Quantity;
            Produit = model.Produit;
            Unite = model.Unite;
            Place = model.Place;
            Designation = model.Designation;
            Codes = model.Codes;
            CodeVente = model.CodeVente;
            NomClient = model.NomClient;
            AdresseClient = model.AdresseClient;
            Total = model.Total;
            Info = model.Info;
            Ndx = model.Ndx;
            PrixHt = model.PrixHt;
            Tva = model.Tva;
            Taxe = model.Taxe;
            NomKil = model.NomKil;
            AdrKil = model.AdrKil;
            Cview = model.Cview;
        }

        public void Copy(RetailItem item)
        {
            Numero = item.Numero;
            Daty = item.Daty;
            Operateur = item.Operateur;
            Terminal = item.Terminal;
            Price = item.Price;
            Quantity = item.Quantity;
            Produit = item.Produit;
            Unite = item.Unite;
            Place = item.Place;
            Designation = item.Designation;
            Codes = item.Codes;
            CodeVente = item.CodeVente;
            NomClient = item.NomClient;
            AdresseClient = item.AdresseClient;
            Total = item.Total;
            Info = item.Info;
            Ndx = item.Ndx;
            PrixHt = item.PrixHt;
            Tva = item.Tva;
            Taxe = item.Taxe;
            NomKil = item.NomKil;
            AdrKil = item.AdrKil;
            Cview = item.Cview;
        }
    }

    public class RetailModel
    {
        public string AdresseClient { get; set; }

        public string AdrKil { get; set; }

        public string Codes { get; set; }

        public string CodeVente { get; set; }

        public DateTime Daty { get; set; }

        public string Designation { get; set; }

        public string Info { get; set; }

        public long Ndx { get; set; }

        public string Cview { get; set; }

        public string NomClient { get; set; }

        public string NomKil { get; set; }

        public long Numero { get; set; }

        public string Operateur { get; set; }

        public string Place { get; set; }

        public float Price { get; set; }

        public float PrixHt { get; set; }

        public float Produit { get; set; }

        public float Quantity { get; set; }

        public float Taxe { get; set; }

        public string Terminal { get; set; }

        public float Total { get; set; }

        public float Tva { get; set; }

        public string Unite { get; set; }

        public void Copy(RetailItem item)
        {
            if (item.Numero != null) Numero = (long)item.Numero;
            if (item.Daty != null) Daty = (DateTime)item.Daty;
            Operateur = item.Operateur;
            Terminal = item.Terminal;
            if (item.Price != null) Price = (float)item.Price;
            if (item.Quantity != null) Quantity = (float)item.Quantity;
            if (item.Produit != null) Produit = (float)item.Produit;
            Unite = item.Unite;
            Place = item.Place;
            Designation = item.Designation;
            Codes = item.Codes;
            CodeVente = item.CodeVente;
            NomClient = item.NomClient;
            AdresseClient = item.AdresseClient;
            Info = item.Info;
            if (item.Total != null) Total = (float)item.Total;
            Ndx = item.Ndx;
            PrixHt = item.PrixHt;
            Tva = item.Tva;
            Taxe = item.Taxe;
            NomKil = item.NomKil;
            AdrKil = item.AdrKil;
            Cview = item.Cview;
        }
    }

    public class TempRepository
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public bool Save()
        {
            try
            {
                _context.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }

    public class RetailRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.RetailItems.Count();
        }

        public bool Save()
        {
            try
            {
                _context.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Add(RetailItem item)
        {
            _context.RetailItems.InsertOnSubmit(item);
        }

        public void Delete(RetailItem item)
        {
            _context.RetailItems.DeleteOnSubmit(item);
        }

        public RetailItem Get(long id)
        {
            RetailItem result;
            try
            {
                result = _context.RetailItems.SingleOrDefault(d => d.Numero == id);
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        public IQueryable<RetailItem> Retails()
        {
            return _context.RetailItems;
        }

        public bool Update(RetailItem retail)
        {
            long n = -1;
            if (retail.Numero != null) n = (long)retail.Numero;
            RetailItem item = Get(n);
            item.Copy(retail);
            try
            {
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(RetailModel model)
        {
            RetailItem item = Get(model.Numero);
            item.Copy(model);
            try
            {
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class RetailText
    {
        public string AdresseClient { get; set; }

        public string Cview { get; set; }

        public string Codes { get; set; }

        public string CodeVente { get; set; }

        public string Daty { get; set; }

        public string Designation { get; set; }

        public string Info { get; set; }

        public string Ndx { get; set; }

        public string NomClient { get; set; }

        public string Numero { get; set; }

        public string Operateur { get; set; }

        public string Place { get; set; }

        public string Price { get; set; }

        public string PrixHt { get; set; }

        public string Produit { get; set; }

        public string Quantity { get; set; }

        public string Taxe { get; set; }

        public string Terminal { get; set; }

        public string Total { get; set; }

        public string Tva { get; set; }

        public string Unite { get; set; }

        public void Copy(RetailModel model)
        {
            if (model == null)
            {
                return;
            }
            if (model.Numero == 0)
            {
                return;
            }
            Numero = StdCalcul.DoubleToSpaceFormat(model.Numero);

            Daty = model.Daty.ToLongTimeString();
            Operateur = model.Operateur;
            Terminal = model.Terminal;
            Price = StdCalcul.DoubleToSpaceFormat(model.Price);
            Quantity = StdCalcul.DoubleToSpaceFormat(model.Quantity);
            Produit = StdCalcul.DoubleToSpaceFormat(model.Produit);
            Unite = model.Unite;
            Place = model.Place;
            Designation = model.Designation;
            Codes = model.Codes;
            CodeVente = model.CodeVente;
            NomClient = model.NomClient;
            AdresseClient = model.AdresseClient;
            Total = StdCalcul.DoubleToSpaceFormat(model.Total);
            Info = model.Info;
            Ndx = StdCalcul.DoubleToSpaceFormat(model.Ndx);
            PrixHt = StdCalcul.DoubleToSpaceFormat(model.PrixHt);
            Tva = StdCalcul.DoubleToSpaceFormat(model.Tva);
            Taxe = StdCalcul.DoubleToSpaceFormat(model.Taxe);
            Cview = model.Cview;
        }
    }
}