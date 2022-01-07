using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace gescom.data.Models
{
    public static class ArticleHelpers
    {
        public static void AdaptRefArticles()
        {
            var repo = new ArticleRepository();
            foreach (var item in GetList())
            {
                var nbCaract = item.Nom.Length;
                var refce = item.Nom;
                if (nbCaract > 21) refce = item.Nom.Substring(0, 19);
                repo.UpdateRef(item.Id, refce);
            }
        }

        public static List<DuoItem> GetDuos()
        {
            var reptory = new DuoCart();
            return reptory.Duos;
        }


        //ajouter quantité stock dans table article.
        public static void Add(long id, float quantite)
        {
            var repository = new ArticleRepository();
            var item = repository.Get(id);
            if (item.Quantite == null) item.Quantite = 0;
            item.Quantite += quantite;
            repository.Save();
        }

        public static void CreateDuo()
        {
            var repository = new DuoRepository();
            repository.Create();
        }

        // article selon son identifiant id.
        public static ArticleItem Get(long id)
        {
            var reptory = new ArticleRepository();
            return reptory.Get(id);
        }

        public static void Rectif()
        {
       
        var count = 0;
            var reptory = new ProdRepository();
            foreach(var item in reptory.Prods())
            {
               if(item.Iu is null) { count++;
                    item.Iu = 46;
                }                
            }
            reptory.Save();
            Console.WriteLine(count); 
        }


        //récupération de stock d'un article.
        public static float GetDisponible(long id)
        {
            var model = new ArticleModel();
            model.Copy(Get(id));
            return model.Quantite;
        }

        public static DuoItem GetDuo(long id)
        {
            var reptory = new DuoRepository();
            return reptory.Get(id);
        }


        public static List<ArticleItem> GetList()
        {
            var cart = new ArticleCart();
            return cart.Articles;
        }


        public static string GetName(long id)
        {
            return Get(id).Nom;
        }

        public static string GetNormalizedCode(long id)
        {
            var item = Get(id);
            if (item == null) return null;
            switch (item.Forme)
            {
                case 0:
                    return item.Code + "-I";
                case 1:
                    if (item.Taxable == 1) return item.Code + "-T";
                    break;
            }

            return item.Code + "-X";
        }

        public static int GetRang(int ig)
        {
            return ListedByCategory(ig).Count();
        }


        public static List<ArticleItem> ListedByCategory(long igParam)
        {
            var cart = new ArticleCart();
            return cart.Articles.Where(item => item.Ig == igParam).ToList();
        }

        public static void PutDescription(long id, string text)
        {
            var repository = new ArticleRepository();
            var item = repository.Get(id);
            if (string.IsNullOrEmpty(text)) return;
            item.Description = text;
            repository.Save();
        }

        //ajouter quantité stock dans table article.
        public static void Remove(long id, float quantite)
        {
            var repository = new ArticleRepository();
            var item = repository.Get(id);
            if (item.Quantite == null) item.Quantite = 0;
            if (quantite > item.Quantite) return;
            item.Quantite -= quantite;
            repository.Save();
        }

        public static void UpdateDuo(long id, string message, float quantite)
        {
            var repository = new DuoRepository();
            var item = repository.Get(id);
            item.S2 = message;
            item.Q2 = quantite;
            item.D2 = DateTime.Now;
            if (quantite >= 0) repository.Update();
        }

        public static void UpdateFusion(long id, string tache, string message, string b1, string b2, long entrer = 0,
            long tarifer = 0, float quantite = 0, float arrivage=0,long prior = 0, long? mask = null)
        {
            var repository = new DuoRepository();
            var item = repository.Get(id);
            item.Faster = prior;
            item.AEntre = entrer;
            item.APrix = tarifer;
            //item.L = mask;
            //item.T1 = tache;
            item.B1 = b1;
            item.B2 = b2;
            item.S2 = message;
            item.D2 = DateTime.Now;
            item.Q2 = quantite;
            item.Q1 = arrivage;
            repository.Update();
        }

        public static void RepairDuoFaster()
        {
            var repo = new DuoRepository();
            repo.Repair();
        }

        public static void UpdateRecto(long id, string tache, string message, float quantite, string b1, string b2,
            long tarifer, long entrer, long? visible = null, long prior = 0, float qentre=0)
        {
            var repository = new DuoRepository();
            var item = repository.Get(id);
            item.Faster = prior;
            item.L = visible;
            item.T1 = tache;
            item.B1 = b1;
            item.B2 = b2;
            item.S1 = message;
            item.AEntre = entrer;
            item.APrix = tarifer;
            item.D1 = DateTime.Now;
            item.Q1 = quantite;
            item.Q2 = qentre;
            if (quantite >= 0) repository.Update();
        }
    }

    public class ArticleCart : IEnumerable<ArticleItem>
    {
        public ArticleCart()
        {
            Articles = new List<ArticleItem>();
            var repository = new ArticleRepository();
            var count = repository.Count();
            if (count == 0) return;
            foreach (var element in repository.Articles())
            {
                var item = element;
                Articles.Add(item);
            }
        }


        public List<ArticleItem> Articles { get; set; }

        public IEnumerator<ArticleItem> GetEnumerator()
        {
            return Articles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class ArticleItem
    {
        public bool DuplicateError { get; set; }


        public void Copy(ArticleModel model)
        {
            Id = model.Id;
            CCode = model.CCode;
            Rang = model.Rang;
            Code = model.Code;
            CompleteCode = model.CompleteCode;
            Nom = model.Nom;
            Catalogue = model.Catalogue;
            Ig = model.Ig;
            Iu = model.Iu;
            Seuil = model.Seuil;
            Taxable = model.Taxable;
            State = model.State;
            Refce = model.Refce;
            DuplicateError = model.DuplicateError;
            Description = model.Description;
            Forme = model.Forme;
        }
    }

    public class ArticleModel
    {
        public string Catalogue { get; set; }

        public string CCode { get; set; }

        public string Code { get; set; }

        public string CompleteCode { get; set; }

        public string Description { get; set; }

        public bool DuplicateError { get; set; }

        public long Forme { get; set; }

        public long Id { get; set; }

        public int Ig { get; set; }

        public int Iu { get; set; }

        public string Nom { get; set; }

        public float Quantite { get; set; }

        public long Rang { get; set; }

        public string Refce { get; set; }

        public float Seuil { get; set; }

        public int State { get; set; }

        public int Taxable { get; set; }

        public void Copy(ArticleItem item)
        {
            Id = item.Id;
            CCode = item.CCode;
            Refce = item.Refce;
            Catalogue = item.Catalogue;
            if (item.Rang != null) Rang = (long) item.Rang;
            Code = item.Code;
            CompleteCode = item.CompleteCode;
            Nom = item.Nom;
            Catalogue = item.Catalogue;
            if (item.Ig != null) Ig = (int) item.Ig;
            if (item.Iu != null) Iu = (int) item.Iu;
            if (item.Seuil != null) Seuil = (float) item.Seuil;
            if (item.Taxable != null) Taxable = (int) item.Taxable;
            if (item.State != null) State = (int) item.State;
            if (item.Quantite != null) Quantite = (float) item.Quantite;
            DuplicateError = item.DuplicateError;
            Description = item.Description;
            if (item.Forme != null) Forme = (long) item.Forme;
        }
    }

    public class ArticleRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.ArticleItems.Count();
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

        public void Add(ArticleItem item)
        {
            _context.ArticleItems.InsertOnSubmit(item);
        }

        public IQueryable<ArticleItem> Articles()
        {
            return _context.ArticleItems;
        }


        public bool CreateWin(ArticleModel model)
        {
            var article = new ArticleItem();
            var id = Count() + 1;
            model.Id = id;
            model.Quantite = 0;
            model.Rang = ArticleHelpers.GetRang(model.Ig) + 1;
            var txt = FamilleHelpers.GetCode(model.Ig);
            model.Code = id + txt.Substring(0, 1);
            model.CCode = id + " " + txt.Substring(0, 1);
            model.CompleteCode = id + FamilleHelpers.GetCode(model.Ig) +
                                 model.Rang.ToString(CultureInfo.InvariantCulture);
            if (model.Forme == 0) model.CompleteCode += "-I";
            if (model.Forme == 1)
            {
                if (model.Taxable == 1)
                    model.CompleteCode += "-T";
                else
                    model.CompleteCode += "-X";
            }

            article.Copy(model);
            Add(article);
            try
            {
                _context.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }

            ArticleHelpers.CreateDuo();
            return true;
        }


        public ArticleItem Get(long id)
        {
            return _context.ArticleItems.SingleOrDefault(d => d.Id == id);
        }

        public bool Update()
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

        public bool UpdateRef(long id, string refce)
        {
            var item = Get(id);
            item.Refce = refce;
            return Update();
        }
    }

    public class DuoCart : IEnumerable<DuoItem>
    {
        public DuoCart()
        {
            Duos = new List<DuoItem>();
            var repository = new DuoRepository();
            var count = repository.Count();
            if (count == 0) return;
            foreach (var element in repository.Duos())
            {
                var item = element;
                Duos.Add(item);
            }
        }

        public List<DuoItem> Duos { get; set; }

        public IEnumerator<DuoItem> GetEnumerator()
        {
            return Duos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class DuoItem
    {
    }

    public class DuoModel
    {
        public DuoModel()
        {
            D1 = DateTime.Now;
            D2 = DateTime.Now;
            Actif = 0;
        }

        public string B1 { get; set; }
        public long Actif { get; set; }
        public string B2 { get; set; }
        public long APrix { get; set; }
        public long AEntre { get; set; }
        public string C1 { get; set; }

        public DateTime D1 { get; set; }

        public DateTime D2 { get; set; }


        public long Id { get; set; }


        public float Q { get; set; }

        public float Q1 { get; set; }

        public float Q2 { get; set; }

        public string S1 { get; set; }

        public string S2 { get; set; }

        public string T1 { get; set; }
    }

    public class DuoRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.DuoItems.Count();
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

        public void Add(DuoItem item)
        {
            _context.DuoItems.InsertOnSubmit(item);
        }

        public void Create()
        {
            var item = new DuoItem();
            var id = Count() + 1;
            item.S1 = @"SIGNAL RECTO";
            item.S2 = @"SIGNAL VERSO";
            item.Id = id;
            item.Q = 0;
            item.Q1 = 0;
            item.Q2 = 0;
            item.Faster = 0;
            item.D1 = DateTime.Now;
            item.D2 = DateTime.Now;
            Add(item);
            Save();
        }


        public void Repair()
        {
            foreach (var elt in _context.ProdItems) elt.Etat = -1;
            _context.SubmitChanges();
            Save();
        }

        public IQueryable<DuoItem> Duos()
        {
            return _context.DuoItems;
        }

        public DuoItem Get(long id)
        {
            return _context.DuoItems.SingleOrDefault(d => d.Id == id);
        }

        public bool Update()
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
}