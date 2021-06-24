using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class DateHelpers
    {
        public static void Create(DiaryItem item)
        {
            var reptory = new PrintRepository();
            reptory.Create(item);
        }

        public static void CreatePrinting(CashModel model)
        {
            var reptory = new PrintRepository();
            model.Groupe = 12;
            reptory.Create(model);
        }

        public static void Delete(long id)
        {
            var printReptory = new PrintRepository();
            printReptory.Delete(id);
        }

        public static IEnumerable<ImpotItem> FilterImpots(IEnumerable<ImpotItem> liste, DateTime debut,
           DateTime fin)
        {
            debut = debut.AddDays(-1);
            return liste.Where(prime => (prime.D2 <= fin) && (prime.D2 >= debut));
        }

        public static IEnumerable<PersonnelItem> FilterPrimes(IEnumerable<PersonnelItem> liste, DateTime debut,
            DateTime fin)
        {
            debut = debut.AddDays(-1);
            return liste.Where(prime => (prime.Daty <= fin) && (prime.Daty >= debut));
        }

        public static DateModel Get(DateTime debut, DateTime fin, bool showing)
        {
            var model = new DateModel
            {
                Debut = debut,
                Fin = fin,
                Dated = showing
            };
            return model;
        }

        public static PrintItem Get(long id)
        {
            var reptory = new PrintRepository();
            return reptory.Get(id);
        }

        public static float GetAmountPrime(long id)
        {
            float total = 0;
            foreach (var item in GetPrime(id))
            {
                float r = 0;
                if (item.Montant != null)
                {
                    r = (float)item.Montant;
                }
                total += r;
            }
            return total;
        }

        public static float GetAmountPrimeList(List<PersonnelItem> liste)
        {
            float total = 0;
            foreach (var item in liste)
            {
                float r = 0;
                if (item.Montant != null)
                {
                    r = (float)item.Montant;
                }
                total += r;
            }
            return total;
        }

        public static IEnumerable<PrintItem> GetComplementList(long groupe)
        {
            return GetList().Where(item => item.Groupe != groupe);
        }

        public static IEnumerable<PrintItem> GetGroupedList(long groupe)
        {
            return GetList().Where(item => item.Groupe == groupe);
        }

        public static IEnumerable<ImpotItem> GetImpots()
        {
            var cart = new ImpotCart();
            return cart.Impots;
        }

        public static List<PrintItem> GetList()
        {
            var cart = new PrintCart();
            return cart.Prints;
        }

        public static IEnumerable<CommandeItem> GetListCommande(long id)
        {
            var cart = new CommandeCart();
            return cart.Commandes.Where(item => item.Rang == id);
        }

        public static string GetNamePrimed(long id)
        {
            var reptory = new BonusRepository();
            var item = reptory.Get(id);
            if (item == null)
            {
                return null;
            }
            long numero = 0;
            if (item.Numero != null) numero = (long)item.Numero;
            return PersonHelpers.GetName(numero);
        }

        public static PersonnelItem GetPersonnelItem(long id)
        {
            var reptory = new PersonnelRepository();
            return reptory.Get(id);
        }

        public static IEnumerable<PrintItem> GetPrimaryList()
        {
            return GetList().Where(printItem => (printItem.Groupe == 2) || (printItem.Groupe == 9));
        }

        public static IEnumerable<PersonnelItem> GetPrime(long id)
        {
            return GetPrimeItems().Where(personnelItem => personnelItem.Wid == id);
        }

        public static IEnumerable<PersonnelItem> GetPrimeItems()
        {
            var cart = new PersonnelCart();
            return cart.Personnels;
        }

        public static IEnumerable<XmlItem> GetXmlItems()
        {
            var cart = new XmlCart();
            return cart.Xmls;
        }

        public static void UpdateBon(long id)
        {
            var printReptory = new PrintRepository();
            printReptory.UpdateGroup(id, 11);
        }

        public static void UpdateCancel(long id)
        {
            var printReptory = new PrintRepository();
            printReptory.UpdateGroup(id, 13);
        }

        public static void UpdateGroupe(long id)
        {
            var printReptory = new PrintRepository();
            printReptory.UpdateGroup(id, 12);
        }
    }

    public class CommandeCart : IEnumerable<CommandeItem>
    {
        public CommandeCart()
        {
            Commandes = new List<CommandeItem>();
            var repository = new CommandeRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (CommandeItem element in repository.Commandes())
            {
                CommandeItem item = element;
                if (element.Rang != null)
                {
                    var r = (long)element.Rang;
                    item.Ndx = StdCalcul.AfficherPrix(element.Id) + @"-" + StdCalcul.AfficherPrix(r);
                }
                Commandes.Add(item);
            }
        }

        public List<CommandeItem> Commandes { get; set; }

        public IEnumerator<CommandeItem> GetEnumerator()
        {
            return Commandes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class CommandeItem
    {
        public string Ndx { get; set; }
    }

    public class CommandeRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(CommandeItem item)
        {
            _context.CommandeItems.InsertOnSubmit(item);
        }

        public IQueryable<CommandeItem> Commandes()
        {
            return _context.CommandeItems;
        }

        public int Count()
        {
            return _context.CommandeItems.Count();
        }

        public bool Delete(long id)
        {
            CommandeItem item = Get(id);
            if (item == null)
            {
                return false;
            }
            try
            {
                _context.CommandeItems.DeleteOnSubmit(item);
                _context.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Delete(CommandeItem item)
        {
            _context.CommandeItems.DeleteOnSubmit(item);
        }

        public CommandeItem Get(long id)
        {
            return _context.CommandeItems.SingleOrDefault(d => d.Id == id);
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

    public class DateModel
    {
        public bool Dated { get; set; }

        public DateTime Debut { get; set; }

        public DateTime Fin { get; set; }
    }

    public class ImpotCart : IEnumerable<ImpotItem>
    {
        public ImpotCart()
        {
            Impots = new List<ImpotItem>();
            var repository = new ImpotRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (ImpotItem element in repository.Impots())
            {
                ImpotItem item = element;
                if ((item.VenteExo > 0) && (item.VenteExo < 250))
                {
                    item.VenteTaxable += item.VenteExo;
                    item.VenteExo = 0;
                }
                if (item.VenteExo < 0)
                {
                    item.VenteTotal = item.VenteTaxable;
                    item.VenteExo = 0;
                }
                Impots.Add(item);
            }
        }

        public List<ImpotItem> Impots { get; set; }

        public IEnumerator<ImpotItem> GetEnumerator()
        {
            return Impots.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ImpotRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(ImpotItem item)
        {
            _context.ImpotItems.InsertOnSubmit(item);
        }

        public int Count()
        {
            return _context.ImpotItems.Count();
        }

        public bool Delete(long id)
        {
            ImpotItem item = Get(id);
            if (item == null)
            {
                return false;
            }
            try
            {
                Delete(item);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Delete(ImpotItem item)
        {
            _context.ImpotItems.DeleteOnSubmit(item);
            _context.SubmitChanges();
        }

        public ImpotItem Get(long id)
        {
            return _context.ImpotItems.SingleOrDefault(d => d.Id == id);
        }

        public IQueryable<ImpotItem> Impots()
        {
            return _context.ImpotItems;
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

    public class PersonnelCart : IEnumerable<PersonnelItem>
    {
        public PersonnelCart()
        {
            Personnels = new List<PersonnelItem>();
            var reptory = new PersonnelRepository();
            foreach (PersonnelItem item in reptory.Personnels())
            {
                float montant = 0;
                if (item.Montant != null)
                {
                    montant = (float)item.Montant;
                }
                item.Primus = StdCalcul.DoubleToSpaceFormat(montant);
                Personnels.Add(item);
            }
        }

        public List<PersonnelItem> Personnels { get; set; }

        public IEnumerator<PersonnelItem> GetEnumerator()
        {
            return Personnels.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class PersonnelItem
    {
        public float Reglement { get; set; }
        public string Primus { get; set; }
    }

    public class PersonnelRepository
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(PersonnelItem item)
        {
            _context.PersonnelItems.InsertOnSubmit(item);
            Save();
        }

        public int Count()
        {
            return _context.PersonnelItems.Count();
        }

        public void Delete(PersonnelItem item)
        {
            _context.PersonnelItems.DeleteOnSubmit(item);
            Save();
        }

        public PersonnelItem Get(long id)
        {
            return _context.PersonnelItems.SingleOrDefault(d => d.Id == id);
        }

        public IQueryable<PersonnelItem> Personnels()
        {
            return _context.PersonnelItems;
        }

        public void Save()
        {
            _context.SubmitChanges();
        }
    }

    public partial class ImpotItem
    {
        public float Frais { get; set; }

        public float Solde { get; set; }
    }

    public class PrintCart : IEnumerable<PrintItem>
    {
        public PrintCart()
        {
            Prints = new List<PrintItem>();
            var repository = new PrintRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (PrintItem element in repository.Prints())
            {
                PrintItem item = element;
                Prints.Add(item);
            }
        }

        public List<PrintItem> Prints { get; set; }

        public IEnumerator<PrintItem> GetEnumerator()
        {
            return Prints.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class PrintItem
    {
        public void Copy(DiaryItem item)
        {
            Id = item.Id;
            if (item.Groupe != null) Groupe = (long)item.Groupe;
            Titre = item.Titre;
            Tache = item.Tache;
        }

        public void Copy(CashModel model)
        {
            DiaryItem diary = DiaryHelpers.Get(model.Id);
            Id = diary.Id;
            Groupe = model.Groupe;
            Titre = diary.Titre;
            Tache = diary.Tache;
        }

        public void Copy(TicketItem item)
        {
            Id = item.Id;
        }
    }

    public class PrintRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(PrintItem item)
        {
            _context.PrintItems.InsertOnSubmit(item);
        }

        public int Count()
        {
            return _context.PrintItems.Count();
        }

        public bool Create(CashModel model)
        {
            var item = new PrintItem();
            item.Copy(model);
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

        public bool Create(DiaryItem model)
        {
            var item = new PrintItem();
            item.Copy(model);
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

        public bool Create(long id, long groupe)
        {
            var item = new PrintItem { Id = id, Groupe = groupe };
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

        public bool CreateForPrint(CashModel model)
        {
            var item = new PrintItem();
            item.Copy(model);
            item.Groupe = 11;
            Add(item);
            _context.SubmitChanges();
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

        public bool Delete(long id)
        {
            PrintItem item = Get(id);
            if (item == null)
            {
                return false;
            }
            try
            {
                _context.PrintItems.DeleteOnSubmit(item);
                _context.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Delete(PrintItem item)
        {
            _context.PrintItems.DeleteOnSubmit(item);
        }

        public PrintItem Get(long id)
        {
            return _context.PrintItems.SingleOrDefault(d => d.Id == id);
        }

        public IQueryable<PrintItem> Prints()
        {
            return _context.PrintItems;
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

        public void UpdateGroup(long id, long group)
        {
            var item = Get(id);
            if (item == null)
            {
                return;
            }
            item.Groupe = group;
            item.Tache = "RG";
            if (group == 11)
            {
                item.Tache = "AR";
                item.Titre = "ATTENTE";
            }
            item.Titre = "PAIEMENT";
            Save();
        }
    }

    public class XmlCart : IEnumerable<XmlItem>
    {
        public XmlCart()
        {
            var reptory = new XmlRepository();
            foreach (XmlItem item in reptory.Xmls())
            {
                Xmls.Add(item);
            }
        }

        public List<XmlItem> Xmls { get; set; }

        public IEnumerator<XmlItem> GetEnumerator()
        {
            return Xmls.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class XmlItem
    {
        public void Copy(OperationItem item)
        {
            Id = item.Ndx;
            Code = item.RCode;
            Reference = item.Refers;
            Nom = item.Designation;
            if (item.QStock != null) Quantite = item.QStock;
            if (item.PDetail != null) Prix = item.PDetail;
        }
    }

    public class XmlRepository
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(XmlItem item)
        {
            _context.XmlItems.InsertOnSubmit(item);
            Save();
        }

        public int Count()
        {
            return _context.XmlItems.Count();
        }

        public void Delete(XmlItem item)
        {
            _context.XmlItems.DeleteOnSubmit(item);
            Save();
        }

        public XmlItem Get(long id)
        {
            return _context.XmlItems.SingleOrDefault(d => d.Id == id);
        }

        public void Save()
        {
            _context.SubmitChanges();
        }

        public IQueryable<XmlItem> Xmls()
        {
            return _context.XmlItems;
        }
    }
}