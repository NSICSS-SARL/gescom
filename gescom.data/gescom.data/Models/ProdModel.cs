using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class ProdHelpers
    {
        //décommander un article
        public static void DisCmd(long id)
        {
            var repository = new ProdRepository();
            ProdItem item = repository.Get(id);
            item.Etat = 0;
            //item.Etat0 = false;
            item.Etat1 = true;
            item.Etat2 = false;
            repository.Save();
        }

        // prod selon son identifiant id.
        public static ProdItem Get(long id)
        {
            var repo = new ProdRepository();
            return repo.Get(id);
        }

        public static ProdCheck GetCommande(long id)
        {
            return new ProdCheck(id);
        }

        public static float GetEstimated(long id)
        {
            var repo = new ProdRepository();
            var item = repo.Get(id);
            if (item.Quantite == null)
            {
                return 0;
            }
            var result = (float)item.Quantite;
            return result;
        }

        public static long GetId(string name)
        {
            long result = -1;
            foreach (ProdItem item in GetList().Where(item => item.Nom == name))
            {
                result = item.Id;
            }
            return result;
        }

        public static List<ProdItem> GetList()
        {
            var context = new DataGescomDataContext();
            return context.ProdItems.ToList();
        }

        public static List<string> GetListProds()
        {
            return GetList().Select(item => item.Nom).ToList();
        }

        public static string GetName(long id)
        {
            return Get(id).Nom;
        }

        public static float GetPrice(long id)
        {
            float result = 0;
            float? prix = Get(id).Prix;
            if (prix != null)
            {
                result = (float)prix;
            }
            return result;
        }

        //initialisation commande
        public static void NewArrive(long id)
        {
            var repository = new ProdRepository();
            ProdItem item = repository.Get(id);
            item.Quantite = 0;
            repository.Save();
        }

        // réaliser arrivage
        public static void RealizedCommande(long id, float quantite)
        {
            var repository = new ProdRepository();
            ProdItem item = repository.Get(id);
            item.Etat = -1;
            //item.Etat0 = false;
            item.Etat1 = false;
            item.Etat2 = true;
            item.Quantite = quantite;
            repository.Save();
        }

        public static void ReinitCommande(IEnumerable<ElementModel> elements)
        {
            foreach (var element in elements)
            {
                DisCmd(element.Id);
            }
        }

        public static void SetManual(List<OperationAuto> liste)
        {
            var repo = new ProdRepository();
            foreach (var item in liste)
            {
                var oper = OperationHelpers.Get(item.Ndx);
                var qte = oper.QStock;
                if (qte > 0)
                {
                    repo.UpdateAuto(item.Ndx, qte);
                }
            }
        }

        public static void Update(ProdModel model)
        {
            var repository = new ProdRepository();
            bool e = repository.Update(model);
            if (!e)
            {
                // StdCalcul.ShowErrorDuplicate();
            }
        }

        public static bool Update(long id, bool chkArret, bool chkEpuise, bool chkCommande, bool chkMdh)
        {
            var prod = new ProdCheck(id);
            prod.SetActivation(chkArret, chkEpuise, chkCommande, chkMdh);
            var repo = new ProdRepository();
            return repo.Update(prod);
        }

        /** modification de info art frns**/
    }

    public class ProdCart : IEnumerable<ProdItem>
    {
        public ProdCart()
        {
            Prods = new List<ProdItem>();
            var repository = new ProdRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (ProdItem element in repository.Prods())
            {
                ProdItem item = element;
                Prods.Add(item);
            }
        }

        public List<ProdItem> Prods { get; set; }

        public IEnumerator<ProdItem> GetEnumerator()
        {
            return Prods.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ProdCheck : ProdItem
    {
        public ProdCheck(long id)
        {
            Init();
            Get(id);
        }

        public bool CheckAttente { get; set; }
        public bool CheckCommande { get; set; }
        public bool CheckRealise { get; set; }
        public bool CheckState { get; set; }
        public string Message { get; set; }

        public void Copy(ProdItem item)
        {
            Id = item.Id;
            Nom = item.Nom;
            Prix = item.Prix;
            Iu = item.Iu;
            Quantite = item.Quantite;
            DuplicateError = item.DuplicateError;
            Code = item.Code;
            Refce = item.Refce;
            Pid = item.Pid;
            Description = item.Description;
            Drapeau = item.Drapeau;
            Rq = item.Rq;
            Epuise = item.Epuise;
            Arret = item.Arret;
            Etat = item.Etat;
            Etat0 = item.Etat0;
        }

        public void Get(long id)
        {
            var prod = ProdHelpers.Get(id);
            Copy(prod);
            var r = prod.Etat;
            if (r == 0)
            {
                CheckCommande = true;
                //Etat0 = true;
            }
            if (r == 1)
            {
                CheckAttente = true;
                Etat1 = true;
                Message = "Attente commande";
            }
            if (r == 2)
            {
                CheckRealise = true;
                //Etat0 = true;
                Message = "Commande réalisée";
            }
            Etat = r;
            if (Arret)
            {
                return;
            }
            if (r < 0) { CheckState = true; }
        }

        public void SetActivation(bool chkArret, bool chkEpuise, bool chkCommande, bool chkMdh)
        {
            Arret = false; Epuise = false;
            if (chkArret) { Arret = true; }
            if (chkEpuise) { Epuise = true; }
            if (chkMdh) { Etat0 = true; }
            else { Etat0 = false; }
            if (Arret)
            {
                Etat = -1;
                return;
            }
            if (chkCommande) { Etat = 1; }
            else
            {
                Etat = 0;
            }
        }

        public override string ToString()
        {
            string result = null;
            result = "Etat0 = " + Etat0 + ", Etat1= " + Etat1;
            return result;
        }

        private void Init()
        {
            Etat0 = false;
            Etat1 = false;
            Etat2 = false;
        }
    }

    public partial class ProdItem
    {
        public bool DuplicateError { get; set; }
        public bool IsValid { get; set; }

        public void Copy(ProdModel model)
        {
            Id = model.Id;
            Nom = model.Nom;
            Prix = model.Prix;
            Iu = model.Iu;
            Quantite = model.Quantite;
            DuplicateError = model.DuplicateError;
            Code = model.Code;
            Refce = model.Refce;
            Pid = model.Pid;
            Description = model.Description;
            Drapeau = model.Drapeau;
            Rq = model.Rq;
        }

        public void Copy(ProdCheck model)
        {
            Id = model.Id;
            Nom = model.Nom;
            Prix = model.Prix;
            Iu = model.Iu;
            Quantite = model.Quantite;
            DuplicateError = model.DuplicateError;
            Code = model.Code;
            Refce = model.Refce;
            Pid = model.Pid;
            Description = model.Description;
            Drapeau = model.Drapeau;
            Rq = model.Rq;
            Epuise = model.Epuise;
            Arret = model.Arret;
            Etat = model.Etat;
            Etat0 = model.Etat0;
            Etat1 = model.Etat1;
            Etat2 = model.Etat2;
        }
    }

    public class ProdModel
    {
        public string Code { get; set; }

        public string Description { get; set; }
        public long Drapeau { get; set; }
        public bool DuplicateError { get; set; }
        public long Id { get; set; }

        public bool IsValid { get; set; }
        public long Iu { get; set; }
        public string Nom { get; set; }
        public long Pid { get; set; }
        public float Prix { get; set; }
        public float Quantite { get; set; }
        public string Refce { get; set; }
        public string Rq { get; set; }

        public void Copy(ProdItem item)
        {
            Id = item.Id;
            Nom = item.Nom;
            if (item.Prix != null) Prix = (float)item.Prix;
            if (item.Iu != null) Iu = (long)item.Iu;
            if (item.Quantite != null) Quantite = (float)item.Quantite;
            if (item.Pid != null) Pid = (long)item.Pid;
            DuplicateError = item.DuplicateError;
            Code = item.Code;
            Description = item.Description;
            Refce = item.Refce;
            Drapeau = item.Drapeau;
            Rq = item.Rq;
        }

        public void HasError()
        {
            if (Nom == null)
            {
                IsValid = false;
            }
        }
    }

    public class ProdRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(ProdItem prod)
        {
            _context.ProdItems.InsertOnSubmit(prod);
        }

        public int Count()
        {
            return _context.ProdItems.Count();
        }

        public bool Create(ProdModel model)
        {
            var prod = new ProdItem();
            model.Id = Count() + 1;
            prod.Copy(model);
            Add(prod);
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

        public void Delete(ProdItem prod)
        {
            _context.ProdItems.DeleteOnSubmit(prod);
        }

        public ProdItem Get(long id)
        {
            return _context.ProdItems.SingleOrDefault(d => d.Id == id);
        }

        public bool IsCommandValid(long id)
        {
            var item = Get(id);
            if (item.Arret)
            {
                return false;
            }
            return true;
        }

        public IQueryable<ProdItem> Prods()
        {
            return _context.ProdItems;
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

        public bool Update(ProdModel model)
        {
            ProdItem item = Get(model.Id);
            item.Copy(model);
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

        public bool Update(ProdCheck model)
        {
            ProdItem item = Get(model.Id);
            item.Copy(model);
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

        public bool UpdateAuto(long id, float quantite)
        {
            ProdItem item = Get(id);
            item.Quantite = quantite;
            item.Auto = 0;
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

        public bool UpdateCorrection(long id)
        {
            ProdItem item = Get(id);
            item.Epuise = false;
            item.Arret = false;
            item.Auto = -1;
            item.Etat = -1;
            item.Etat0 = false;
            item.Etat1 = false;
            item.Etat2 = false;
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