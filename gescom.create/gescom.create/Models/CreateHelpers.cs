using DevExpress.XtraReports.UI;
using gescom.create.Views;
using gescom.data.Models;
using gescom.printer;
using gescom.report.Extensions;
using gescom.report.Reports;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.create.Models
{
    public static class CreateHelpers
    {
        public static void AboutInfo()
        {
            var f = new XtraPerson();
            f.ShowDialog();
        }

        public static void ActionCommande()
        {
            var f = new XtraOperation();
            f.Show();
        }

        public static void Init()
        {
           /* DataHelpers.SaveGeneral();
            DataHelpers.SaveLocal(); */
        }

        public static void RecapitulerCaisse()
        {
            PrintHelpers.PrintTiroir();
        }

        public static void AdminSearch()
        {
            var f = new XtraFind();
            f.nom.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            f.SetProtect();
            f.Show();
        }
        
        public static void Comparer()
        {
            var f = new XtraOrder();
            f.ShowDialog();
        }

        public static void CompleteInfoCustomer(CashModel model)
        {
            var form = new CustomerAdress(model);
            form.ShowDialog();
        }

       
        public static void ConsulteDetailCaisse(long id)
        {
            var f = new XtraDetail(id);
            f.NoPrint();
            f.ShowDialog();
        }

        public static void Deplacer(long id)
        {
            var f = new XtraDist(id);
            f.ShowDialog();
        }

        public static void Detailler(long id)
        {
            var f = new XtraJournal(id);
            f.ShowDialog();
        }

        public static void DetaillerArticle(long id)
        {
            var f = new XtraArticle(id);
            f.ShowDialog();
        }        

        public static void DetaillerCustomerCompte(long id, string text)
        {
            var f = new XtraCompte(id, text);
            if (f.Count == 0)
            {
                ErrorHelpers.SignalEmptyList();
                return;
            }
            f.ShowDialog();
        }

        public static void DetaillerGlobal(int index, int id)
        {
            var frmGlobal = new XtraGlobal(index, id);
            frmGlobal.ShowDialog();
        }

        public static void DetaillerOperation(long id)
        {
            var f = new XtraDetail(id);
            f.ShowDialog();
        }

        public static void DetaillerEntree(long id)
        {
            var f = new XtraMag(id);
            f.ShowDialog();
        }

        public static void DetaillerPerson(int index, int id)
        {
            var frmGlobal = new XtraPerson(index, id);
            frmGlobal.ShowDialog();
        }

        public static void DetaillerPrimeCompte(long id)
        {
            var f = new XtraPrime(id);
            f.ShowDialog();
        }

        public static void DetaillerVendorCompte(long id, long pid)
        {
            var f = new XtraCompte(id, pid);
            if (f.Count == 0)
            {
                ErrorHelpers.SignalEmptyList();
                return;
            }
            f.ShowDialog();
        }

        public static void DetailsPerPerson()
        {
            var f = new XtraDiary();
            f.ShowDialog();
        }
       
        
        public static void Ecrire(long id)
        {
            var form = new XtraComptable(id);
            form.ShowDialog();
        }

        public static void EffectuerAvoir(long id, PersonModel person)
        {
            if (person.Groupe != 2) return;
            var f = new XtraVente();
            f.SetPerson(person);
            f.Text = @"AVOIR: " + person.Nom;
            f.IsValid = true;
            f.SetPerson(person);
            f.Show();
        }

        public static void EffectuerEntree(long id)
        {
            PersonModel person = PersonHelpers.Get(id);
            var f = new XtraEntree(person) { Text = @"ENTREE: " + person.Nom };
            if (person.Groupe == 0)
            {
                f.IsValid = true;
            }
            f.Show();
        }

        public static void EffectuerEntree()
        {
            var f = new XtraEntree();
            f.SetEntre();
            f.Show();
        }

        public static void EffectuerSimulation(long id)
        {
            PersonModel person = PersonHelpers.Get(id);
            var f = new XtraVente(person, -9) { Text = @"DEMANDE PRIX: " + person.Nom };
            if (person.Groupe <= 0) return;
            f.IsValid = true;
            f.Show();
        }

        public static void EffectuerVente(long id, string receive, long wid)
        {
            var p = PersonHelpers.Get(id);
            string title = p.Nom + @" - " + receive;
            var f = new XtraVente(p, wid, id) { Text = @"VENTE: " + title };
            if (p.Groupe <= 0) return;
            f.IsValid = true;
            f.Show();
        }

        public static void Encaisser()
        {
            var f = new XtraPaiement();
            f.Show();
        }

        public static void ErreurComptage()
        {
            var f = new XtraVente(-3);
            f.Show();
        }

        public static void Fusion(long id)
        {
            var f = new XtraFusion(id);
            f.ShowDialog();
        }

        public static void Globalize(long id)
        {
            var f = new XtraRegBonus(id);
            f.ShowDialog();
        }

        public static void ImprimerCompte(bool showing, List<SoldeItem> liste, long pid, DateTime dateDebut,
            DateTime dateFin)
        {
            if (!showing)
            {
                var rep1 = new ReportCompte(liste, pid);
                rep1.ShowPreview();
                return;
            }
            var report = new ReportCompte(liste, pid, dateDebut, dateFin);
            report.ShowPreview();
        }

        public static void ImprimerDebiteurs(List<InvoiceModel> liste, DateModel date)
        {
            var report = new ReportCaisse(liste, date);
            report.ShowPreview();
        }

        public static void ImprimerDetails(long id)
        {
            DiaryItem diary = DiaryHelpers.Get(id);
            if (diary.Groupe == 2)
            {
                var f = new XtraPrint(id);
                f.ShowDialog();
                return;
            }
            if (diary.Groupe == 6)
            {
                DiaryItem item = DiaryHelpers.Get(id);
                if (item == null)
                {
                    return;
                }
                PrintHelpers.ImprimerCommande(id);
                return;
            }
            var report = new ReportDetail(id);
            report.ShowPreview();
        }

        public static void ImprimerFacture(long id)
        {
            BoxItem invoice = CashHelpers.GetBoxItem(id);
            double r = 0;
            if (invoice.Percu != null) r = (double)invoice.Percu;
            if (r <= 0)
            {
                ReportHelpers.ImprimerFactureBon(id);
            }
            if (r > 0)
            {
                ReportHelpers.ImprimerFactureRegle(id);
            }
        }

        public static void ImprimerFiche(long id)
        {
            var report = new ReportJournal(id);
            report.ShowPreview();
        }

        public static void ImprimerFiche(long id, DateModel date)
        {
            var report = new ReportJournal(id, date);
            report.ShowPreview();
        }

        public static void ImprimerGlobal(int index)
        {
            var report = new ReportGlobal(index);
            report.ShowPreview();
        }

        public static void ImprimerPerson(int index)
        {
            var report = new ReportPerson(index);
            report.ShowPreview();
        }

        public static void ImprimerRegroup(List<OperationItem> liste, string title, string name)
        {
            var report = new ReportStock(liste);
            if (liste.Count == 0)
            {
                ErrorHelpers.SignalEmptyList();
                return;
            }
            report.SetTitle(title, name);
            report.ShowPreview();
        }

        public static void ImprimerResume(List<DayItem> liste, DateModel date)
        {
            var report = new ReportDiary(liste, date);
            report.ShowPreview();
        }

        public static void ImprimerStock(List<OperationItem> liste, string title)
        {
            var report = new ReportStock(liste, title);
            if (liste.Count == 0)
            {
                ErrorHelpers.SignalEmptyList();
                return;
            }
            report.ShowPreview();
        }

        public static void InitSetup()
        {
            RetailHelpers.CleanPrtTemp();
        }

        public static void InventCompt()
        {
            var f = new XtraComment();
            f.Show();
        }

        public static bool IsConnected()
        {
            return DataHelpers.GetConnection();
        }

        public static void ListerCash()
        {
            var f = new XtraCaisse();
            f.ShowDialog();
        }

        public static void ListerCustomers()
        {
            var f = new ListPerson(2);
            f.ShowDialog();
        }

        public static void ListerDeclarations()
        {
            var f = new XtraDeclaration();
            f.ShowDialog();
        }

        public static void ListerFamilles()
        {
            var f = new ListGlobal(0);
            f.ShowDialog();
        }

        public static void ListerPlaces()
        {
            var f = new ListGlobal(2);
            f.Show();
        }

        public static void ListerUnites()
        {
            var f = new ListGlobal(1);
            f.ShowDialog();
        }

        public static void ListerVendors()
        {
            var f = new ListPerson(1);
            f.ShowDialog();
        }

        public static void ListerWorkers()
        {
            var f = new ListPerson(3);
            f.ShowDialog();
        }

        public static void ModifyOnVendor(long id)
        {
            var f = new XtraProd(id);
            f.ShowDialog();
        }

        public static void NewArticle()
        {
            var f = new XtraArticle();
            f.ShowDialog();
        }

        public static void NewPerson(int index)
        {
            var f = new XtraPerson(index, -1);
            f.ShowDialog();
        }

        public static void ParticularSearch()
        {
            var f = new XtraFind();
            f.SetParticular();
            f.Show();
        }

        public static void RealiserAvoir()
        {
            var f = new XtraChoix(1, "CLIENT");
            f.Show();
        }

        public static void RealiserSimulation()
        {
            var f = new XtraChoix(-9, "DEMANDE DE PRIX");
            f.Show();
        }

        public static void RealiserVente()
        {
            var f = new XtraChoix(2, "FACTURE");
            f.Show();
        }

        public static void RebutDefection()
        {
            var f = new XtraVente(-4);
            f.Show();
        }

        public static void RebutVol()
        {
            var f = new XtraVente(-5);
            f.Show();
        }

        public static void ReglerBonus(long id)
        {
            var f = new XtraRegBonus(id);
            f.ShowDialog();
        }

        public static void RegroupArticle(int index, long id)
        {
            List<OperationItem> list;
            string name;
            string title;
            switch (index)
            {
                case 0:
                    list = OperationHelpers.GetByFamily(id).ToList();
                    title = @"REGROUPEMENT CATEGORIE";
                    name = FamilleHelpers.GetName(id);
                    break;

                case 1:
                    list = OperationHelpers.GetByUnit(id).ToList();
                    title = @"REGROUPEMENT UNITE";
                    name = UniteHelpers.GetName(id);
                    break;

                default:
                    list = OperationHelpers.GetByPlace(id).ToList();
                    title = @"REGROUPEMENT EMPLACEMENT";
                    name = PlaceHelpers.GetName(id);
                    break;
            }
            if (list.Count == 0)
            {
                ErrorHelpers.SignalEmptyList();
                return;
            }
            var f = new XtraGroup(list);
            f.SetTitle(title, name);
            f.ShowDialog();
        }

        public static void Remarquer(long id, bool noPLace)
        {
            var f = new XtraDist(id, true, false);
            f.ShowDialog();
        }

        public static void Resumer()
        {
            var f = new ListResume();
            f.ShowDialog();
        }

        public static void ShowFormalite()
        {
            var f = new XtraDispatch();
            f.ShowDialog();
        }

        public static void ShowFormels()
        {
            List<FormelModel> liste = FormelHelpers.GetOutFormels().ToList();
            if (liste.Count == 0)
            {
                return;
            }
            var f = new XtraDispatch(liste);
            f.ShowDialog();
        }

        public static void ViewStock()
        {
            var f = new ListState();
            f.Show();
        }
    }
}