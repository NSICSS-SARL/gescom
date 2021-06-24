using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace gescom.data.Models
{
    public interface IData
    {
        int Count();

        bool Save();
    }

    public static class CompteHelpers
    {
        public static void Create(CashModel model)
        {
            PersonModel p = PersonHelpers.Get(model.Pid);
            long groupe = model.Groupe;
            string s = DiaryHelpers.GetTask(groupe);
            string refce = model.Id.ToString("D");
            string libelle = s + @" -" + refce + @"- " + p.Nom;
            var item = new CompteItem
            {
                Id = model.Id,
                Numero = model.Id,
                Libelle = libelle,
                Refce = refce,
                Groupe = groupe
            };
            var reptory = new CompteRepository();
            if (groupe == 0)
            {
                item.Debit = 0;
                item.Credit = model.Montant;
                reptory.Add(item);
                return;
            }
            item.Credit = 0;
            item.Debit = model.Montant;
            reptory.Add(item);
        }

        public static void Create(DiaryItem diary, long pid, float montant)
        {
            string s = DiaryHelpers.GetTask(17);
            long id = diary.Id;
            string refce = id.ToString("D");
            PersonModel p = PersonHelpers.Get(pid);
            string libelle = s + @" -" + refce + @"- " + p.Nom;
            var item = new CompteItem
            {
                Id = id,
                Numero = id,
                Libelle = libelle,
                Refce = refce,
                Groupe = 17
            };
            var reptory = new CompteRepository();
            item.Credit = 0;
            item.Debit = montant;
            reptory.Add(item);
        }

        public static void Create(long id)
        {
            float montant = ActionHelpers.GetAmountedBonus(id);
            if (montant <= 0)
            {
                return;
            }
            string s = DiaryHelpers.GetTask(20);
            string refce = id.ToString("D");
            PersonnelItem p = DateHelpers.GetPersonnelItem(id);
            string libelle = s + @" -" + refce + @"- " + p.Nom;
            long wid = 0;
            if (p.Wid != null)
            {
                wid = (long)p.Wid;
            }
            var item = new CompteItem
            {
                Numero = id,
                Libelle = libelle,
                Refce = refce,
                Groupe = 20
            };
            var reptory = new CompteRepository();
            var diary1 = new DiaryModel(20, wid);
            DiaryItem d1 = DiaryHelpers.Create(diary1);
            item.Id = d1.Id;
            item.Debit = 0;
            item.Credit = montant;
            reptory.Add(item);
        }

        public static bool Create(bool isDebit, long pid, string refce, string libelle, string valeur)
        {
            if (string.IsNullOrEmpty(refce))
            {
                return false;
            }
            if (string.IsNullOrEmpty(libelle))
            {
                return false;
            }
            if (pid <= 0)
            {
                return false;
            }
            float montant;
            try
            {
                montant = float.Parse(valeur);
            }
            catch (Exception)
            {
                return false;
            }
            if (montant <= 0)
            {
                return false;
            }
            float debit;
            float credit;
            if (isDebit)
            {
                debit = montant;
                credit = 0;
            }
            else
            {
                credit = montant;
                debit = 0;
            }
            PersonModel p = PersonHelpers.Get(pid);
            long groupe;
            switch (p.Groupe)
            {
                case 0:
                    groupe = 18;
                    break;

                case 5:
                    groupe = 21;
                    break;

                default:
                    groupe = 19;
                    break;
            }
            var item = new CompteItem
            {
                Libelle = libelle,
                Refce = refce,
                Groupe = groupe,
                Debit = debit,
                Credit = credit
            };
            var reptory = new CompteRepository();
            var diary1 = new DiaryModel(groupe, p.Id);
            DiaryItem d1 = DiaryHelpers.Create(diary1);
            item.Id = d1.Id;
            reptory.Add(item);
            return true;
        }

        public static void Create(long id, float montant)
        {
            DiaryItem diary = DiaryHelpers.Get(id);
            if (diary == null)
            {
                return;
            }
            long pid = 0;
            if (diary.Pid != null)
            {
                pid = (long)diary.Pid;
            }
            PersonModel p = PersonHelpers.Get(pid);
            if (p == null)
            {
                return;
            }
            long groupe = p.Groupe;
            long g = 0;
            if (groupe == 0)
            {
                g = 18;
            }
            if ((groupe > 0) && (groupe < 5))
            {
                g = 11;
            }
            if (groupe == 5)
            {
                g = 20;
            }
            string s = DiaryHelpers.GetTask(g);
            string refce = id.ToString("D");
            string libelle = s + @" -" + refce + @"- " + p.Nom;
            var item = new CompteItem
            {
                Numero = id,
                Libelle = libelle,
                Refce = refce,
                Groupe = g
            };
            var reptory = new CompteRepository();
            if (g == 11)
            {
                item.Debit = 0;
                item.Credit = montant;
                var diary1 = new DiaryModel(g, p.Id);
                DiaryItem d1 = DiaryHelpers.Create(diary1);
                item.Id = d1.Id;
                reptory.Add(item);
                return;
            }
            item.Credit = 0;
            item.Debit = montant;
            var diary2 = new DiaryModel(g, p.Id);
            DiaryItem d2 = DiaryHelpers.Create(diary2);
            item.Id = d2.Id;
            reptory.Add(item);
        }

        public static void DoReturn(DiaryItem diary, float montant)
        {
            if (diary == null)
            {
                return;
            }
            long id = diary.Id;
            long pid = 0;
            if (diary.Pid != null)
            {
                pid = (long)diary.Pid;
            }
            PersonModel p = PersonHelpers.Get(pid);
            if (p == null)
            {
                return;
            }
            string s = DiaryHelpers.GetTask(1);
            string refce = id.ToString("D");
            string libelle = s + @" -" + refce + @"- " + p.Nom;
            var item = new CompteItem
            {
                Id = id,
                Numero = id,
                Libelle = libelle,
                Refce = refce,
                Groupe = 1
            };
            var reptory = new CompteRepository();
            item.Debit = 0;
            item.Credit = montant;
            reptory.Add(item);
        }

        public static List<SoldeItem> FilterSoldeByDate(IEnumerable<SoldeItem> liste, DateTime debut,
            DateTime fin)
        {
            return liste.Where(text => (text.Datum <= fin.Date) && (text.Datum >= debut.Date)).ToList();
        }

        public static float GetAnteriorSolde(IEnumerable<SoldeItem> liste, DateTime fin)
        {
            var debut = new DateTime(2015, 05, 01);
            if (debut.Date >= fin.Date)
            {
                return 0;
            }
            List<SoldeItem> myList = FilterSoldeByDate(liste, debut, fin);
            return myList.Count == 0 ? 0 : myList.Sum(item => item.Debit - item.Credit);
        }

        public static List<SoldeItem> GetCompteItems(long id)
        {
            var cart = new SoldeCart();
            return cart.Where(item => item.Pid == id).ToList();
        }

        public static LastItem GetLastItem(long id)
        {
            var reptory = new LastRepository();
            return reptory.Get(id);
        }

        public static float GetSolde(long pid)
        {
            var cart = new SoldeCart();
            float solde = cart.Soldes.Where(item => item.Pid == pid).Sum(item => item.Credit - item.Debit);
            PersonModel p = PersonHelpers.Get(pid);
            if ((p.Groupe > 0) && (p.Groupe < 5))
            {
                solde = -1 * solde;
            }
            return solde;
        }

        public static List<SoldeText> GetSoldeTexts(List<SoldeItem> liste)
        {
            var result = new List<SoldeText>();
            foreach (SoldeItem item in liste)
            {
                var text = new SoldeText();
                text.Copy(item);
                result.Add(text);
            }
            return result;
        }
    }

    public static class FormelHelpers
    {
        public static IEnumerable<FormelModel> FilterDeclare(IEnumerable<FormelModel> liste, DateTime debut,
            DateTime fin)
        {
            //debut = debut.AddDays(-1);
            return liste.Where(prime => (prime.D1.Date <= fin.Date) && (prime.D1.Date >= debut.Date));
        }

        public static IEnumerable<FormelModel> GetFormalisme()
        {
            var cart = new FormelCart();
            return cart.Formels;
        }

        public static IEnumerable<FormelModel> GetFormels()
        {
            return GetFormalisme().Where(model => model.IsFormel);
        }

        public static IEnumerable<FormelModel> GetOutFormels()
        {
            var result = new List<FormelModel>();
            foreach (FormelModel model in GetFormels())
            {
                model.Taxable -= model.Frais;
                model.Collecte = model.Taxable * PriceHelpers.GetTaxe() / 100;
                model.Exo = model.Total - model.Taxable;
                result.Add(model);
            }
            return result;
        }
    }

    public static class TimerHelpers
    {
        public static void Backup()
        {
            DataHelpers.SaveLocal();
            DataHelpers.SaveGeneral();
        }

        public static bool TestTimer(string message)
        {
            if (File.Exists(@"c:\glite\bin\test.txt"))
            {
                try
                {
                    var fluxInfos = new StreamWriter(@"c:\glite\bin\test.txt", true);
                    string line = message + ": " + DateTime.Now.ToString("G");
                    fluxInfos.WriteLine(line);
                    fluxInfos.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("File write error : " + e.Message);
                    return false;
                }
                return true;
            }
            {
                try
                {
                    using (TextWriter file = File.CreateText(@"c:\glite\bin\test.txt"))
                    {
                        file.WriteLine(@"Creating file: " + DateTime.Now.ToString("G"));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("File create error : " + e.Message);
                    return false;
                }
            }
            return true;
        }

        public static bool TestTimer()
        {
            if (File.Exists(@"c:\glite\bin\test.txt"))
            {
                StreamWriter fluxInfos;
                using (fluxInfos = new StreamWriter(@"c:\glite\bin\test.txt", true))
                {
                    try
                    {
                        string line = @"The Elapsed event was raised at " + DateTime.Now.ToString("G");
                        fluxInfos.WriteLine(line);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("File write error : " + e.Message);
                        return false;
                    }
                }
                return true;
            }
            {
                try
                {
                    using (TextWriter file = File.CreateText(@"c:\glite\bin\test.txt"))
                    {
                        file.WriteLine(@"Creating file: " + DateTime.Now.ToString("G"));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("File create error : " + e.Message);
                    return false;
                }
            }
            return true;
        }
    }

    public class CompteCart : IEnumerable<CompteItem>
    {
        public CompteCart()
        {
            Comptes = new List<CompteItem>();
            var repository = new CompteRepository();
            Parallel.ForEach(repository.Comptes().ToList(), item =>
            {
                lock (Comptes)
                {
                    Comptes.Add(item);
                }
            });
        }

        public List<CompteItem> Comptes { get; set; }

        public IEnumerator<CompteItem> GetEnumerator()
        {
            return Comptes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class CompteItem
    {
        public bool IsDebit { get; set; }
    }

    public class CompteRepository
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(CompteItem item)
        {
            _context.CompteItems.InsertOnSubmit(item);
            Save();
        }

        public IQueryable<CompteItem> Comptes()
        {
            return _context.CompteItems;
        }

        public int Count()
        {
            return _context.CompteItems.Count();
        }

        public void Delete(CompteItem item)
        {
            _context.CompteItems.DeleteOnSubmit(item);
            Save();
        }

        public CompteItem Get(long id)
        {
            return _context.CompteItems.SingleOrDefault(d => d.Id == id);
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

    public class FormelCart : IEnumerable<FormelModel>
    {
        public FormelCart()
        {
            Formels = new List<FormelModel>();
            var repository = new FormelRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (FormelItem item in repository.Formels())
            {
                var model = new FormelModel();
                model.Copy(item);
                Formels.Add(model);
            }
        }

        public List<FormelModel> Formels { get; set; }

        public IEnumerator<FormelModel> GetEnumerator()
        {
            return Formels.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class FormelModel
    {
        public string Adresse { get; set; }

        public float Collecte { get; set; }

        public DateTime D1 { get; set; }

        public float Exo { get; set; }

        public float Frais { get; set; }

        public long Id { get; set; }

        public bool IsFormel { get; set; }

        public bool IsTaxable { get; set; }

        public string Nom { get; set; }

        public float Profit { get; set; }

        public string Reference { get; set; }

        public float Taxable { get; set; }

        public float Total { get; set; }

        public void Copy(FormelItem item)
        {
            Id = item.Id;
            Nom = item.Nom;
            Adresse = item.Adresse;
            if (item.D1 != null)
            {
                D1 = (DateTime)item.D1;
                if (item.D1 != null)
                {
                    var date = (DateTime)item.D1;
                    Reference = date.ToString("d") + "-" + item.T1 + "-" + item.O1;
                }
            }
            if (item.Collecte != null)
            {
                var coll = (float)item.Collecte;
                Collecte = coll;
                IsTaxable = !(Collecte <= 0);
            }
            float taxed = 0;
            float exo = 0;
            if (item.VenteTaxable != null)
            {
                taxed = (float)item.VenteTaxable;
            }
            if (item.VenteExo != null)
            {
                exo = (float)item.VenteExo;
            }
            if (exo <= 0)
            {
                exo = 0;
            }
            Exo = exo;
            Taxable = taxed;
            Total = Exo + Taxable;
            if (item.Profit != null) Profit = (float)item.Profit;
            if (item.Frais != null) Frais = (float)item.Frais;
            long forme = 0;
            if (item.Forme != null) forme = (long)item.Forme;
            if (forme == 0)
            {
                IsFormel = false;
                return;
            }
            IsFormel = true;
        }
    }

    public class FormelRepository
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(FormelItem item)
        {
            _context.FormelItems.InsertOnSubmit(item);
            Save();
        }

        public int Count()
        {
            return _context.FormelItems.Count();
        }

        public void Delete(FormelItem item)
        {
            _context.FormelItems.DeleteOnSubmit(item);
            Save();
        }

        public IQueryable<FormelItem> Formels()
        {
            return _context.FormelItems;
        }

        public FormelItem Get(long id)
        {
            return _context.FormelItems.SingleOrDefault(d => d.Id == id);
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

    public class LastCart : IEnumerable<LastItem>
    {
        public LastCart()
        {
            Lasts = new List<LastItem>();
            var repository = new LastRepository();
            Parallel.ForEach(repository.Lasts().ToList(), item =>
            {
                lock (Lasts) Lasts.Add(item);
            });
        }

        public List<LastItem> Lasts { get; set; }

        public IEnumerator<LastItem> GetEnumerator()
        {
            return Lasts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class LastRepository
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(LastItem item)
        {
            _context.LastItems.InsertOnSubmit(item);
            Save();
        }

        public int Count()
        {
            return _context.LastItems.Count();
        }

        public void Delete(LastItem item)
        {
            _context.LastItems.DeleteOnSubmit(item);
            Save();
        }

        public LastItem Get(long id)
        {
            return _context.LastItems.SingleOrDefault(d => d.Pid == id);
        }

        public IQueryable<LastItem> Lasts()
        {
            return _context.LastItems;
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

    public class SoldeCart : IEnumerable<SoldeItem>
    {
        public SoldeCart()
        {
            Soldes = new List<SoldeItem>();
            var repository = new SoldeRepository();
            Parallel.ForEach(repository.Soldes().ToList(), item =>
            {
                lock (Soldes) Soldes.Add(item);
            });
        }

        public List<SoldeItem> Soldes { get; set; }

        public IEnumerator<SoldeItem> GetEnumerator()
        {
            return Soldes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class SoldeRepository
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(SoldeItem item)
        {
            _context.SoldeItems.InsertOnSubmit(item);
            Save();
        }

        public int Count()
        {
            return _context.SoldeItems.Count();
        }

        public void Delete(SoldeItem item)
        {
            _context.SoldeItems.DeleteOnSubmit(item);
            Save();
        }

        public SoldeItem Get(long id)
        {
            return _context.SoldeItems.SingleOrDefault(d => d.Id == id);
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

        public IQueryable<SoldeItem> Soldes()
        {
            return _context.SoldeItems;
        }
    }

    public class SoldeText
    {
        public string Credit { get; set; }

        public DateTime Datum { get; set; }

        public string Daty { get; set; }

        public string Debit { get; set; }

        public string Id { get; set; }

        public string Libelle { get; set; }

        public string Refce { get; set; }

        public void Copy(SoldeItem item)
        {
            Id = StdCalcul.DoubleToSpaceFormat(item.Id);
            Debit = StdCalcul.DoubleToSpaceFormat(item.Debit);
            Credit = StdCalcul.DoubleToSpaceFormat(item.Credit);
            if (item.Datum != null)
            {
                Datum = (DateTime)item.Datum;
                Daty = Datum.ToString("d");
            }
            Refce = item.Refce;
            Libelle = item.Libelle;
        }
    }
}