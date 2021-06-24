using DevExpress.XtraReports.UI;
using gescom.data.Models;
using gescom.report.Reports;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.report.Extensions
{
    public static class ReportHelpers
    {
        public static void ImprimerFactureRegle(long id)
        {
            var diary = DiaryHelpers.Get(id);
            if (diary.Groupe != 2)
            {
                return;
            }
            var report = new ReportFacture(id);
            report.SetVisible();
            report.ShowPreview();
        }

        public static void ImprimerFactureBon(long id)
        {
            var diary = DiaryHelpers.Get(id);
            if (diary.Groupe != 2)
            {
                return;
            }
            var report = new ReportFacture(id);
            report.ShowPreview();
        }

        public static void ImprimerImpots(IEnumerable<ImpotItem> liste, DateTime debut, DateTime fin)
        {
            var myList = liste.ToList();
            if (myList.Count == 0) { return; }
            var report = new ReportDeclare(myList, debut, fin);
            report.ShowPreview();
        }
    }
}