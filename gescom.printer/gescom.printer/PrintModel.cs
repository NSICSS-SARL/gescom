using DevExpress.XtraReports.UI;
using gescom.data.Models;
using gescom.printer.Drafts;
using gescom.printer.Reports;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.printer
{
    public static class PrintHelpers
    {
        public static void PrintDocument(this XtraReport report, string printerAdress)
        {
            ReportPrintTool printTool = new ReportPrintTool(report);
            // Invoke the Print dialog.
            //printTool.PrintDialog();
            // Send the report to the default printer.
            //printTool.Print();
            // Send the report to the specified printer.
            printTool.Print(printerAdress);
        }

        public static void PrintNewTicket(OperationElem item)
        {
            DiaryHelpers.UpdateInitialPrint(item.Id);
            DateHelpers.UpdateBon(item.Id);
            //var model = new PrintModel(item) { Ticket = { PrinterName = "\\\\WIN - HOST.photo104.mg\\XP - 80C" } };
           var rpt = new TicketDirect(item)
              {
                  somme = {Text = item.Montant2},
                  count = {Text = item.Count}
              };
              var ptr = new Ticket(item) {count = {Text = item.Count}};
           
            rpt.PrintDocument("\\\\WIN-HOST.photo104.mg\\XP-80C");
            ptr.PrintDocument("\\\\THINK.photo104.mg\\80 Printer(1)");
        }

        public static void PrintTiroir()
        {
            var t = new TiroirModel();
            var rpt = new Recu(t);
            //rpt.Print("Xprinter XP-360B (Copy 3)");
        }

        public static void PrintBon(long id)
        {
            var report = new XtraBonCommande(id);
            report.Print();
            ReparationHelpers.ClearBonTable(id);
            DiaryHelpers.UpdateInitialPrint(id);
            DateHelpers.UpdateBon(id);
        }

        public static void PrintReceipt(CasherIn c)
        {
            ApiModel.SetCasherList(c);
            var model = new PrintModel(c);
            model.ImprimerRecu();
            CashHelpers.UpdatePay(c.Id, c.Obtenu);
            ReparationHelpers.AddFastPrint(c.Id);
            ReparationHelpers.ClearCashTable(c.Id);
        }

        public static void ImprimerCommande(long id)
        {
            var report = new XtraCommandes(id);
            report.ShowPreview();
        }

        public static void ImprimerPrime(List<PersonnelItem> liste, DateTime debut, DateTime fin)
        {
            var report = new ReportBonus(liste, debut, fin);
            report.ShowPreview();
        }
    }

    public class PrintModel
    {
        private List<PrintHelp> _recuList;
        public CasherIn _c;
        public TicketDirect Ticket { get; set; }
        public TicketDirect Bon { get; set; }

        public PrintModel()
        {
            _recuList = new List<PrintHelp>();
            SetList();
        }

        public PrintModel(CasherIn c)
        {
            _c = new CasherIn();
            _c = c;
            _c.Set();
        }

        public PrintModel(OperationElem item)
        {
            Bon = new TicketDirect(item)
            {
                somme = { Text = item.Montant2 },
                count = { Text = item.Count },
                nomPro = { Text = "BON DE COMMANDE" }
            };
            Ticket = new TicketDirect(item)
            {
                somme = { Text = item.Montant2 },
                count = { Text = item.Count },
                nomPro = { Text = "TICKET DE LIVRAISON" },
                message = { Text = "Cherchez les marchandises." }
            };
        }

        public void ImprimerRecu()
        {
            var report = new Recu(_c);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.Print();
            //rpt.PrintDocument("Epson TM-T70 Receipt");
            DiaryHelpers.UpdateErrorPrint(_c.Id);
            DateHelpers.Delete(_c.Id);
            ReparationHelpers.RemoveFastPrint(_c.Id);
            ReparationHelpers.ClearCashTable(_c.Id);
        }

        protected void ImprimerAutres(long id, PrintItem item)
        {
            if ((item.Groupe == 6) || (item.Groupe >= 10) || (item.Groupe == 2))
            {
                return;
            }
            var model = CashHelpers.GetModel(id);
            var rpt = new XtraDocument(model);
            rpt.Print();
            if (item.Groupe == 9)
            {
                CashHelpers.UpdateAmountInvoice(id, 0);
                return;
            }
            DateHelpers.Delete(id);
        }

        private void ImprimerTicket()
        {
            string name = ApiModel.GetPrinterName(1);
            Ticket.Print(name);
        }

        private void ImprimerBon()
        {
            string name = ApiModel.GetPrinterName(1);
            Bon.Print(name);
        }

        private void SetList()
        {
            _recuList = ReparationHelpers.GetFastPrintHelps().ToList();
        }
    }
}