using DevExpress.XtraReports.UI;
using gescom.data.Models;
using gescom.printer.Reports;

namespace gescom.printer
{

    public static class PrintHelpers
    {
        public static long PrintReceipt(long id)
        {
            var model = CashHelpers.GetModel(id);
            var rpt = new XtraRecu(model);
            rpt.Print();
            return id;
        }
      

        public static void PrintTicket(long id)
        {
            var rpt = new XtraTicket(id);
            rpt.Print();
        }
    }
    public class Print
    {
    }
}
