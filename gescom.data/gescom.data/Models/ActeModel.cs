using System;
using System.Linq;

namespace gescom.data.Models
{
    public static class ActeHelpers
    {
        public static void Create(long id)
        {
            var repo = new ActeItemRepository();
            repo.Create(id);
            VoirHelpers.Create(id);
        }

        public static ActeItem Get(long id)
        {
            var repo = new ActeItemRepository();
            return repo.Get(id);
        }


        public static bool Update(ActeModel model)
        {
            var repo = new ActeItemRepository();
            return repo.Update(model);
        }
    }

    public static class VoirHelpers
    {
        public static void Create(long id)
        {
            var repo = new VoirItemRepository();
            repo.Create(id);
        }

        public static VoirItem Get(long id)
        {
            var repo = new VoirItemRepository();
            return repo.Get(id);
        }


        public static bool Update(VoirModel model)
        {
            var repo = new VoirItemRepository();
            return repo.Update(model);
        }
    }

    public partial class ActeItem
    {
        public ActeItem(long id)
        {
            Id = id;
            Danger = 0;
            Question = 0;
            Super = 0;
            Placer = 0;
            Verif = 0;
            Cause = 0;
            Entrer = 0;
            Priter = 0;
            Qcder = 0;
        }

        public void Copy(ActeModel model)
        {
            Danger = model.Danger;
            Question = model.Question;
            Super = model.Super;
            Placer = model.Placer;
            Verif = model.Verif;
            Cause = model.Cause;
            Couleur = model.Couleur;
            State = model.State;
            Entrer = model.Entrer;
            Priter = model.Priter;
            Qcder = model.Qcder;
        }
    }

    public class ActeItemRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.ActeItems.Count();
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


        public void Add(ActeItem item)
        {
            _context.ActeItems.InsertOnSubmit(item);
        }

        public bool Create(long id)
        {
            var item = new ActeItem(id);
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


        public ActeItem Get(long id)
        {
            return _context.ActeItems.SingleOrDefault(d => d.Id == id);
        }

        public bool Update(ActeModel model)
        {
            var item = Get(model.Id);
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

    public class ActeModel
    {
        public ActeModel()
        {
            //
        }

        public ActeModel(ActeItem item)
        {
            Id = item.Id;
            Copy(item);
        }


        public int Cause { get; set; }
        public string Couleur { get; set; }
        public int Danger { get; set; }
        public int Entrer { get; set; }
        public long Id { get; set; }
        public int Placer { get; set; }
        public int Priter { get; set; }
        public double Qcder { get; set; }
        public int Question { get; set; }
        public string State { get; set; }
        public int Super { get; set; }
        public int Verif { get; set; }

        public void Copy(ActeItem item)
        {
            Danger = item.Danger;
            Question = item.Question;
            Super = item.Super;
            Placer = item.Placer;
            Verif = item.Verif;
            Cause = item.Cause;
            Couleur = item.Couleur;
            State = item.State;
            if (item.Qcder != null)
                Qcder = (double) item.Qcder;
            else
                Qcder = 0;
            if (item.Entrer != null)
                Entrer = (int) item.Entrer;
            else
                Entrer = 0;
            if (item.Priter != null)
                Priter = (int) item.Priter;
            else
                Priter = 0;
        }
    }

    public partial class VoirItem
    {
        public VoirItem(long id)
        {
            Id = id;
            CheckCommande = false;
            VoirEntre = false;
            VoirPrix = false;
            VoirPrior = false;
            VoirPlace = false;
            VoirVerif = false;
            AlertCom = false;
            AlertAch = false;
            AlertVte = false;
        }

        public void Copy(VoirModel model)
        {
            Id = model.Id;
            CheckCommande = model.CheckCommande;
            VoirEntre = model.VoirEntre;
            VoirPrix = model.VoirPrix;
            VoirPrior = model.VoirPrior;
            VoirPlace = model.VoirPlace;
            VoirVerif = model.VoirVerif;
            AlertCom = model.AlertCom;
            AlertAch = model.AlertAch;
            AlertVte = model.AlertVte;
        }
    }

    public class VoirItemRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.VoirItems.Count();
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

        public void Add(VoirItem item)
        {
            _context.VoirItems.InsertOnSubmit(item);
        }

        public bool Create(long id)
        {
            var item = new VoirItem(id);
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


        public VoirItem Get(long id)
        {
            return _context.VoirItems.SingleOrDefault(d => d.Id == id);
        }

        public bool Update(VoirModel model)
        {
            var item = Get(model.Id);
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

    public class VoirModel
    {
        public VoirModel()
        {
            Id = 0;
            CheckCommande = false;
            VoirEntre = false;
            VoirPrix = false;
            VoirPrior = false;
            VoirPlace = false;
            VoirVerif = false;
            AlertCom = false;
            AlertAch = false;
            AlertVte = false;
        }


        public VoirModel(VoirItem item)
        {
            Copy(item);
        }

        public bool CheckCommande { get; set; }
        public long Id { get; set; }
        public bool VoirEntre { get; set; }
        public bool VoirPlace { get; set; }
        public bool VoirPrior { get; set; }
        public bool VoirPrix { get; set; }
        public bool VoirVerif { get; set; }
        public bool AlertCom { get; set; }
        public bool AlertAch { get; set; }
        public bool AlertVte { get; set; }

        public void Copy(VoirItem item)
        {
            Id = item.Id;
            CheckCommande = item.CheckCommande;
            VoirEntre = item.VoirEntre;
            VoirPrix = item.VoirPrix;
            VoirPrior = item.VoirPrior;
            VoirPlace = item.VoirPlace;
            VoirVerif = item.VoirVerif;
            if (item.AlertAch == null)
                item.AlertAch = false;
            else
                AlertAch = (bool) item.AlertAch;
            if (item.AlertVte == null)
                item.AlertVte = false;
            else
                AlertVte = (bool) item.AlertVte;
            if (item.AlertCom == null)
                item.AlertCom = false;
            else
                AlertCom = (bool) item.AlertCom;
            if (item.AlertVte == null)
                item.AlertVte = false;
            else
                AlertVte = (bool) item.AlertVte;
        }
    }
}