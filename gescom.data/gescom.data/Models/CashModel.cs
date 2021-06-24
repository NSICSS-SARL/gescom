using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gescom.data.Models
{
    public static class CashHelpers
    {
        public static void Cancel(long id)
        {
            var rept = new BoxRepository();
            rept.Cancel(id);
            var invRepository = new InvoiceRepository();
            invRepository.Cancel(id);
            DateHelpers.UpdateCancel(id);
        }

        public static List<CasherIn> UnPaid()
        {
            var context = new DataGescomDataContext();
            return context.CasherIns.ToList();
        }

        public static List<InvoiceModern> GetPaiementState()
        {
            var context = new DataGescomDataContext();
            return context.InvoiceModerns.ToList();
        }

        public static long Create(CashModel model)
        {
            var invRepository = new InvoiceRepository();
            invRepository.Create(model);
            if ((model.Groupe != 2) && (model.Groupe != 0)) return model.Id;
            var boxReptory = new BoxRepository();
            boxReptory.Create(model);
            return model.Id;
        }

        public static long CreateNoBox(CashModel model)
        {
            var invRepository = new InvoiceRepository();
            invRepository.Create(model);
            return model.Id;
        }

        public static IEnumerable<InvoiceModel> FilterByDate(IEnumerable<InvoiceModel> liste, DateTime debut,
            DateTime fin)
        {
            debut = debut.AddDays(-1);
            return liste.Where(text => (text.Datum <= fin) && (text.Datum >= debut));
        }

        public static InvoiceItem Get(long id)
        {
            var invRepository = new InvoiceRepository();
            return invRepository.Get(id);
        }

        public static string GetAmountText(IEnumerable<InvoiceModel> liste)
        {
            return StdCalcul.DoubleToSpaceFormat(GetAmountTotal(liste));
        }

        public static float GetAmountTotal(IEnumerable<InvoiceModel> liste)
        {
            return liste.Sum(invoiceModel => invoiceModel.Montant - invoiceModel.Percu + invoiceModel.Rendu);
        }

        public static List<InvoiceModel> GetBills()
        {
            var result = new List<InvoiceModel>();
            foreach (InvoiceItem item in GetItems())
            {
                var model = new InvoiceModel();
                if (item.Groupe == 2) continue;
                var p = (float)item.Percu;
                if (p <= 0)
                {
                    item.InfoFin = null;
                }
                model.Copy(item);
                model.Montant2 = StdCalcul.DoubleToSpaceFormat(model.Montant);
                model.DetailModel = RetailHelpers.GetModel(item.Id);
                model.Set();
                result.Add(model);
            }
            return result;
        }

        public static List<InvoiceModel> GetBills(long id)
        {
            return GetInvoicesPid(GetBills(), id).ToList();
        }

        public static BoxItem GetBoxItem(long id)
        {
            var reptory = new BoxRepository();
            return reptory.Get(id);
        }

        public static List<BoxItem> GetBoxItems()
        {
            var boxes = new List<BoxItem>();
            foreach (var item in MyBoxInit())
            {
                item.SetTime();
                if (item.Montant == null) continue;
                if (item.Rendu == null)
                {
                    item.Rendu = 0;
                }
                if (item.Percu == null)
                {
                    item.Percu = 0;
                }
                item.Debit = (float)item.Montant;
                item.Solde = item.Debit;
                var credit = (float)item.Percu;
                item.Credit = credit;
                item.Solde = item.Debit - credit;
                item.Id2 = StdCalcul.DoubleToSpaceFormat(item.Id);
                var m = (float)item.Montant;
                item.Montant2 = StdCalcul.DoubleToSpaceFormat(m);
                boxes.Add(item);
            }
            return boxes;
        }

        public static IEnumerable<BoxItem> GetBoxUnpaid()
        {
            foreach (var item in GetBoxItems())
            {
                float x = 0;
                if (item.Percu != null) x = (float)item.Percu;
                if (x > 0)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<InvoiceText> GetDatedTexts(IEnumerable<InvoiceText> liste, DateTime debut,
            DateTime fin)
        {
            return liste.Where(text => (text.Datum <= fin) && (text.Datum >= debut));
        }

        public static List<InvoiceModel> GetInvoices()
        {
            var result = new List<InvoiceModel>();
            foreach (InvoiceItem item in GetItems())
            {
                var model = new InvoiceModel();
                if (item.Groupe != 2) continue;
                var p = (float)item.Percu;
                if (p <= 0)
                {
                    item.InfoFin = null;
                }
                model.Copy(item);
                model.Montant2 = StdCalcul.DoubleToSpaceFormat(model.Montant);
                model.Set();
                result.Add(model);
            }
            return result;
        }

        public static List<InvoiceModel> GetInvoices(long id)
        {
            return GetInvoicesPid(GetInvoices(), id).ToList();
        }

        public static IEnumerable<InvoiceModel> GetInvoicesPid(List<InvoiceModel> invoices, long pid)
        {
            return invoices.Where(invoice => invoice.Pid == pid);
        }

        public static IEnumerable<InvoiceText> GetInvoiceTexts(List<InvoiceModel> invoices)
        {
            var result = new List<InvoiceText>();
            foreach (InvoiceModel invoice in invoices)
            {
                var text = new InvoiceText();
                text.Copy(invoice);
                result.Add(text);
            }
            return result;
        }

        public static IEnumerable<InvoiceText> GetInvoiceTexts()
        {
            var result = new List<InvoiceText>();
            foreach (InvoiceModel model in GetUnpaid())
            {
                var item = new InvoiceText();
                item.Copy(model);
                result.Add(item);
            }
            return result;
        }

        public static IEnumerable<InvoiceItem> GetItems()
        {
            var result = new List<InvoiceItem>();
            foreach (BoxItem item in GetBoxItems())
            {
                var invoice = new InvoiceItem();
                invoice.Copy(item);
                result.Add(invoice);
            }
            return result;
        }

        public static CashModel GetModel(long id)
        {
            var repository = new InvoiceRepository();
            InvoiceItem item = repository.Get(id);
            var model = new CashModel();
            model.Copy(item);
            return model;
        }

        public static IEnumerable<InvoiceModel> GetPaid()
        {
            return GetInvoices().Where(model => model.Rendu > 0);
        }

        public static IEnumerable<InvoiceText> GetPayedTexts()
        {
            var result = new List<InvoiceText>();
            foreach (InvoiceModel model in GetPaid())
            {
                var item = new InvoiceText();
                item.Copy(model);
                result.Add(item);
            }
            return result;
        }

        public static IEnumerable<InvoiceText> GetTexts()
        {
            var result = new List<InvoiceText>();
            foreach (InvoiceModel model in GetInvoices())
            {
                var text = new InvoiceText();
                text.Copy(model);
                result.Add(text);
            }
            return result;
        }

        public static IEnumerable<InvoiceModel> GetUnpaid()
        {
            return GetInvoices().Where(model => model.Rendu <= 0);
        }

        public static List<BoxItem> GetUnpaidBox()
        {
            return GetBoxItems().Where(boxItem => (boxItem.Groupe == 2) && boxItem.Percu == 0).ToList();
        }

        public static float GetValue(long id)
        {
            float result = 0;
            foreach (CashModel value in GetValues())
            {
                if (value.Id == id)
                {
                    result = value.Montant;
                }
            }
            return result;
        }

        public static List<CashModel> GetValues()
        {
            var result = new List<CashModel>();
            foreach (BoxItem item in GetBoxItems())
            {
                var model = new CashModel();
                model.Copy(item);
                result.Add(model);
            }
            return result;
        }

        public static IEnumerable<BoxItem> MyBoxInit()
        {
            var diary = DiaryHelpers.GetReceiptForPrint();
            var repo = new BoxRepository();
            return diary.Select(item => repo.Get(item.Id)).Where(element => element != null).ToList();
        }

        public static IEnumerable<BoxItem> MyBoxCart()
        {
            var context = new DataGescomDataContext();
            var boxes = new List<BoxItem>();
            foreach (var item in context.BoxItems)
            {
                item.SetTime();
                if (item.Montant == null) continue;
                if (item.Rendu == null)
                {
                    item.Rendu = 0;
                }
                if (item.Percu == null)
                {
                    item.Percu = 0;
                }
                item.Debit = (float)item.Montant;
                item.Solde = item.Debit;
                var credit = (float)item.Percu;
                item.Credit = credit;
                item.Solde = item.Debit - credit;
                item.Id2 = StdCalcul.DoubleToSpaceFormat(item.Id);
                var m = (float)item.Montant;
                item.Montant2 = StdCalcul.DoubleToSpaceFormat(m);
                boxes.Add(item);
            }
            return boxes;
        }

        public static void Update(long id, float percu)
        {
            var reptory = new BoxRepository();
            var box = reptory.Get(id);
            if (box == null)
            {
                return;
            }
            if (box.Percu > 0)
            {
                return;
            }
            if (!(percu >= box.Montant)) return;
            if (box.Montant == null)
            {
                return;
            }
            var montant = (float)box.Montant;
            var rendu = percu - montant;
            Update(id, percu, rendu);
        }

        public static void Update(long id, float percu, float rendu)
        {
            var model = new CashModel(id, percu, rendu);
            var repository = new InvoiceRepository();
            repository.Update(model);
            var diary = new DiaryModel();
            var box = new BoxItem
            {
                O2 = diary.Nom,
                T2 = diary.Hote,
                D2 = diary.Datum,
                Id = id,
                Percu = percu,
                Rendu = rendu
            };
            var boxRept = new BoxRepository();
            boxRept.Update(box);
        }

        public static void Update(InvoiceText invoice)
        {
            if (string.IsNullOrEmpty(invoice?.Id))
            {
                return;
            }
            if (string.IsNullOrEmpty(invoice.Percu))
            {
                return;
            }
            if (string.IsNullOrEmpty(invoice.Rendu))
            {
                return;
            }
            long id = long.Parse(invoice.Id);
            if (id <= 0)
            {
                return;
            }
            float percu = float.Parse(invoice.Percu);
            if (percu <= 0)
            {
                return;
            }
            float rendu = float.Parse(invoice.Rendu);
            Update(id, percu, rendu);
        }

        public static void Update(CashModel model)
        {
            var invRepository = new InvoiceRepository();
            invRepository.Update(model);
        }

        public static void UpdateAmountInvoice(long id, float montant)
        {
            var invReptory = new InvoiceRepository();
            var item = invReptory.Get(id);
            item.Montant = montant;
            invReptory.Save();
        }

        public static void UpdateInfo(long id, string nom, string adresse)
        {
            var reptory = new InvoiceRepository();
            reptory.Update(id, nom, adresse);
        }

        public static bool UpdatePay(long id, float percu)
        {
            var reptory = new BoxRepository();
            var box = reptory.Get(id);
            if (box == null)
            {
                return false;
            }
            Update(id, percu);
            return true;
        }
    }

    public partial class BoxItem
    {
        public float Credit { get; set; }

        public float Debit { get; set; }

        public long Forme { get; set; }

        public string Hote { get; set; }

        public string Id2 { get; set; }

        public string InfoDebut { get; set; }

        public string InfoFin { get; set; }

        public string Montant2 { get; set; }

        public string Operateur { get; set; }

        public long Pid { get; set; }

        public float Solde { get; set; }

        public string Tache { get; set; }

        public void Copy(CashModel model)
        {
            Id = model.Id;
            Montant = model.Montant;
            Nom = model.Nom;
            Adresse = model.Adresse;
            Pid = model.Pid;
            O1 = model.Operateur;
            T1 = model.Hote;
            D1 = model.Datum;
            Groupe = model.Groupe;
            Forme = model.Forme;
        }

        public void Copy(BoxItem item)
        {
            O2 = item.O2;
            T2 = item.T2;
            D2 = item.D2;
            Percu = item.Percu;
            Rendu = item.Rendu;
            Forme = item.Forme;
        }

        public void SetTime()
        {
            DiaryModel diary = DiaryHelpers.GetReference(Id);
            D1 = diary.Datum;
            Pid = diary.Pid;
            Operateur = diary.Nom;
            Hote = diary.Hote;
            Tache = diary.Tache;
            var d1 = (DateTime)D1;
            InfoDebut = StdCalcul.SetInfo(d1, Hote, Operateur);
            if (Percu == null)
            {
                return;
            }
            var d2 = new DateTime();
            if (D2 != null) d2 = (DateTime)D2;
            InfoFin = StdCalcul.SetInfo(d2, Hote, Operateur);
        }
    }

    public class BoxRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(BoxItem item)
        {
            _context.BoxItems.InsertOnSubmit(item);
        }

       
        public void Cancel(long id)
        {
            BoxItem item = Get(id);
            item.Groupe = -1;
            _context.SubmitChanges();
        }

        public int Count()
        {
            return _context.BoxItems.Count();
        }

        public void Create(CashModel model)
        {
            var item = new BoxItem();
            item.Copy(model);
            if (model.Groupe == 0)
            {
                item.D2 = model.Datum;
                item.Percu = 0;
                item.Rendu = 0;
            }
            Add(item);
            _context.SubmitChanges();
        }

        public void Delete(BoxItem item)
        {
            _context.BoxItems.DeleteOnSubmit(item);
        }

        public BoxItem Get(long id)
        {
            return _context.BoxItems.SingleOrDefault(d => d.Id == id);
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

        public void Update(BoxItem item)
        {
            BoxItem element = Get(item.Id);
            element.Copy(item);
            if (item.Percu >= item.Rendu)
            {
                _context.SubmitChanges();
                DateHelpers.UpdateGroupe(item.Id);
            }
        }
    }

    public class CashModel
    {
        /** numéro de table.*/

        public CashModel()
        {
            /***/
        }

        public CashModel(DiaryModel diary)
        {
            Id = diary.Id;
            Pid = diary.Pid;
            Groupe = diary.Groupe;
            Operateur = diary.Nom;
            Hote = diary.Hote;
            Datum = diary.Datum;
            Forme = diary.Forme;
        }

        public CashModel(DiaryModel diary, PersonItem item)
        {
            Id = diary.Id;
            Pid = diary.Pid;
            Groupe = diary.Groupe;
            Operateur = diary.Nom;
            Hote = diary.Hote;
            Datum = diary.Datum;
            Nom = item.Nom;
            Adresse = item.Adresse;
            if (item.Forme != null) Forme = (long)item.Forme;
        }

        public CashModel(DiaryModel diary, long pid, float total)
        {
            Id = diary.Id;
            Pid = diary.Pid;
            Groupe = diary.Groupe;
            Operateur = diary.Nom;
            Hote = diary.Hote;
            Datum = diary.Datum;
            if (pid > 0)
            {
                var p = PersonHelpers.Get(pid);
                Nom = p.Nom;
                Adresse = p.Adresse;
                Forme = p.Forme;
            }
            Montant = total;
        }

        public CashModel(DiaryModel diary, PersonItem item, float total)
        {
            Id = diary.Id;
            Pid = diary.Pid;
            Groupe = diary.Groupe;
            Operateur = diary.Nom;
            Hote = diary.Hote;
            Datum = diary.Datum;
            Nom = item.Nom;
            Adresse = item.Adresse;
            Montant = total;
            if (item.Forme != null) Forme = (long)item.Forme;
        }

        public CashModel(DiaryModel diary, float total)
        {
            Id = diary.Id;
            Pid = diary.Pid;
            Groupe = diary.Groupe;
            Operateur = diary.Nom;
            Hote = diary.Hote;
            Datum = diary.Datum;
            Montant = total;
            Forme = diary.Forme;
        }

        public CashModel(long id, float percu, float rendu)
        {
            Id = id;
            Percu = percu;
            Rendu = rendu;
        }

        public string Adresse { get; set; }

        public float Credit { get; set; }

        public string Credit2 { get; set; }

        public DateTime Datum { get; set; }

        public float Debit { get; set; }

        public string Debit2 { get; set; }

        public long Forme { get; set; }

        public long Groupe { get; set; }

        public string Hote { get; set; }

        public long Id { get; set; }

        public string InfoDebut { get; set; }

        public string InfoFin { get; set; }

        public float Montant { get; set; }

        public string Montant2 { get; set; }

        public string Nom { get; set; }

        public string Operateur { get; set; }

        public float Percu { get; set; }

        public string Percu2 { get; set; }

        public long Pid { get; set; }

        public float Rendu { get; set; }

        public string Rendu2 { get; set; }

        public float Solde { get; set; }

        public string Tache { get; set; }

        public void Copy(BoxItem item)
        {
            Id = item.Id;
            if (item.Montant != null) Montant = (float)item.Montant;
            if (item.Rendu != null) Rendu = (float)item.Rendu;
            if (item.Percu != null) Percu = (float)item.Percu;
            if (item.D1 != null) Datum = (DateTime)item.D1;
            Nom = item.Nom;
            Adresse = item.Adresse;
            if (item.Montant != null) Montant = (float)item.Montant;
            Debit = item.Debit;
            Credit = item.Credit;
            Solde = item.Solde;
            Pid = item.Pid;
            Operateur = item.Operateur;
            Hote = item.Hote;
            Debit2 = StdCalcul.DoubleToSpaceFormat(Debit);
            Credit2 = StdCalcul.DoubleToSpaceFormat(Credit);
            InfoDebut = item.InfoDebut;
            InfoFin = item.InfoFin;
            Forme = item.Forme;
        }

        public void Copy(InvoiceItem item)
        {
            if (item == null)
            {
                return;
            }
            if (item.Id == 0)
            {
                return;
            }
            Id = item.Id;
            Montant = (float)item.Montant;
            Rendu = (float)item.Rendu;
            Percu = (float)item.Percu;
            if (item.Datum != null) Datum = (DateTime)item.Datum;
            Nom = item.Nom;
            Adresse = item.Adresse;
            Debit = item.Debit;
            Credit = item.Credit;
            Solde = item.Solde;
            Pid = item.Pid;
            Operateur = item.Operateur;
            Hote = item.Hote;
            Montant2 = StdCalcul.DoubleToSpaceFormat(Montant);
            Percu2 = StdCalcul.DoubleToSpaceFormat(Percu);
            Rendu2 = StdCalcul.DoubleToSpaceFormat(Rendu);
            Debit2 = StdCalcul.DoubleToSpaceFormat(Debit);
            Credit2 = StdCalcul.DoubleToSpaceFormat(Credit);
            InfoDebut = item.InfoDebut;
            InfoFin = item.InfoFin;
            Forme = item.Forme;
        }
    }

    public class InvoiceCart : IEnumerable<InvoiceItem>
    {
        public InvoiceCart()
        {
            Invoices = new List<InvoiceItem>();
            var repository = new InvoiceRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (InvoiceItem item in repository.Invoices())
            {
                SetTime(item);
                item.Debit = (float)item.Montant;
                item.Solde = item.Debit;
                if (item.Rendu > 0)
                {
                    var credit = (float)item.Montant;
                    item.Credit = credit;
                    item.Solde = item.Debit - credit;
                }
                if ((item.Nom != null) && (item.Montant > 0))
                {
                    Invoices.Add(item);
                }
            }
        }

        public List<InvoiceItem> Invoices { get; set; }

        public IEnumerator<InvoiceItem> GetEnumerator()
        {
            return Invoices.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void SetTime(InvoiceItem item)
        {
            DiaryModel diary = DiaryHelpers.GetReference(item.Id);
            item.Datum = diary.Datum;
            item.Pid = diary.Pid;
            item.Operateur = diary.Nom;
            item.T1 = diary.Tache;
            item.Hote = diary.Hote;
            item.Tache = diary.Tache;
        }
    }

    public partial class InvoiceItem
    {
        public float Credit { get; set; }

        public DateTime D1 { get; set; }

        public DateTime D2 { get; set; }

        public float Debit { get; set; }

        public long Forme { get; set; }

        public long Groupe { get; set; }

        public string Hote { get; set; }

        public string InfoDebut { get; set; }

        public string InfoFin { get; set; }

        public string O1 { get; set; }

        public string O2 { get; set; }

        public string Operateur { get; set; }

        public long Pid { get; set; }

        public float Solde { get; set; }

        public string T1 { get; set; }

        public string T2 { get; set; }

        public string Tache { get; set; }

        public void Copy(CashModel model)
        {
            Id = model.Id;
            Montant = model.Montant;
            Rendu = model.Rendu;
            Percu = model.Percu;
            Nom = model.Nom;
            Adresse = model.Adresse;
            Pid = model.Pid;
            Datum = model.Datum;
            Operateur = model.Operateur;
            Hote = model.Hote;
            InfoDebut = model.InfoDebut;
            InfoFin = model.InfoFin;
            Tache = model.Tache;
            // Forme = model.Forme;
        }

        public void Copy(InvoiceModel model)
        {
            Id = model.Id;
            Montant = model.Montant;
            Rendu = model.Rendu;
            Percu = model.Percu;
            Nom = model.Nom;
            Adresse = model.Adresse;
            Pid = model.Pid;
            Datum = model.Datum;
            Operateur = model.Operateur;
            Hote = model.Hote;
            InfoDebut = model.InfoDebut;
            InfoFin = model.InfoFin;
            Tache = model.Tache;
        }

        public void Copy(BoxItem item)
        {
            Id = item.Id;
            if (item.Montant != null) Montant = (double)item.Montant;
            if (item.Rendu != null) Rendu = (double)item.Rendu;
            if (item.Percu != null) Percu = (double)item.Percu;
            Nom = item.Nom;
            Datum = item.D1;
            Adresse = item.Adresse;
            Pid = item.Pid;
            Operateur = item.Operateur;
            Hote = item.Hote;
            if (item.D1 != null) D1 = (DateTime)item.D1;
            if (item.D2 != null) D2 = (DateTime)item.D2;
            O1 = item.O1;
            O2 = item.O2;
            T1 = item.T1;
            T2 = item.T2;
            InfoDebut = item.InfoDebut;
            if (item.Groupe != null) Groupe = (long)item.Groupe;
            InfoFin = item.InfoFin;
            Credit = item.Credit;
            Debit = item.Debit;
            Tache = item.Tache;
        }
    }

    public class InvoiceModel
    {
        public string Adresse { get; set; }

        public float Credit { get; set; }

        public string Credit2 { get; set; }

        public DateTime Datum { get; set; }

        public float Debit { get; set; }

        public string Debit2 { get; set; }

        public RetailModel DetailModel { get; set; }

        public long Forme { get; set; }

        public long Groupe { get; set; }

        public string Hote { get; set; }

        public long Id { get; set; }

        public string Info { get; set; }

        public string InfoDebut { get; set; }

        public string InfoFin { get; set; }

        public float Montant { get; set; }

        public string Montant2 { get; set; }

        public string Nom { get; set; }

        public string Operateur { get; set; }

        public float Percu { get; set; }

        public string Percu2 { get; set; }

        public long Pid { get; set; }

        public float Rendu { get; set; }

        public string Rendu2 { get; set; }

        public float Solde { get; set; }

        public string Tache { get; set; }

        public void Copy(InvoiceItem item)
        {
            Id = item.Id;
            Montant = (float)item.Montant;
            Rendu = (float)item.Rendu;
            Percu = (float)item.Percu;
            Nom = item.Nom;
            Adresse = item.Adresse;
            Debit = item.Debit;
            Credit = item.Credit;
            Solde = item.Solde;
            if (item.Datum != null) Datum = (DateTime)item.Datum;
            Pid = item.Pid;
            Operateur = item.Operateur;
            Hote = item.Hote;
            InfoDebut = item.InfoDebut;
            Groupe = item.Groupe;
            InfoFin = item.InfoFin;
            Tache = item.Tache;
            //Forme = item.Forme;
        }

        public void Copy(CashModel model)
        {
            Id = model.Id;
            Montant = model.Montant;
            Rendu = model.Rendu;
            Percu = model.Percu;
            Nom = model.Nom;
            Adresse = model.Adresse;
            Debit = model.Debit;
            Credit = model.Credit;
            Solde = model.Solde;
            Pid = model.Pid;
            Datum = model.Datum;
            Operateur = model.Operateur;
            Hote = model.Hote;
            Tache = model.Tache;
            // Forme = model.Forme;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Id=" + Id.ToString() + " Date=" + Datum.ToOADate());
            return sb.ToString();
        }

        public void Set()
        {
            Rendu2 = StdCalcul.DoubleToSpaceFormat(Rendu);
            Percu2 = StdCalcul.DoubleToSpaceFormat(Percu);
        }
    }

    public class InvoiceRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(InvoiceItem item)
        {
            _context.InvoiceItems.InsertOnSubmit(item);
        }

        public void Cancel(long id)
        {
            var item = Get(id);
            if (item == null)
            {
                return;
            }
            Delete(item);
        }

        public int Count()
        {
            return _context.InvoiceItems.Count();
        }

        public void Create(CashModel model)
        {
            var item = new InvoiceItem();
            item.Copy(model);
            item.Datum = DateTime.Now;
            Add(item);
            _context.SubmitChanges();
        }

        public void Delete(InvoiceItem item)
        {
            _context.InvoiceItems.DeleteOnSubmit(item);
            Save();
        }

        public InvoiceItem Get(long id)
        {
            return _context.InvoiceItems.SingleOrDefault(d => d.Id == id);
        }

        public IQueryable<InvoiceItem> Invoices()
        {
            return _context.InvoiceItems;
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

        public void Update(long id, string nom, string adresse)
        {
            InvoiceItem item = Get(id);
            item.Nom = nom;
            item.Adresse = adresse;
            Save();
        }

        public CashModel Update(CashModel model)
        {
            InvoiceItem item = Get(model.Id);
            item.Percu = model.Percu;
            item.Rendu = model.Rendu;
            item.Datum = DateTime.Now;
            if (item.Percu >= item.Rendu)
            {
                _context.SubmitChanges();
                model.Copy(item);
                return model;
            }
            return null;
        }
    }

    public class InvoiceText
    {
        public InvoiceText()
        {
            DetailText = new RetailText();
        }

        public string Adresse { get; set; }

        public string Auteur { get; set; }

        public string Credit { get; set; }

        public DateTime Datum { get; set; }

        public string Debit { get; set; }

        public RetailText DetailText { get; set; }

        public string Hote { get; set; }

        public string Id { get; set; }

        public long Id2 { get; set; }

        public string Info { get; set; }

        public string InfoDebut { get; set; }

        public string InfoFin { get; set; }

        public string Montant { get; set; }

        public float Montant2 { get; set; }

        public string Nom { get; set; }

        public string Operateur { get; set; }

        public string Percu { get; set; }

        public string Pid { get; set; }

        public string Rendu { get; set; }

        public string Solde { get; set; }

        public string Tache { get; set; }

        public void Copy(InvoiceText item)
        {
            Adresse = item.Adresse;
            Id = item.Id;
            Montant = item.Montant;
            Nom = item.Nom;
            Info = item.Info;
            Percu = item.Percu;
            Rendu = item.Rendu;
            Auteur = item.Auteur;
            DetailText = item.DetailText;
            Id2 = item.Id2;
            Montant2 = item.Montant2;
            Debit = item.Debit;
            Credit = item.Credit;
            Solde = item.Solde;
            Pid = item.Pid;
            Datum = item.Datum;
            Operateur = item.Operateur;
            Hote = item.Hote;
            InfoDebut = item.InfoDebut;
            InfoFin = item.InfoFin;
            Tache = item.Tache;
        }

        public void Copy(InvoiceModel model)
        {
            Id = StdCalcul.DoubleToSpaceFormat(model.Id);
            Montant = StdCalcul.DoubleToSpaceFormat(model.Montant);
            Rendu = StdCalcul.DoubleToSpaceFormat(model.Rendu);
            Percu = StdCalcul.DoubleToSpaceFormat(model.Percu);
            Id2 = model.Id;
            Montant2 = model.Montant;
            Nom = model.Nom;
            Adresse = model.Adresse;
            DetailText.Copy(model.DetailModel);
            Info = DetailText.Info;
            Debit = StdCalcul.DoubleToSpaceFormat(model.Debit);
            Credit = StdCalcul.DoubleToSpaceFormat(model.Credit);
            Solde = StdCalcul.DoubleToSpaceFormat(model.Solde);
            Pid = StdCalcul.DoubleToSpaceFormat(model.Pid);
            Datum = model.Datum;
            Operateur = model.Operateur;
            Hote = model.Hote;
            InfoDebut = model.InfoDebut;
            InfoFin = model.InfoFin;
            Tache = model.Tache;
        }

        public void CopyOnly(InvoiceModel model)
        {
            Id = StdCalcul.DoubleToSpaceFormat(model.Id);
            Montant = StdCalcul.DoubleToSpaceFormat(model.Montant);
            Rendu = StdCalcul.DoubleToSpaceFormat(model.Rendu);
            Percu = StdCalcul.DoubleToSpaceFormat(model.Percu);
            Id2 = model.Id;
            Montant2 = model.Montant;
            Nom = model.Nom;
            Adresse = model.Adresse;
            Debit = StdCalcul.DoubleToSpaceFormat(model.Debit);
            Credit = StdCalcul.DoubleToSpaceFormat(model.Credit);
            Solde = StdCalcul.DoubleToSpaceFormat(model.Solde);
            Pid = StdCalcul.DoubleToSpaceFormat(model.Pid);
            Datum = model.Datum;
            Operateur = model.Operateur;
            Hote = model.Hote;
            InfoDebut = model.InfoDebut;
            InfoFin = model.InfoFin;
            Tache = model.Tache;
        }
    }
}