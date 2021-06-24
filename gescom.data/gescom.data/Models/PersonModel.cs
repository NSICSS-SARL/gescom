using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class PersonHelpers
    {
        //création client
        public static bool Create(PersonModel model)
        {
            var repository = new PersonRepository();
            return repository.Create(model);
        }

        //création fournisseur
        public static bool CreateOwner(PersonModel model)
        {
            model.Groupe = -1;
            return Create(model);
        }

        //création fournisseur
        public static bool CreateVendor(PersonModel model)
        {
            model.Groupe = 0;
            return Create(model);
        }

        //création personnel
        public static bool CreateWorker(PersonModel model)
        {
            model.Groupe = 5;
            return Create(model);
        }

        public static PersonModel Get(long id)
        {
            var repository = new PersonRepository();
            var item = repository.Get(id);
            var model = new PersonModel();
            model.Copy(item);
            return model;
        }

        public static List<PersonItem> GetPersonList()
        {
            var ctx = new DataGescomDataContext();
            return ctx.PersonItems.ToList();
        }

        public static IEnumerable<CustomerItem> GetBrutCustomers()
        {
            var context = new DataGescomDataContext();
            return context.CustomerItems;
        }

        public static IEnumerable<VendorItem> GetBrutVendors()
        {
            var context = new DataGescomDataContext();
            return context.VendorItems;
        }

        public static IEnumerable<WorkerItem> GetBrutWorkers()
        {
            var context = new DataGescomDataContext();
            return context.WorkerItems;
        }

        public static IEnumerable<PersonModel> GetCustomers()
        {
            return GetList().Where(model => (model.Groupe > 0) && (model.Groupe < 5));
        }

        public static long GetGroup(long id)
        {
            return Get(id).Groupe;
        }

        public static PersonItem GetItem(long id)
        {
            var repository = new PersonRepository();
            var item = repository.Get(id);
            return item;
        }

        public static IEnumerable<PersonModel> GetList()
        {
            var cart = new PersonCart();
            var result = new List<PersonModel>();
            foreach (var item in cart.Persons)
            {
                var model = new PersonModel();
                model.Copy(item);
                if (item.Id <= 0) continue;
                model.Prime = DateHelpers.GetAmountPrime(model.Id);
                result.Add(model);
            }
            return result;
        }

        public static string GetName(long id)
        {
            return Get(id).Nom;
        }

        public static IEnumerable<VendorItem> GetNoBlankName()
        {
            return GetVendorsList().Where(item => !string.IsNullOrEmpty(item.Code));
        }

        public static IEnumerable<PersonModel> GetVendors()
        {
            return GetList().Where(model => (model.Groupe == 0) && (model.Id > 1));
        }

        public static IEnumerable<VendorItem> GetVendorsList()
        {
            var context = new DataGescomDataContext();
            return context.VendorItems;
        }

        public static IEnumerable<PersonModel> GetWorkers()
        {
            return GetList().Where(model => model.Groupe == 5);
        }

        public static bool Update(PersonModel model)
        {
            var repository = new PersonRepository();
            return repository.Update(model);
        }
    }

    public partial class CustomerItem
    {
        public string LitteralType { get; set; }

        public void Set()
        {
            string titre = null;
            switch (Groupe)
            {
                case -1:
                    titre = "Propriétaire";
                    break;

                case 0:
                    titre = "Fournisseur";
                    break;

                case 1:
                    titre = "Grossiste";
                    break;

                case 2:
                    titre = "Détaillant";
                    break;

                case 3:

                    titre = "Spécial";
                    break;

                case 4:
                    titre = "Extra";
                    break;
            }
            LitteralType = titre;
        }

        public void SetInverse()
        {
            switch (LitteralType)
            {
                case "Propriétaire":
                    Groupe = -1;
                    break;

                case "Fournisseur":
                    Groupe = 0;
                    break;

                case "Grossiste":
                    Groupe = 1;
                    break;

                case "Détaillant":
                    Groupe = 2;
                    break;

                case "Spécial":
                    Groupe = 3;
                    break;

                case "Extra":
                    Groupe = 4;
                    break;
            }
        }
    }

    public class PersonCart : IEnumerable<PersonItem>
    {
        public PersonCart()
        {
            Persons = new List<PersonItem>();
            var repository = new PersonRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (PersonItem element in repository.Persons())
            {
                PersonItem item = element;
                item.Rang = StdCalcul.DoubleToSpaceFormat(item.Id);
                if (item.Groupe == 1)
                {
                    item.Grossiste = true;
                }
                item.IsFormel = item.Forme == 1;
                SetLitteral(item);
                Persons.Add(item);
            }
        }

        public List<PersonItem> Persons { get; set; }

        public IEnumerator<PersonItem> GetEnumerator()
        {
            return Persons.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void SetLitteral(PersonItem item)
        {
            long g = item.Groupe;
            string titre = null;
            switch (g)
            {
                case -1:
                    titre = "PROPRIETAIRE";
                    break;

                case 0:
                    titre = "FOURNISSEUR";
                    break;

                case 1:
                    titre = "GROSSISTE";
                    break;

                case 2:
                    titre = "DETAILLANT";
                    break;

                case 3:

                    titre = "SPECIAL";
                    break;

                case 4:
                    titre = "EXTRA";
                    break;
            }
            item.LitteralType = titre;
        }
    }

    public partial class PersonItem
    {
        public float Credit { get; set; }

        public float Debit { get; set; }

        public bool DuplicateError { get; set; }

        public bool Grossiste { get; set; }

        public bool IsFormel { get; set; }
        public bool IsValid { get; set; }
        public string LitteralType { get; set; }

        public string Rang { get; set; }

        public float Solde { get; set; }

        public void Copy(PersonModel model)
        {
            Id = model.Id;
            Nom = model.Nom;
            Activite = model.Activite;
            Adresse = model.Adresse;
            Complement = model.Complement;
            Ville = model.Ville;
            Tel1 = model.Tel1;
            Tel2 = model.Tel2;
            Tel3 = model.Tel3;
            Fax = model.Fax;
            Email = model.Email;
            Stat = model.Stat;
            Nif = model.Nif;
            Compte = model.Compte;
            Code = model.Code;
            Groupe = model.Groupe;
            Description = model.Description;
            Rang = model.Rang;
            Debit = model.Debit;
            Credit = model.Credit;
            Solde = model.Solde;
            Grossiste = model.Grossiste;
            LitteralType = model.LitteralType;
            Forme = model.Forme;
            IsFormel = model.IsFormel;
            Localite = model.Localite;
        }

        public void HasError()
        {
            if (Nom == null)
            {
                IsValid = false;
            }
            if (Adresse == null)
            {
                IsValid = false;
            }
        }

        public void SetParameters()
        {
            switch (Groupe)
            {
                case 0:
                    Prenom = "F" + Id;

                    break;

                case 1:
                    Prenom = "G" + Id;

                    break;

                case 2:
                    Prenom = "D" + Id;

                    break;

                case 3:
                    Prenom = "S" + Id;

                    break;

                case 4:
                    Prenom = "E" + Id;

                    break;

                default:
                    Prenom = "P" + Id;
                    break;
            }

            if (Forme > 0)
            {
                Code = Prenom + "-F";
                return;
            }
            Code = Prenom + "-I";
        }
    }

    public class PersonModel
    {
        public PersonModel()
        {
            //
        }

        public PersonModel(PersonItem item)
        {
            Copy(item);
        }

        public PersonModel(CustomerItem item)
        {
            Copy(item);
        }

        public float Account { get; set; }
        public string Activite { get; set; }
        public string Adresse { get; set; }
        public string Code { get; set; }
        public string Complement { get; set; }
        public string Compte { get; set; }
        public float Credit { get; set; }
        public float Debit { get; set; }
        public string Description { get; set; }
        public bool DuplicateError { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public long Forme { get; set; }
        public bool Grossiste { get; set; }
        public long Groupe { get; set; }
        public long Id { get; set; }
        public bool IsFormel { get; set; }
        public bool IsValid { get; set; }
        public string LitteralType { get; set; }
        public string Localite { get; set; }
        public string Nif { get; set; }

        public string Nom { get; set; }

        public float Prime { get; set; }
        public string Rang { get; set; }

        public float Solde { get; set; }
        public string Stat { get; set; }

        public string Tel1 { get; set; }

        public string Tel2 { get; set; }

        public string Tel3 { get; set; }

        public string Ville { get; set; }

        public void Copy(PersonItem item)
        {
            if (item == null)
            {
                return;
            }
            if (item.Id <= 0)
            {
                return;
            }
            Id = item.Id;
            Localite = item.Localite;
            Nom = item.Nom;
            Activite = item.Activite;
            Adresse = item.Adresse;
            Complement = item.Complement;
            Code = item.Code;
            Ville = item.Ville;
            Tel1 = item.Tel1;
            Tel2 = item.Tel2;
            Tel3 = item.Tel3;
            Fax = item.Fax;
            Email = item.Email;
            Stat = item.Stat;
            Nif = item.Nif;
            Compte = item.Compte;
            Groupe = item.Groupe;
            Description = item.Description;
            Rang = item.Rang;
            Debit = item.Debit;
            Credit = item.Credit;
            Solde = item.Solde;
            Grossiste = item.Grossiste;
            LitteralType = item.LitteralType;
            if (item.Forme != null) Forme = (long)item.Forme;
            IsFormel = item.IsFormel;
        }

        public void Copy(CustomerItem item)
        {
            if (item == null)
            {
                return;
            }
            if (item.Id <= 0)
            {
                return;
            }
            Id = item.Id;
            Localite = item.Localite;
            Nom = item.Nom;
            Activite = item.Activite;
            Adresse = item.Adresse;
            Complement = item.Complement;
            Code = item.Code;
            Ville = item.Ville;
            Tel1 = item.Tel1;
            Tel2 = item.Tel2;
            Tel3 = item.Tel3;
            Fax = item.Fax;
            Email = item.Email;
            Stat = item.Stat;
            Nif = item.Nif;
            Compte = item.Compte;
            Groupe = item.Groupe;
            Description = item.Description;
            Grossiste = item.Grossiste;
            LitteralType = item.LitteralType;
            if (item.Forme != null) Forme = (long)item.Forme;
            IsFormel = item.IsFormel;
        }

        public void Copy(PersonModel model)
        {
            Id = model.Id;
            Nom = model.Nom;
            Activite = model.Activite;
            Adresse = model.Adresse;
            Complement = model.Complement;
            Ville = model.Ville;
            Tel1 = model.Tel1;
            Tel2 = model.Tel2;
            Tel3 = model.Tel3;
            Code = model.Code;
            Fax = model.Fax;
            Email = model.Email;
            Stat = model.Stat;
            Nif = model.Nif;
            Compte = model.Compte;
            Groupe = model.Groupe;
            Description = model.Description;
            Debit = model.Debit;
            Credit = model.Credit;
            Solde = model.Solde;
            Grossiste = model.Grossiste;
            LitteralType = model.LitteralType;
            Forme = model.Forme;
            IsFormel = model.IsFormel;
            Localite = model.Localite;
        }

        public void SetAccount()
        {
            Account = CashHelpers.GetValues().Where(value => Id == value.Pid).Sum(value => value.Montant);
        }
    }

    public class PersonRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(PersonItem item)
        {
            _context.PersonItems.InsertOnSubmit(item);
        }

        public int Count()
        {
            return _context.PersonItems.Count();
        }

        public bool Create(PersonModel model)
        {
            var person = new PersonItem();
            model.Id = Count() + 1;
            person.Copy(model);
            person.SetParameters();
            Add(person);
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

        public void Delete(PersonItem item)
        {
            _context.PersonItems.DeleteOnSubmit(item);
        }

        public PersonItem Get(long id)
        {
            return _context.PersonItems.SingleOrDefault(d => d.Id == id);
        }

        public IQueryable<PersonItem> Persons()
        {
            return _context.PersonItems;
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

        public bool Update(PersonModel model)
        {
            var item = Get(model.Id);
            item.Copy(model);
            item.SetParameters();
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

    public class VendorCart : IEnumerable<VendorItem>
    {
        public VendorCart()
        {
            Vendors = new List<VendorItem>();
            var repository = new VendorRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (VendorItem item in repository.Vendors())
            {
                item.Set();
                Vendors.Add(item);
            }
        }

        public List<VendorItem> Vendors { get; set; }

        public IEnumerator<VendorItem> GetEnumerator()
        {
            return Vendors.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class VendorItem
    {
        public string EstFormel { get; set; }

        public void Set()
        {
            if ((Forme == null) || (Forme == 0))
            {
                EstFormel = @"INFO";
                return;
            }
            EstFormel = @"FORM";
        }
    }

    public class VendorRepository
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(VendorItem item)
        {
            _context.VendorItems.InsertOnSubmit(item);
            Save();
        }

        public int Count()
        {
            return _context.VendorItems.Count();
        }

        public void Delete(VendorItem item)
        {
            _context.VendorItems.DeleteOnSubmit(item);
            Save();
        }

        public VendorItem Get(long id)
        {
            return _context.VendorItems.SingleOrDefault(d => d.Id == id);
        }

        public void Save()
        {
            _context.SubmitChanges();
        }

        public IQueryable<VendorItem> Vendors()
        {
            return _context.VendorItems;
        }
    }
}