using System;
using System.Collections.Generic;

namespace gescom.data.Models
{
    public static class ApiModel
    {
        public static CasherIn GetCasher(long id)
        {
            var ctx = new DataGescomDataContext();
            var result = new CasherIn();
            foreach (var elt in ctx.CasherIns)
            {
                if (elt.Id != id) continue;
                if (elt.Montant != null)
                {
                    var valeur = (float) elt.Montant;
                    elt.Montant2 = StdCalcul.DoubleToSpaceFormat(valeur);
                    elt.Id2 = StdCalcul.DoubleToSpaceFormat(elt.Id);
                }

                result = elt;
            }

            return result;
        }

        public static string GetPrinterName(long id)
        {
            var ctx = new DataGescomDataContext();
            var result = new Printer();
            foreach (var elt in ctx.Printers)
                if (elt.PrinterId == id)
                    result = elt;
            return result.PrinterName;
        }

        public static List<CasherIn> GetNotPaid()
        {
            var liste = new List<CasherIn>();
            foreach (var elt in GetCasherIns())
            {
                float x = 0;
                if (elt.Montant != null) x = (float) elt.Montant;
                elt.Montant2 = StdCalcul.DoubleToSpaceFormat(x);
                liste.Add(elt);
            }

            return liste;
        }

        public static IEnumerable<CasherIn> GetCasherIns()
        {
            var ctx = new DataGescomDataContext();
            return ctx.CasherIns;
        }

        public static List<CashElement> SetElementList(long id)
        {
            var ctx = new DataGescomDataContext();
            var result = new List<CashElement>();
            foreach (var elt in ctx.CashElements)
                if (elt.Rang == id)
                    if (elt.Produit != null)
                    {
                        var fcode = elt.Code.Substring(elt.Code.Length - 1, 1) +
                                    elt.Code.Substring(0, elt.Code.Length - 1);
                        elt.Code = fcode;
                        var x = (float) elt.Produit;
                        elt.Pdt = StdCalcul.DoubleToSpaceFormat(x);
                        result.Add(elt);
                    }

            return result;
        }

        public static void SetCasherList(CasherIn c)
        {
            c.ListElem = SetElementList(c.Id);
            c.Count = c.ListElem.Count.ToString();
        }
    }

    public class OperationElem
    {
        public OperationElem()
        {
            Operateur = Environment.UserName;
            Members = new List<TicketModel>();
        }

        public long Id { get; set; }
        public string Operateur { get; set; }
        public string Receveur { get; set; }
        public long Wid { get; set; }
        public long Groupe { get; set; }
        public PersonItem Person { get; set; }
        public string Count { get; set; }
        public string Montant2 { get; set; }
        public List<TicketModel> Members { get; set; }
    }

    public partial class CasherIn
    {
        public List<CashElement> ListElem { get; set; }
        public float Obtenu { get; set; }
        public string Id2 { get; set; }
        public string Montant2 { get; set; }
        public string Count { get; set; }
        public string SellerName { get; set; }

        public void Set()
        {
            float montant = 0;
            if (Percu == null) return;
            Obtenu = (float) Percu;
            if (Montant != null) montant = (float) Montant;
            Rendu = Obtenu - montant;
        }
    }

    public partial class CashElement
    {
        public string Pdt { get; set; }
    }

    public partial class BoxGroup
    {
        public string Montant2 { get; set; }
    }

    public class TiroirModel
    {
        public TiroirModel()
        {
            var date = DateTime.Now.Date;
            Items = new List<BoxGroup>();
            var ctx = new DataGescomDataContext();
            float montants = 0;
            float percus = 0;
            float rendus = 0;
            var count = 0;
            foreach (var item in ctx.BoxGroups)
            {
                var d = new DateTime();
                if (item.D2 != null) d = (DateTime) item.D2;
                if (d.Date == date)
                {
                    float montant = 0;
                    float percu = 0;
                    float rendu = 0;
                    if (item.Montant != null)
                    {
                        montant = (float) item.Montant;
                        item.Montant2 = StdCalcul.DoubleToSpaceFormat(montant);
                        montants += montant;
                    }

                    if (item.Percu != null)
                    {
                        percu = (float) item.Percu;
                        percus += percu;
                    }

                    if (item.Rendu != null)
                    {
                        rendu = (float) item.Rendu;
                        rendus += rendu;
                    }

                    count++;
                    Items.Add(item);
                }
            }

            MontantTotal = StdCalcul.DoubleToSpaceFormat(montants);
            RenduTotal = StdCalcul.DoubleToSpaceFormat(rendus);
            PercuTotal = StdCalcul.DoubleToSpaceFormat(percus);
            Count = StdCalcul.DoubleToSpaceFormat(count);
        }

        public string MontantTotal { get; set; }
        public string PercuTotal { get; set; }
        public string Count { get; set; }
        public string RenduTotal { get; set; }
        public List<BoxGroup> Items { get; set; }
    }
}