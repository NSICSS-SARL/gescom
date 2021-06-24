using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class ElementHelpers
    {
        public static ElementModel Get(IEnumerable<ElementModel> liste, long id)
        {
            return liste.FirstOrDefault(model => model.Id == id);
        }

        public static List<ElementModel> Remove(List<ElementModel> liste, long id)
        {
            var element = new ElementModel();
            foreach (ElementModel model in liste.Where(model => model.Id == id))
            {
                element = model;
            }
            liste.Remove(element);
            return liste.ToList();
        }

        public static List<ElementModel> GetElements(List<ElementModel> liste)
        {
            var result = new List<ElementModel>();
            foreach (ElementModel model in liste)
            {
                model.Prix = PriceHelpers.GetPrixItem(model.Id);
                result.Add(model);
            }
            return result;
        }

        public static List<ElementModel> ShowInvalidate(List<ElementModel> liste)
        {
            int count = InvalidList(liste).ToList().Count;
            if (count > 0)
            {
                return liste;
            }
            return null;
        }

        private static IEnumerable<ElementModel> InvalidList(IEnumerable<ElementModel> liste)
        {
            return from model in liste
                   let maxQuantite = ArticleHelpers.GetDisponible(model.Id)
                   where model.Quantite > maxQuantite
                   select model;
        }
    }

    public class Cart : IEnumerable<ElementModel>
    {
        public Cart()
        {
            Elements = new List<ElementModel>();
            List<ArticleItem> articles = ArticleHelpers.GetList();
            int count = articles.Count;
            if (count == 0)
            {
                return;
            }
            foreach (ArticleItem item in articles)
            {
                var model = new ElementModel { Id = item.Id, Article = item };
                Elements.Add(model);
            }
        }

        public Cart(long igParam)
        {
            Elements = new List<ElementModel>();
            List<ArticleItem> articles = ArticleHelpers.ListedByCategory(igParam);
            int count = articles.Count;
            if (count == 0)
            {
                return;
            }
            foreach (ArticleItem item in articles)
            {
                var model = new ElementModel { Id = item.Id, Article = item };
                Elements.Add(model);
            }
        }

        public List<ElementModel> Elements { get; set; }

        public IEnumerator<ElementModel> GetEnumerator()
        {
            return Elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ElementModel
    {
        public ElementModel()
        {
            //
        }

        public ElementModel(long id)
        {
            Id = id;
            Article = ArticleHelpers.Get(id);
        }

        public ElementModel(ArticleItem item)
        {
            Id = item.Id;
        }

        public int Taxable { get; set; }

        // articles.
        public ArticleItem Article { get; set; }

        public float Rx { get; set; }
        public long Cid { get; set; }
        public string AgentName { get; set; }
        public string Code { get; set; }
        public long Forme { get; set; }
        public long Groupe { get; set; }

        public long Id { get; set; }

        public string Nom { get; set; }

        public long Pid { get; set; }

        public float Prix { get; set; }
        public float Produit { get; set; }

        public float Q1 { get; set; }

        public float Q2 { get; set; }

        public float QStock { get; set; }

        public float Quantite { get; set; }

        public string Unite { get; set; }

        public long Vid { get; set; }

        public long Wid { get; set; }

        public string Fcode { get; set; }

        public void Copy(ElementModel model)
        {
            Id = model.Id;
            Quantite = model.Quantite;
            Prix = model.Prix;
            Code = model.Code;
            Unite = model.Unite;
            Nom = model.Nom;
            QStock = model.QStock;
            Q1 = model.Q1;
            Q2 = model.Q2;
            Wid = model.Wid;
            Rx = model.Rx;
            Forme = model.Forme;
            Taxable = model.Taxable;
            Fcode = model.Fcode;
            //Pid = model.Pid;
        }

        public void Copy(OperationModel model)
        {
            Id = model.Ndx;
            Quantite = model.Qte;
            Prix = model.Px;
            Code = model.Codage;
            Unite = model.Unite;
            Nom = model.Designation;
            QStock = model.QStock;
            Q1 = model.Q1;
            Q2 = model.Q2;
            Wid = model.Wid;
            Rx = model.Rx;
            Forme = model.Forme;
            Taxable = model.Taxable;
            Pid = model.Pid;
            Fcode = model.Fcode;
        }

        public void Copy(OperationItem item)
        {
            Id = item.Ndx;
            Quantite = item.Qte;
            Prix = item.Px;
            Code = item.Codage;
            Unite = item.Unite;
            Nom = item.Designation;
            if (item.QStock != null) QStock = (float)item.QStock;
            Q1 = item.Q1;
            Q2 = item.Q2;
            Wid = item.Wid;
            Rx = item.Rx;
            if (item.Forme != null) Forme = (long)item.Forme;
            if (item.Taxable != null) Taxable = (int)item.Taxable;
            Fcode = item.Fcode;
        }

        public override string ToString()
        {
            return this.Prix.ToString();
        }

        public void Copy(OperationAuto item)
        {
            Id = item.Ndx;
            if (item.QEstime != null) Quantite = (float)item.QEstime;
            if (item.PEstime != null) Prix = (float)item.PEstime;
            Code = item.Codage;
            Unite = item.Unite;
            Nom = item.Designation;
            if (item.QStock != null) QStock = (float)item.QStock;
            Q1 = item.Q1;
            Q2 = item.Q2;
            if (item.Forme != null) Forme = (long)item.Forme;
            if (item.Taxable != null) Taxable = (int)item.Taxable;
            Fcode = item.Fcode;
        }
    }
}