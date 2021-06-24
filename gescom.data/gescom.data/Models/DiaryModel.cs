using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class DiaryHelpers
    {
        public static void Cancel(long id)
        {
            if (!SellToAnnulation(id))
            {
                return;
            }
            ActionHelpers.Cancel(id);
            CashHelpers.Cancel(id);
        }

        public static string GetTask(long groupe)
        {
            var diary = new DiaryItem();
            diary.SetTask(groupe);
            return diary.Tache;
        }

        public static void CancelPrintErrors()
        {
            foreach (var item in GetDiaryForPrint())
            {
                UpdateErrorPrint(item.Id);
            }
        }

        public static DiaryItem Create(DiaryModel model)
        {
            var repository = new DiaryRepository();
            var result = repository.Create(model);
            return result;
        }

        public static IEnumerable<DayItem> FilterByDate(IEnumerable<DayItem> liste, DateTime debut, DateTime fin)
        {
            debut = debut.AddDays(-1);
            return liste.Where(item => (item.Datum <= fin) && (item.Datum >= debut));
        }

        public static DiaryItem Get(long id)
        {
            var repository = new DiaryRepository();
            return repository.Get(id);
        }

        public static string GetAmountText(IEnumerable<DayItem> liste)
        {
            return StdCalcul.DoubleToSpaceFormat(GetAmountTotal(liste));
        }

        public static double GetAmountTotal(IEnumerable<DayItem> liste)
        {
            return liste.Sum(model => model.Montant);
        }

        public static IEnumerable<DayItem> GetByGroup(IEnumerable<DayItem> liste, long group)
        {
            return liste.Where(model => model.Groupe == @group).ToList();
        }

        public static IEnumerable<DayItem> GetByPid(long id)
        {
            return GetItems().Where(model => model.Pid == id).ToList();
        }

        public static IEnumerable<DiaryItem> GetDiaryForPrint()
        {
            return GetDiaryItems().Where(item => (item.Printed == null) && (item.Groupe == 2));
        }

        public static IEnumerable<DiaryReceipt> GetReceiptForPrint()
        {
            DataGescomDataContext context = new DataGescomDataContext();
            return context.DiaryReceipts;
        }

        public static long GetDiaryGroup(long id)
        {
            var item = Get(id);
            long groupe = -1;
            if (item.Groupe != null) groupe = (long)item.Groupe;
            return groupe;
        }

        public static IEnumerable<DiaryItem> GetDiaryItems()
        {
            DataGescomDataContext context = new DataGescomDataContext();
            return context.DiaryItems;
        }

        public static DiaryText GetDiaryText(long id)
        {
            var result = new DiaryText();
            var model = new DiaryModel();
            model.Copy(Get(id));
            result.Copy(model);
            return result;
        }

        public static IEnumerable<DayItem> GetForPrint(long index)
        {
            return GetItems().Where(model => model.Groupe == index).ToList();
        }

        public static IEnumerable<DayItem> GetItems()
        {
            DataGescomDataContext context = new DataGescomDataContext();
            return context.DayItems;
        }

        public static DiaryModel GetReference(long id)
        {
            var item = Get(id);
            var model = new DiaryModel();
            model.Copy(item);
            return model;
        }

        public static void ReglerBonus(long id, float montant)
        {
            var p = PersonHelpers.Get(id);
            if (p == null) { return; }
            if (montant <= 0) { return; }
            var day = new DiaryModel(17, id);
            var repository = new DiaryRepository();
            var diary = repository.CreatePrimePayement(day);
            var maxPay = DateHelpers.GetAmountPrime(id);
            if (montant > maxPay) { return; }
            var item = new BonusItem
            {
                Rang = diary.Id,
                Numero = id,
                Prix = -1 * montant,
                Quantite = 1,
                Groupe = 17
            };
            var reptory = new BonusRepository();
            int count = reptory.Count();
            item.Id = count + 1;
            reptory.Add(item);
            reptory.Save();
            var boxReptory = new BoxRepository();
            var box = new BoxItem
            {
                Id = diary.Id,
                Percu = 0,
                Rendu = 0,
                Groupe = 17,
                D1 = diary.Datum,
                D2 = diary.Datum,
                T1 = diary.Hote,
                T2 = diary.Hote,
                O1 = diary.Nom,
                O2 = diary.Nom,
                Adresse = p.Adresse,
                Nom = p.Nom,
                Montant = 0
            };
            boxReptory.Add(box);
            boxReptory.Save();
        }

        public static void Update(DiaryModel model)
        {
            var repository = new DiaryRepository();
            repository.Update(model);
        }

        public static void UpdateErrorPrint(long id)
        {
            var repository = new DiaryRepository();
            repository.Update(id, 1);
        }

        public static void UpdateInitialPrint(long id)
        {
            var repository = new DiaryRepository();
            repository.Update(id, 0);
        }

        private static bool SellToAnnulation(long id)
        {
            var repository = new DiaryRepository();
            return repository.ModifyTask(id, "AN");
        }
    }

    public class DayCart
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        // basic constructor.
        public DayCart()
        {
            Init();
            Days = _context.DayItems;
        }

        public DayCart(long groupe)
        {
            Init();
            Days = DayFilter(groupe);
        }

        public IEnumerable<DayItem> Days { get; set; }

        private IEnumerable<DayItem> DayFilter(long groupe)
        {
            Init();
            return _context.DayItems.Where(day => day.Groupe == groupe);
        }

        private void Init()
        {
            Days = new List<DayItem>();
        }
    }

    public class DayRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(DayItem item)
        {
            _context.DayItems.InsertOnSubmit(item);
        }

        public int Count()
        {
            return _context.DayItems.Count();
        }

        public IQueryable<DayItem> Days()
        {
            return _context.DayItems;
        }

        public DayItem Get(long id)
        {
            return _context.DayItems.SingleOrDefault(d => d.Id == id);
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
    }

    public class DiaryCart
    {
        // basic constructor.
        public DiaryCart()
        {
            Diaries = new List<DiaryItem>();
            var days = new DayCart();
            foreach (var element in days.Days)
            {
                var item = new DiaryItem();
                item.Copy(element);
                Diaries.Add(item);
            }
        }

        public DiaryCart(long groupe)
        {
            Diaries = new List<DiaryItem>();
            var days = new DayCart();
            foreach (var element in days.Days)
            {
                if (element.Groupe != groupe) continue;
                var item = new DiaryItem();
                item.Copy(element);
                Diaries.Add(item);
            }
        }

        public List<DiaryItem> Diaries { get; set; }
    }

    public partial class DiaryItem
    {
        public DiaryItem(long groupe)
        {
            Groupe = groupe;
        }

        public string Info { get; set; }

        public float Montant { get; set; }

        public string PersonName { get; set; }
        public string Titre { get; set; }

        public void Copy(DiaryModel model)
        {
            Id = model.Id;
            Pid = model.Pid;
            Datum = model.Datum;
            Nom = model.Nom;
            Hote = model.Hote;
            Tache = model.Tache;
            Groupe = model.Groupe;
            Montant = model.Montant;
            PersonName = model.PersonName;
            Titre = model.Titre;
            Info = model.Info;
        }

        public void Copy(DayItem item)
        {
            Id = item.Id;
            Pid = item.Pid;
            Datum = item.Datum;
            Nom = item.Nom;
            Hote = item.Hote;
            Tache = item.Tache;
            Groupe = item.Groupe;
            Montant = (float)item.Montant;
            PersonName = item.PersonName;
            Titre = item.Titre;
            Info = item.Info;
        }

        public void SetTask(long groupe)
        {
            var actetype = ActionHelpers.GetSetActionType(groupe);
            Groupe = actetype.Groupe;
            Tache = actetype.Tache;
            Titre = actetype.Titre;
        }
    }

    public class DiaryModel
    {
        public DiaryModel()
        {
            Init();
        }

        public DiaryModel(long groupe)
        {
            Groupe = groupe;
            Initialiser();
        }

        public DiaryModel(long groupe, long pid)
        {
            Groupe = groupe;
            Pid = pid;
            var p = PersonHelpers.Get(pid);
            Forme = p.Forme;
            Initialiser();
        }

        public DiaryModel(PersonModel person)
        {
            Init();
            Pid = person.Id;
            Forme = person.Forme;
        }

        public DateTime Datum { get; set; }

        public long Forme { get; set; }

        public long Groupe { get; set; }

        public string Hote { get; set; }

        public long Id { get; set; }

        public string Info { get; set; }

        public float Montant { get; set; }

        public string Nom { get; set; }

        public string PersonName { get; set; }

        public long Pid { get; set; }
        public string Tache { get; set; }

        public string Titre { get; set; }

        public void Copy(DiaryItem item)
        {
            Id = item.Id;
            if (item.Pid != null) Pid = (long)item.Pid;
            if (item.Datum != null) Datum = (DateTime)item.Datum;
            Nom = item.Nom;
            Hote = item.Hote;
            Tache = item.Tache;
            if (item.Groupe != null) Groupe = (long)item.Groupe;
            Montant = item.Montant;
            PersonName = item.PersonName;
            Info = item.Info;
            Titre = item.Titre;
        }

        public void Initialiser()
        {
            Init();
            var actetype = ActionHelpers.GetSetActionType(Groupe);
            Tache = actetype.Tache;
            Titre = actetype.Titre;
        }

        private void Init()
        {
            var respository = new DiaryRepository();
            Id = respository.Count() + 1;
            Datum = DateTime.Now;
            Nom = Environment.UserName;
            Hote = Environment.MachineName;
            Nom = Nom.ToUpper();
            Hote = Hote.ToUpper();
        }
    }

    public class DiaryRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(DiaryItem taxe)
        {
            _context.DiaryItems.InsertOnSubmit(taxe);
        }

        public int Count()
        {
            return _context.DiaryItems.Count();
        }

        public DiaryItem Create(DiaryModel model)
        {
            var item = new DiaryItem();
            item.Copy(model);
            item.Id = Count() + 1;
            Add(item);
            _context.SubmitChanges();
            var item1 = Get(item.Id);
            DateHelpers.Create(item1);
            return item1;
        }

        public DiaryItem CreatePrimePayement(DiaryModel model)
        {
            var item = new DiaryItem();
            item.Copy(model);
            item.Id = Count() + 1;
            Add(item);
            _context.SubmitChanges();
            return item;
        }

        public void Delete(DiaryItem item)
        {
            _context.DiaryItems.DeleteOnSubmit(item);
        }

        public IQueryable<DiaryItem> Diaries()
        {
            return _context.DiaryItems;
        }

        public DiaryItem Get(long id)
        {
            return _context.DiaryItems.SingleOrDefault(d => d.Id == id);
        }

        public bool ModifyTask(long id, string task)
        {
            bool result = false;
            DiaryItem item = Get(id);
            if (item.Groupe == 2)
            {
                item.SetTask(8);
                _context.SubmitChanges();
                result = true;
            }
            return result;
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

        public void Update(long id, long printed)
        {
            var item = Get(id);
            if (item == null) return;
            item.Printed = printed;
            _context.SubmitChanges();
        }

        public void Update(DiaryModel model)
        {
            var item = Get(model.Id);
            item.Copy(model);
            _context.SubmitChanges();
        }
    }

    public class DiaryText
    {
        public DateTime Datum { get; set; }

        public long Groupe { get; set; }

        public string Hote { get; set; }

        public string Id { get; set; }

        public string Info { get; set; }

        public string Nom { get; set; }

        public string PersonName { get; set; }

        public string Pid { get; set; }

        public string Tache { get; set; }

        public string Titre { get; set; }

        public void Copy(DiaryModel model)
        {
            Id = StdCalcul.DoubleToSpaceFormat(model.Id);
            Pid = StdCalcul.DoubleToSpaceFormat(model.Pid);
            Datum = model.Datum;
            Nom = model.Nom;
            Hote = model.Hote;
            Tache = model.Tache;
            Groupe = model.Groupe;
            PersonName = model.PersonName;
            Titre = model.Titre;
            Info = model.Info;
        }
    }
}