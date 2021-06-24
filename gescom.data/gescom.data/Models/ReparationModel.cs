using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gescom.data.Models
{
    public static class ReparationHelpers
    {
        public static void AddFastPrint(long id)
        {
            var repo = new PrintHelpRepository();
            var item = new PrintHelp
            {
                ID = id
            };
            repo.Create(item);
        }

        public static IEnumerable<PrintItem> BonsForPrint()
        {
            var liste = DiaryHelpers.GetDiaryForPrint();
            return liste.Select(item => new PrintItem
            {
                Groupe = 2,
                Id = item.Id
            });
        }

        public static void ClearBonTable(long id)
        {
            var query = new MssqlQuery("BonTemp");
            query.DeleteLongBy("Rang", id);
        }

        public static void ClearCashTable(long id)
        {
            var query = new MssqlQuery("CashTemp");
            query.DeleteLongBy("Rang", id);
        }

        public static void ClearTicketTable(long id)
        {
            var query = new MssqlQuery("TicketTemp");
            query.DeleteLongBy("Rang", id);
        }

        public static IEnumerable<CustomerItem> CustomerList()
        {
            var context = new DataGescomDataContext();
            var list = new List<CustomerItem>();
            foreach (var item in context.CustomerItems)
            {
                if (item.Groupe == 1)
                {
                    item.Grossiste = true;
                }
                item.Set();
                item.IsFormel = item.Forme == 1;
                list.Add(item);
            }
            return list;
        }

        public static IEnumerable<PrintHelp> GetFastPrintHelps()
        {
            var context = new DataGescomDataContext();
            return context.PrintHelps;
        }

        public static IEnumerable<TicketItem> GeTicketItems()
        {
            var context = new DataGescomDataContext();
            return context.TicketItems;
        }

        public static List<TicketModel> GetTicketLines(List<ElementModel> elements)
        {
            return elements.Select(item => new TicketModel(item)).ToList();
        }

        public static List<long> GetTicketsId()
        {
            return GeTicketItems().Select(item => item.Id).ToList();
        }

        public static TicketView GetTicketView(long id)
        {
            var repo = new TicketViewRepository();
            return repo.Get(id);
        }

        public static void InsertTicket(TicketModel model, long rang)
        {
            var query = new MssqlQuery();
            var sb = new StringBuilder();
            sb.Append("INSERT INTO TicketTemp VALUES('");
            sb.Append(model.Id + "', '");
            sb.Append(model.Nom + "', '");
            sb.Append(model.Refce + "', '");
            sb.Append(model.Prix + "', '");
            sb.Append(model.Quantite + "', '");
            sb.Append(model.Produit + "', '");
            sb.Append(model.CodeVente + "', '");
            sb.Append(rang + "', ");
            sb.Append(DateTime.Now.ToString("yyyy-MM-dd") + ");");
            string commande = sb.ToString();
            query.Command.CommandText = commande;
            query.ExecuterQuery();
            sb.Clear();
            sb.Append("INSERT INTO BonTemp VALUES('");
            sb.Append(model.Id + "','");
            sb.Append(model.Nom + "','");
            sb.Append(model.Refce + "','");
            sb.Append(model.Prix + "','");
            sb.Append(model.Quantite + "','");
            sb.Append(model.Produit + "','");
            sb.Append(model.LongCode + "','");
            sb.Append(rang + "','");
            sb.Append(model.Unite + "', ");
            sb.Append(DateTime.Now.ToString("d") + ");");
            commande = sb.ToString();
            query.Command.CommandText = commande;
            query.ExecuterQuery();
            sb.Clear();
            sb.Append("INSERT INTO CashTemp VALUES('");
            sb.Append(model.Id + "','");
            sb.Append(model.Nom + "','");
            sb.Append(model.Refce + "','");
            sb.Append(model.Prix + "','");
            sb.Append(model.Quantite + "','");
            sb.Append(model.Produit + "','");
            sb.Append(model.CodeVente + "','");
            sb.Append(rang + "','");
            sb.Append(model.Unite + "');");
            commande = sb.ToString();
            query.Command.CommandText = commande;
            query.ExecuterQuery();
        }

        public static IEnumerable<PrintItem> ReceiptsForPrint()
        {
            var liste = DiaryHelpers.GetReceiptForPrint();
            return liste.Select(item => new PrintItem
            {
                Groupe = 12,
                Id = item.Id
            });
        }

        public static void RemoveFastPrint(long id)
        {
            var data = new MssqlQuery();
            data.SetTableName("PrintHelp");
            data.DeleteLongBy("Id", id);
        }

        public static IEnumerable<PrintItem> TicketsForPrint()
        {
            var result = new List<PrintItem>();
            var context = new DataGescomDataContext();
            foreach (var item in GeTicketItems())
            {
                var ticket = context.TicketViews.SingleOrDefault(d => d.Id == item.Id);
                if (ticket != null)
                {
                    var element = new PrintItem();
                    element.Copy(item);
                    result.Add(element);
                }
            }
            return result;
        }

        public static IEnumerable<VendorItem> VendorList()
        {
            var context = new DataGescomDataContext();
            var list = new List<VendorItem>();
            foreach (var item in context.VendorItems)
            {
                item.IsFormel = item.Forme == 1;
                list.Add(item);
            }
            return list;
        }

        public static IEnumerable<WorkerItem> WorkerList()
        {
            var context = new DataGescomDataContext();
            return context.WorkerItems;
        }

        public static List<ProdShort> TrackErrorOperateItem()
        {
            var context = new DataGescomDataContext();
            return context.ProdShorts.ToList();
        }
    }

    public partial class CompItem
    {
        public CompItem(CompItem item)
        {
            Copy(item);
        }

        public void Copy(CompItem item)
        {
            Comment = item.Comment;
            Description = item.Description;
            ForChange = item.ForChange;
            ForNew = item.ForNew;
            Id = item.Id;
            LongName = item.LongName;
            Mode = item.Mode;
            Obs = item.Obs;
            Remark = item.Remark;
            Reste = item.Reste;
            ShortName = item.ShortName;
        }
    }

    public class CompRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(CompItem item)
        {
            _context.CompItems.InsertOnSubmit(item);
        }

        public IQueryable<CompItem> Complements()
        {
            return _context.CompItems;
        }

        public int Count()
        {
            return _context.CompItems.Count();
        }

        public bool Create(CompItem item)
        {
            Add(item);
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

        public void Delete(CompItem item)
        {
            _context.CompItems.DeleteOnSubmit(item);
        }

        public CompItem Get(long id)
        {
            return _context.CompItems.SingleOrDefault(d => d.Id == id);
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

        public bool Update(CompItem item)
        {
            CompItem element = Get(item.Id);
            element.Copy(item);
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

    public partial class CustomerItem
    {
        public float Credit { get; set; }
        public float Debit { get; set; }
        public bool Grossiste { get; set; }
        public bool IsFormel { get; set; }
    }

    public partial class ExternItem
    {
        public void Copy(ExternItem item)
        {
            Id = item.Id;
            Vid = item.Vid;
            Code = item.Code;
            Reference = item.Reference;
            Nom = item.Reference;
            Prix = item.Prix;
            IdUnite = item.IdUnite;
            Correspond = item.Correspond;
        }
    }

    public class ExternRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(ExternItem item)
        {
            _context.ExternItems.InsertOnSubmit(item);
        }

        public int Count()
        {
            return _context.ExternItems.Count();
        }

        public bool Create(ExternItem item)
        {
            Add(item);
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

        public void Delete(ExternItem item)
        {
            _context.ExternItems.DeleteOnSubmit(item);
        }

        public IQueryable<ExternItem> Externements()
        {
            return _context.ExternItems;
        }

        public ExternItem Get(long id)
        {
            return _context.ExternItems.SingleOrDefault(d => d.Id == id);
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

        public bool Update(ExternItem item)
        {
            var element = Get(item.Id);
            element.Copy(item);
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

    public class PrintHelpRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(PrintHelp item)
        {
            _context.PrintHelps.InsertOnSubmit(item);
        }

        public int Count()
        {
            return _context.PrintHelps.Count();
        }

        public bool Create(PrintHelp item)
        {
            Add(item);
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

        public void Delete(long id)
        {
            var item = Get(id);
            _context.PrintHelps.DeleteOnSubmit(item);
        }

        public PrintHelp Get(long id)
        {
            return _context.PrintHelps.SingleOrDefault(d => d.ID == id);
        }

        public IQueryable<PrintHelp> PrintHelpements()
        {
            return _context.PrintHelps;
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

        public bool Update(PrintHelp item)
        {
            var element = Get(item.ID);
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

    public class TicketModel
    {
        public TicketModel()
        {
            //
        }

        public TicketModel(ElementModel item)
        {
            var id = item.Id;
            Fcode = item.Fcode;
            SetName(id);
            Id = id;
            Prix = item.Prix;
            Quantite = item.Quantite;
            Produit = Prix * Quantite;
            Unite = item.Unite;
        }

        public string CodeVente { get; set; }
        public string LongCode { get; set; }
        public long Id { get; set; }
        public string Nom { get; set; }
        public string ProduitText { get; set; }
        public float Prix { get; set; }
        public float Produit { get; set; }
        public float Quantite { get; set; }
        public string Refce { get; set; }
        public string Unite { get; set; }
        public string Fcode { get; set; }

        public override string ToString()
        {
            string result = Quantite + "|" + Fcode + "|" + Refce + "|" + Produit;
            return result;
        }

        private void SetName(long id)
        {
            var article = ArticleHelpers.Get(id);
            Nom = article.Nom;
            Refce = article.Refce;
            var dist = DistHelpers.Get(id).Numero;
            if (dist != null)
            {
                var numero = (long)dist;
                var place = PlaceHelpers.Get(numero);
                // CodeVente = article.Code + "-" + place.Code;
                LongCode = place.Code + " " + Fcode;
                //LongCode = LongCode.Trim();
            }
        }
    }

    public class TicketViewRepository
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.TicketViews.Count();
        }

        public TicketView Get(long id)
        {
            return _context.TicketViews.SingleOrDefault(d => d.Id == id);
        }
    }

    public partial class VendorItem
    {
        public float Credit { get; set; }
        public float Debit { get; set; }
        public bool Grossiste { get; set; }
        public bool IsFormel { get; set; }
    }

    public partial class WorkerItem
    {
        public float Prime { get; set; }
    }
}