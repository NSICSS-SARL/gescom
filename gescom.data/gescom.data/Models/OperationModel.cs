using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class OperationHelpers
    {
        public static IEnumerable<OperationAuto> CommandAuto()
        {
            var context = new DataGescomDataContext();
            return context.OperationAutos;
        }

        public static OperationModel Get(long id)
        {
            var repository = new OperationRepository();
            var item = repository.Get(id);
            item.Init();
            var model = new OperationModel();
            model.Copy(item);
            return model;
        }

        public static List<OperationItem> GetAdminList()
        {
            var liste = new List<OperationItem>();
            foreach (var item in GetList())
            {
                if(item.Ndx == 1)
                {
                    Console.WriteLine("ok");
                }
                item.Init();
                liste.Add(item);
            }

            return liste;
        }

        public static List<OperationModel> GetAvoirs()
        {
            var result = new List<OperationModel>();
            var context = new DataGescomDataContext();
            foreach (var item in context.OperationItems)
            {
                var element = new OperationModel();
                element.Copy(item);
                float x = 0;
                if (item.PDetail != null) x = (float) item.PDetail;

                element.Px = x;
                result.Add(element);
            }

            return result;
        }

        public static IEnumerable<OperationItem> GetByFamily(long id)
        {
            return GetList().Where(item => item.IdCat == id);
        }

        public static IEnumerable<OperationItem> GetByPlace(long id)
        {
            return GetList().Where(item => item.IdPlace == id);
        }

        public static IEnumerable<OperationItem> GetByUnit(long id)
        {
            return GetList().Where(item => item.IdUnit == id);
        }

        public static IEnumerable<OperationModel> GetCart(PersonModel item, long wid)
        {
            var result = new List<OperationModel>();
            foreach (var element in GetCart(item).Where(p=>p.L == 1 || p.L == null))
            {  element.Wid = wid;
                    result.Add(element);
            }
            return result;
        }

        public static IEnumerable<OperationModel> GetCart(PersonModel item)
        {
            var result = new List<OperationModel>();
            var g = item.Groupe;
            foreach (var model in GetForGenerals())
            {
                var element = new OperationModel();
                element.Copy(model);
                switch (g)
                {
                    case 0:
                        element.Px = (float)model.Pachat;
                        element.Rx = 0;
                        break;

                    case 1:
                        element.Px = (float)model.PGros;
                        element.Rx = (float)model.PrimGros;
                        break;

                    case 2:
                        element.Px = (float)model.PDetail;
                        element.Rx = (float)model.PrimDetail;
                        break;

                    case 3:
                        element.Px = (float)model.PSpecial;
                        element.Rx = (float)model.PrimSpecial;
                        break;

                    case 4:
                        element.Px = (float)model.PExtra;
                        element.Rx = (float)model.PrimExtra;
                        break;
                }

                result.Add(element);
            }

            return result;
        }

        public static IEnumerable<OperationModel> GetDestockList()
        {
            var result = new List<OperationModel>();
            var context = new DataGescomDataContext();
            var liste = context.OperationEntries.ToList().Where(p =>p.L > 0);
            foreach (var item in liste)
            {
                
                    var model = new OperationModel();
                    model.Copy(item);
                    result.Add(model);
                            
            }
            return result;
        }

        public static IEnumerable<OperationModel> GetEntryList()
        {
            var result = new List<OperationModel>();
            var context = new DataGescomDataContext();
            var liste = context.OperationEntries.ToList();
            foreach (var item in liste)
            {
                var model = new OperationModel();
                model.Copy(item);
                result.Add(model);
            }

            return result;
        }

        public static IEnumerable<OperationItem> GetExcludeVendor(long pid)
        {
            return GetList().Where(item => item.Pid == pid);
        }

        public static IEnumerable<OperationModel> GetForGenerals(long wid)
        {
            var result = new List<OperationModel>();
            foreach (var model in GetForGenerals())
            {
                model.Wid = wid;
                result.Add(model);
            }

            return result;
        }

        public static IEnumerable<OperationModel> GetForGenerals()
        {
            var result = new List<OperationModel>();
            var context = new DataGescomDataContext();
            foreach (var model in context.OperationDispos)
            {
                var element = new OperationModel();
                element.Copy(model);
                float x = 0;
                if (model.PDetail != null) x = (float) model.PDetail;

                element.Px = x;
                result.Add(element);
            }

            return result;
        }

        public static List<OperationItem> GetList()
        {
            var context = new DataGescomDataContext();
            var result = context.OperationItems.ToList();
            /*  foreach(var r in result)
              {
                  SituationHelpers.Create(r.Ndx);
              }*/
            return result;
        }

        public static IEnumerable<OperationItem> GetPublicList()
        {
            foreach (var item in GetList())
                if (item.QStock > 0)
                {
                    item.Dispo = "Disponible";
                    yield return item;
                }
        }

        public static IEnumerable<OperationCommande> GetList2()
        {
            var context = new DataGescomDataContext();
            var result = new List<OperationCommande>();
            foreach (var c in context.OperationCommandes)
            {
                c.Init();
                result.Add(c);
            }

            return result;
        }

        public static IEnumerable<OperationItem> GetListActif()
        {
            return GetList().Where(item => item.L == null || item.L == 1);
        }

        public static IEnumerable<OperationItem> GetListCmdble()
        {
            return GetList().Where(item => item.QStock <= item.QEstime && item.Qvente > 0);
        }

        public static IEnumerable<OperationItem> GetListCommands()
        {
            return GetList().Where(item => item.QEstime >= 0);
        }

        public static IEnumerable<OperationItem> GetListDisponible()
        {
            return GetList().Where(item => item.QStock > 0);
        }

        public static IEnumerable<OperationItem> GetListRupt()
        {
            return GetList().Where(item => item.Qvente > 0 && item.QStock == 0);
        }

        public static IEnumerable<OperationItem> GetListSeuil()
        {
            return GetList().Where(item => item.QStock <= item.QSeuil);
        }

        public static IEnumerable<OperationItem> GetListStagne()
        {
            return GetList().Where(item => item.QStock == item.Qachat && item.Qvente == 0);
        }

        public static List<OperationItem> GetMagList()
        {
            return GetAdminList().Where(item => item.L != 2).ToList();
        }

        public static OperationModel GetModel(IEnumerable<OperationModel> liste, OperationModel model)
        {
            var result = new OperationModel();
            foreach (var element in liste.Where(operationItem => operationItem.Ndx == model.Ndx))
            {
                element.IsValid = true;
                result = element;
            }

            return result;
        }

        public static IEnumerable<OperationModel> GetModelList()
        {
            var result = new List<OperationModel>();
            foreach (var item in GetList())
            {
                var model = new OperationModel();
                model.Copy(item);
                model.Px = (float)model.PDetail;
                result.Add(model);
            }

            return result;
        }

        public static IEnumerable<OperationModel> GetModelList(PersonModel model)
        {
            return GetModelList().Where(operationModel => operationModel.Forme == model.Forme);
        }

        public static IEnumerable<OperationModel> GetModelList2(PersonModel model)
        {
            return GetModelList().Where(item => item.Forme == model.Forme && item.Pid == model.Id);
        }

        public static IEnumerable<ProdItem> GetprodForCommand()
        {
            var repo = new DataGescomDataContext();
            return repo.ProdItems.Where(item => item.Arret && item.Epuise && item.Quantite > 0);
        }

        public static List<OperationItem> GetQuantified(List<long> modifiedRows)
        {
            var repo = new OperationRepository();
            var result = new List<OperationItem>();
            foreach (var line in modifiedRows)
            {
                var qte = ProdHelpers.GetEstimated(line);
                if (!(qte > 0)) continue;
                var element = repo.Get(line);
                element.Qte = qte;
                result.Add(element);
            }

            return result;
        }

        public static OperationModel GetShortCode(IEnumerable<OperationModel> liste, string code)
        {
            var result = new OperationModel();
            foreach (var item in GetShCode(liste, code).ToList()) result = item;

            return result;
        }

        public static OperationText GetText(long id)
        {
            var result = new OperationText();
            result.Copy(Get(id));
            return result;
        }

        public static IEnumerable<ElementModel> ListValidCommand(List<ElementModel> elements)
        {
            var repo = new ProdRepository();
            foreach (var elem in elements)
            {
                var b = repo.IsCommandValid(elem.Id);
                if (b) yield return elem;
            }
        }

        public static void SaveCommandes(List<ElementModel> elements)
        {
            var liste = ListValidCommand(elements).ToList();
            var r = ActionHelpers.DoAutoCommande(liste);
            ProdHelpers.ReinitCommande(liste);
            DataHelpers.WriteCommand(r);
        }

        public static IEnumerable<OperationText> SetTexts(List<OperationItem> liste)
        {
            var result = new List<OperationText>();
            foreach (var item in liste)
            {
                var text = new OperationText();
                var model = new OperationModel();
                model.Copy(item);
                text.Copy(model);
                result.Add(text);
            }

            return result;
        }

        private static IEnumerable<OperationModel> GetShCode(IEnumerable<OperationModel> liste, string code)
        {
            return liste.Where(item => item.Fcode == code);
        }
    }

    public class OperationCart : IEnumerable<OperationItem>
    {
        public OperationCart()
        {
            Operations = new List<OperationItem>();
            var repository = new OperationRepository();
            var count = repository.Count();
            if (count == 0) return;

            foreach (var element in repository.Operations())
            {
                var item = element;
                if (item.QEstime == null || item.QEstime == 0) item.StateCommande = "ARRIVAGE";

                if (item.QEstime == -1) item.StateCommande = "EN COURS";

                if (item.QEstime > 0) item.StateCommande = "COMMANDABLE";

                item.Cview = item.Codage + "-I";
                if (item.Forme == 1)
                {
                    item.Formel = true;
                    item.Cview = item.Codage + "-X";
                    if (item.Taxable == 1) item.Cview = item.Codage + "-T";
                }

                if (item.Taxable == 1) item.Taxed = true;

                Operations.Add(item);
            }
        }

        public List<OperationItem> Operations { get; set; }

        public IEnumerator<OperationItem> GetEnumerator()
        {
            return Operations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class OperationCommande
    {
        public bool Commander { get; set; }
        public string SupCode { get; set; }

        public void Init()
        {
            var n = CompleteCode.Length;
            var suffix = "-" + CompleteCode.Substring(n - 1, 1);
            SupCode = Fcode + suffix;
        }
    }

    public partial class OperationDispo
    {
        public string NewCode { get; set; }
        public bool Acder { get; set; }
        public bool Attente { get; set; }
        public bool Commander { get; set; }
        public string Cview { get; set; }
        public bool Faite { get; set; }
        public bool Formel { get; set; }
        public bool IsValid { get; set; }
        public float Px { get; set; }
        public float Qrebut { get; set; }
        public float Qte { get; set; }
        public float Rx { get; set; }

        public bool Taxed { get; set; }
        public bool VoirEntre { get; set; }
        public bool VoirPrix { get; set; }
        public float Vrebut { get; set; }
        public long Wid { get; set; }
    }

    public partial class OperationEntry
    {
        public bool Signal { get; set; }
        public string NewCode { get; set; }
    }

    public partial class OperationItem
    {
        public bool Acder { get; set; }
        public string Dispo { get; set; }
        public bool Attente { get; set; }
        public bool Commander { get; set; }
        public string Cview { get; set; }
        public bool Faite { get; set; }
        public bool Formel { get; set; }
        public bool IsValid { get; set; }
        public float Px { get; set; }
        public float Qrebut { get; set; }
        public float Qte { get; set; }
        public float Rx { get; set; }
        public bool Signal { get; set; }
        public bool SignCmd { get; set; }
        public string SupCode { get; set; }
        public bool Taxed { get; set; }
        public float Vrebut { get; set; }
        public string NewCode { get; set; }
        public long Wid { get; set; }

        public void Copy(OperationDispo model)
        {
            StateCommande = model.StateCommande;
            Ndx = model.Ndx;
            Codage = model.Codage;
            Place = model.Place;
            Designation = model.Designation;
            Pachat = model.Pachat;
            Previent = model.Previent;
            PGros = model.PGros;
            PDetail = model.PDetail;
            PSpecial = model.PSpecial;
            PExtra = model.PExtra;
            QEstime = model.QEstime;
            PEstime = model.PEstime;
            Magpref = model.Magpref;
            Nomvers = model.Nomvers;
            Categorie = model.Categorie;
            Unite = model.Unite;
            QStock = model.QStock;
            Nomfrns = model.Nomfrns;
            Vstock = model.Vstock;
            DateVente = model.DateVente;
            DateAchat = model.DateAchat;
            Frs = model.Frs;
            Pid = model.Pid;
            Clt = model.Clt;
            Remark = model.Remark;
            Observation = model.Observation;
            Remarque = model.Remarque;
            Qachat = model.Qachat;
            Vachat = model.Vachat;
            Qavoir = model.Qavoir;
            Vavoir = model.Vavoir;
            Qvente = model.Qvente;
            Vvente = model.Vvente;
            Qercpt = model.Qercpt;
            Vercpt = model.Vercpt;
            Qdefect = model.Qdefect;
            Vdefect = model.Vdefect;
            Qvol = model.Qvol;
            Vvol = model.Vvol;
            Qte = model.Qte;
            Px = model.Px;
            IsValid = model.IsValid;
            Refers = model.Refers;
            Qrebut = model.Qrebut;
            Vrebut = model.Vrebut;
            IdUnit = model.IdUnit;
            S1 = model.S1;
            S2 = model.S2;
            Q = model.Q;
            Q1 = model.Q1;
            Q2 = model.Q2;
            D1 = model.D1;
            D2 = model.D2;
            B1 = model.B1;
            B2 = model.B2;
            PrimGros = model.PrimGros;
            PrimDetail = model.PrimDetail;
            PrimSpecial = model.PrimSpecial;
            PrimExtra = model.PrimExtra;
            Forme = model.Forme;
            Taxable = model.Taxable;
            Formel = model.Formel;
            Taxed = model.Taxed;
            Cview = model.Cview;
            AEntre = model.AEntre;
            APrix = model.APrix;
        }

        public void Init()
        {
            var n = CompleteCode.Length;
            var suffix = "-" + CompleteCode.Substring(n - 1, 1);
            var arr = CompleteCode.Substring(n - 3).Split('-');
            //NewCode = arr[0] + Ndx + "-"+ arr[1];
            NewCode = Fcode+ "-" + arr[1];
            SupCode = Fcode + suffix;
        }
    }

    public class OperationModel:OperationItem
    {
       

        public void Copy(OperationEntry item)
        {
            if (item == null) return;

            CompleteCode = item.CompleteCode;
            Signal = item.Signal;
            StateCommande = item.StateCommande;
            Fcode = item.Fcode;
            OtherInfo = item.OtherInfo;
            Ndx = item.Ndx;
            Codage = item.Codage;
            Place = item.Place;
            Designation = item.Designation;
            S1 = item.S1;
            S2 = item.S2;
            T1 = item.T1;
            Q = item.Q;
            Q4 = item.Q4;
            Q6 = item.Q6;
            H4 = item.H4;
            Q6 = item.Q6;
            Q1 = item.Q1;
            Q2 = item.Q2;
            D1 = item.D1;
            D2 = item.D2;
            B1 = item.B1;
            if (item.Pid != null) Pid = (long) item.Pid;
            Remark = item.Remark;
            Observation = item.Observation;
            Remarque = item.Remarque;
            B2 = item.B2;
            if (item.Pachat != null) Pachat = (float) item.Pachat;
            if (item.Previent != null) Previent = (float) item.Previent;
            if (item.PGros != null) PGros = (float) item.PGros;
            if (item.PSpecial != null) PSpecial = (float) item.PSpecial;
            if (item.PExtra != null) PExtra = (float) item.PExtra;
            if (item.QEstime != null) QEstime = (float) item.QEstime;
            if (item.PEstime != null) PEstime = (float) item.PEstime;
            if (item.AEntre != null) AEntre = (long) item.AEntre;
            if (item.APrix != null) APrix = (long) item.APrix;
            Magpref = item.Magpref;
            Nomvers = item.Nomvers;
            Categorie = item.Categorie;
            Unite = item.Unite;
            if (item.QStock != null) QStock = (float) item.QStock;
            Nomfrns = item.Nomfrns;
            if (item.Vstock != null) Vstock = (float) item.Vstock;
            if (item.DateVente != null) DateVente = (DateTime) item.DateVente;
            if (item.DateAchat != null) DateAchat = (DateTime) item.DateAchat;
            Frs = item.Frs;
            Clt = item.Clt;
            if (item.Qachat != null)
            {
                Qachat = (float) item.Qachat;
                Vachat = (float) item.Vachat;
            }

            if (item.Qavoir != null)
            {
                Qavoir = (float) item.Qavoir;
                Vavoir = (float) item.Vavoir;
            }

            if (item.Qvente != null)
            {
                Qvente = (float) item.Qvente;
                Vvente = (float) item.Vvente;
            }

            if (item.Qercpt != null)
            {
                Qercpt = (float) item.Qercpt;
                Vercpt = (float) item.Vercpt;
            }

            if (item.Qdefect != null)
            {
                Qdefect = (float) item.Qdefect;
                Vdefect = (float) item.Vdefect;
            }

            if (item.Qvol != null)
            {
                Qvol = (float) item.Qvol;
                Vvol = (float) item.Vvol;
            }

            if (item.Px != null) Px = (float) item.Px;

            if (item.QSeuil == null) return;

            QSeuil = (float) item.QSeuil;
            Refers = item.Refers;
            if(Qvol is null) { Qvol = 0; }
            if(Qdefect is null) { Qdefect = 0; }
            Qrebut = (float)(Qvol + Qdefect);
            if (Vvol is null) { Vvol = 0; }
            if (Vdefect is null) { Vdefect = 0; }
            Vrebut = (float)(Vvol + Vdefect);
            IdCat = (long) item.IdCat;
            if (item.IdUnit == null) item.IdUnit = 20;

            IdUnit = (long) item.IdUnit;
            if (item.IdPlace == null)
            {
                IdPlace = 0;
                return;
            }

            IdPlace = (long) item.IdPlace;
            PrimGros = (float) item.PrimGros;
            PrimDetail = (float) item.PrimDetail;
            PrimSpecial = (float) item.PrimSpecial;
            PrimExtra = (float) item.PrimExtra;
            Forme = (long) item.Forme;
            Taxable = (int) item.Taxable;
        }

        public void Copy(OperationItem item)
        {
            if (item == null) return;

            NewCode = item.NewCode;
            CompleteCode = item.CompleteCode;
            Fcode = item.Fcode;
            StateCommande = item.StateCommande;
            OtherInfo = item.OtherInfo;
            Ndx = (long)item.Ndx;
            Codage = item.Codage;
            Place = item.Place;
            Designation = item.Designation;
            S1 = item.S1;
            S2 = item.S2;
            T1 = item.T1;
            Q = (long)item.Q;
            Q1=(long) item.Q1;
            Q2 = (long)item.Q2;
            D1 = (DateTime)item.D1;
            D2 = (DateTime)item.D2;
            B1 = item.B1;
            if (item.Pid != null) Pid = (long) item.Pid;
            Remark = item.Remark;
            Observation = item.Observation;
            Remarque = item.Remarque;
            Cview = item.Cview;
            B2 = item.B2;
            IsValid = item.IsValid;
            if (item.Pachat != null) Pachat = (float) item.Pachat;
            if (item.Previent != null) Previent = (float) item.Previent;
            if (item.PGros != null) PGros = (float) item.PGros;
            if (item.PDetail != null) PDetail = (float) item.PDetail;
            if (item.PSpecial != null) PSpecial = (float) item.PSpecial;
            if (item.PExtra != null) PExtra = (float) item.PExtra;
            if (item.QEstime != null) QEstime = (float) item.QEstime;
            if (item.PEstime != null) PEstime = (float) item.PEstime;
            if (item.AEntre != null) AEntre = (long) item.AEntre;
            if (item.APrix != null) APrix = (long) item.APrix;
            Magpref = item.Magpref;
            Nomvers = item.Nomvers;
            Categorie = item.Categorie;
            Unite = item.Unite;
            if (item.QStock != null) QStock = (float) item.QStock;
            Nomfrns = item.Nomfrns;
            if (item.Vstock != null) Vstock = (float) item.Vstock;
            if (item.DateVente != null) DateVente = (DateTime) item.DateVente;
            if (item.DateAchat != null) DateAchat = (DateTime) item.DateAchat;
            Frs = item.Frs;
            Clt = item.Clt;
            if (item.Qachat != null)
            {
                Qachat = (float) item.Qachat;
                Vachat = (float) item.Vachat;
            }

            if (item.Qavoir != null)
            {
                Qavoir = (float) item.Qavoir;
                Vavoir = (float) item.Vavoir;
            }

            if (item.Qvente != null)
            {
                Qvente = (float) item.Qvente;
                Vvente = (float) item.Vvente;
            }

            if (item.Qercpt != null)
            {
                Qercpt = (float) item.Qercpt;
                Vercpt = (float) item.Vercpt;
            }

            if (item.Qdefect != null)
            {
                Qdefect = (float) item.Qdefect;
                Vdefect = (float) item.Vdefect;
            }

            if (item.Qvol != null)
            {
                Qvol = (float) item.Qvol;
                Vvol = (float) item.Vvol;
            }

            Qte = item.Qte;
            Px = item.Px;
            if (item.QSeuil == null) return;

            QSeuil = (float) item.QSeuil;
            Refers = item.Refers;
            if(Qvol is null)
            {
                Qvol = 0;
            }
            if(Qdefect is null)
            {
                Qdefect = 0;
            }
            Qrebut = (float)(Qvol + Qdefect);
            if (Vvol is null)
            {
                Vvol = 0;
            }
            if (Vdefect is null)
            {
                Vdefect = 0;
            }
            Vrebut = (float)(Vvol + Vdefect);
            IdCat = (long) item.IdCat;
            if (item.IdUnit == null) item.IdUnit = 20;

            IdUnit = (long) item.IdUnit;
            if (item.IdPlace == null)
            {
                IdPlace = 0;
                return;
            }

            IdPlace = (long) item.IdPlace;
            PrimGros = (float) item.PrimGros;
            PrimDetail = (float) item.PrimDetail;
            PrimSpecial = (float) item.PrimSpecial;
            PrimExtra = (float) item.PrimExtra;
            Forme = (long) item.Forme;
            Taxable = (int) item.Taxable;
            Formel = item.Formel;
            Taxed = item.Taxed;
            if (item.Qcder == null)
                Qcder = 0;
            else
                Qcder = (double) item.Qcder;
        }

        public void Copy(OperationDispo item)
        {
            if (item == null) return;

            CompleteCode = item.CompleteCode;
            Fcode = item.Fcode;
            StateCommande = item.StateCommande;
            OtherInfo = item.OtherInfo;
            Ndx = item.Ndx;
            Codage = item.Codage;
            Place = item.Place;
            Designation = item.Designation;
            S1 = item.S1;
            S2 = item.S2;
            T1 = item.T1;
            Q = item.Q;
            Q1 = item.Q1;
            Q2 = item.Q2;
            D1 = item.D1;
            D2 = item.D2;
            B1 = item.B1;
            if (item.Pid != null) Pid = (long) item.Pid;
            Remark = item.Remark;
            Observation = item.Observation;
            Remarque = item.Remarque;
            Cview = item.Cview;
            B2 = item.B2;
            IsValid = item.IsValid;
            if (item.Pachat != null) Pachat = (float) item.Pachat;
            if (item.Previent != null) Previent = (float) item.Previent;
            if (item.PGros != null) PGros = (float) item.PGros;
            if (item.PDetail != null) PDetail = (float) item.PDetail;
            if (item.PSpecial != null) PSpecial = (float) item.PSpecial;
            if (item.PExtra != null) PExtra = (float) item.PExtra;
            if (item.QEstime != null) QEstime = (float) item.QEstime;
            if (item.PEstime != null) PEstime = (float) item.PEstime;
            if (item.AEntre != null) AEntre = (long) item.AEntre;
            if (item.APrix != null) APrix = (long) item.APrix;
            Magpref = item.Magpref;
            Nomvers = item.Nomvers;
            Categorie = item.Categorie;
            Unite = item.Unite;
            if (item.QStock != null) QStock = (float) item.QStock;
            Nomfrns = item.Nomfrns;
            if (item.Vstock != null) Vstock = (float) item.Vstock;
            if (item.DateVente != null) DateVente = (DateTime) item.DateVente;
            if (item.DateAchat != null) DateAchat = (DateTime) item.DateAchat;
            Frs = item.Frs;
            Clt = item.Clt;
            if (item.Qachat != null)
            {
                Qachat = (float) item.Qachat;
                Vachat = (float) item.Vachat;
            }

            if (item.Qavoir != null)
            {
                Qavoir = (float) item.Qavoir;
                Vavoir = (float) item.Vavoir;
            }

            if (item.Qvente != null)
            {
                Qvente = (float) item.Qvente;
                Vvente = (float) item.Vvente;
            }

            if (item.Qercpt != null)
            {
                Qercpt = (float) item.Qercpt;
                Vercpt = (float) item.Vercpt;
            }

            if (item.Qdefect != null)
            {
                Qdefect = (float) item.Qdefect;
                Vdefect = (float) item.Vdefect;
            }

            if (item.Qvol != null)
            {
                Qvol = (float) item.Qvol;
                Vvol = (float) item.Vvol;
            }

            Qte = item.Qte;
            Px = item.Px;
            if (item.QSeuil == null) return;

            QSeuil = (float) item.QSeuil;
            Refers = item.Refers;
            if(Qvol is null)
            {
                Qvol = 0;
            }
            if (Vvol is null)
            {
                Vvol = 0;
            }
            if (Qdefect is null)
            {
                Qdefect = 0;
            }
            if (Vdefect is null)
            {
                Vdefect = 0;
            }
            Qrebut = (float)(Qvol + Qdefect);

            Vrebut = (float)(Vvol + Vdefect);
            IdCat = (long) item.IdCat;
            if (item.IdUnit == null) item.IdUnit = 20;

            IdUnit = (long) item.IdUnit;
            if (item.IdPlace == null)
            {
                IdPlace = 0;
                return;
            }

            IdPlace = (long) item.IdPlace;
            PrimGros = (float) item.PrimGros;
            PrimDetail = (float) item.PrimDetail;
            PrimSpecial = (float) item.PrimSpecial;
            PrimExtra = (float) item.PrimExtra;
            Forme = (long) item.Forme;
            Taxable = (int) item.Taxable;
            Formel = item.Formel;
            Taxed = item.Taxed;
        }

        public void Copy(OperationModel model)
        {
            Ndx = model.Ndx;
            NewCode = model.NewCode;
            CompleteCode = model.CompleteCode;
            StateCommande = model.StateCommande;
            OtherInfo = model.OtherInfo;
            Codage = model.Codage;
            Place = model.Place;
            Designation = model.Designation;
            Pachat = model.Pachat;
            Previent = model.Previent;
            PGros = model.PGros;
            PDetail = model.PDetail;
            PSpecial = model.PSpecial;
            PExtra = model.PExtra;
            QEstime = model.QEstime;
            PEstime = model.PEstime;
            Magpref = model.Magpref;
            Pid = model.Pid;
            Nomvers = model.Nomvers;
            Categorie = model.Categorie;
            Unite = model.Unite;
            QStock = model.QStock;
            Nomfrns = model.Nomfrns;
            Vstock = model.Vstock;
            DateVente = model.DateVente;
            DateAchat = model.DateAchat;
            Frs = model.Frs;
            Clt = model.Clt;
            Cview = model.Cview;
            Qachat = model.Qachat;
            Remark = model.Remark;
            Observation = model.Observation;
            Remarque = model.Remarque;
            Vachat = model.Vachat;
            Qavoir = model.Qavoir;
            Vavoir = model.Vavoir;
            Qvente = model.Qvente;
            Vvente = model.Vvente;
            Qercpt = model.Qercpt;
            Vercpt = model.Vercpt;
            Qdefect = model.Qdefect;
            Vdefect = model.Vdefect;
            Qvol = model.Qvol;
            Vvol = model.Vvol;
            Qte = model.Qte;
            Px = model.Px;
            IsValid = model.IsValid;
            QSeuil = model.QSeuil;
            Refers = model.Refers;
            Qrebut = model.Qrebut;
            Vrebut = model.Vrebut;
            IdCat = model.IdCat;
            IdPlace = model.IdPlace;
            IdUnit = model.IdUnit;
            S1 = model.S1;
            S2 = model.S2;
            Q = model.Q;
            Q1 = model.Q1;
            Q2 = model.Q2;
            D1 = model.D1;
            D2 = model.D2;
            B1 = model.B1;
            B2 = model.B2;
            PrimGros = model.PrimGros;
            PrimDetail = model.PrimDetail;
            PrimSpecial = model.PrimSpecial;
            PrimExtra = model.PrimExtra;
            Forme = model.Forme;
            Taxable = model.Taxable;
            Formel = model.Formel;
            Taxed = model.Taxed;
            AEntre = model.AEntre;
            APrix = model.APrix;
            Fcode = model.Fcode;
        }
    }

    public class OperationRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.OperationItems.Count();
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

        public void Add(OperationItem operation)
        {
            _context.OperationItems.InsertOnSubmit(operation);
        }

        public OperationItem Get(long id)
        {
            var item = _context.OperationItems.SingleOrDefault(d => d.Ndx == id);
            if (item == null) return null;
            var arr = item.CompleteCode.Substring(item.CompleteCode.Length - 3).Split('-');
            item.NewCode = arr[0] + item.Ndx + "-" + arr[1];
            return item;
        }

        public IQueryable<OperationItem> Operations()
        {
            return _context.OperationItems;
        }
    }

    public class OperationText
    {
        public string NewCode { get; set; }
        public string B1 { get; set; }

        public string B2 { get; set; }

        public string Categorie { get; set; }

        public string Clt { get; set; }

        public string Codage { get; set; }

        public string Cview { get; set; }

        public DateTime D1 { get; set; }

        public DateTime D2 { get; set; }

        public DateTime DateAchat { get; set; }

        public DateTime DateVente { get; set; }

        public string Designation { get; set; }

        public bool DuplicateError { get; set; }

        public string Frs { get; set; }

        public string Id { get; set; }

        public string IdCat { get; set; }

        public string IdPlace { get; set; }

        public bool IsValid { get; set; }

        public string Magpref { get; set; }

        public string Ndx { get; set; }

        public string Nomfrns { get; set; }

        public string Nomvers { get; set; }

        public string Operateur { get; set; }

        public string OtherInfo { get; set; }

        public string Pachat { get; set; }

        public string PDetail { get; set; }

        public string PEstime { get; set; }

        public string PExtra { get; set; }

        public string PGros { get; set; }

        public string Place { get; set; }

        public string Previent { get; set; }

        public string PSpecial { get; set; }

        public string Px { get; set; }

        public string Q { get; set; }

        public string Q1 { get; set; }

        public string Q2 { get; set; }

        public string Qachat { get; set; }

        public string Qavoir { get; set; }

        public string Qdefect { get; set; }

        public string Qercpt { get; set; }

        public string QEstime { get; set; }

        public string Qrebut { get; set; }

        public string QSeuil { get; set; }

        public string QStock { get; set; }

        public string Qte { get; set; }

        public string Qvente { get; set; }

        public string Qvol { get; set; }

        public string Refers { get; set; }

        public string Rx { get; set; }

        public string S1 { get; set; }

        public string S2 { get; set; }

        public string StateCommande { get; set; }

        public string Unite { get; set; }

        public string Vachat { get; set; }

        public string Vavoir { get; set; }

        public string Vdefect { get; set; }

        public string Vercpt { get; set; }

        public string Vrebut { get; set; }

        public string Vstock { get; set; }

        public string Vvente { get; set; }

        public string Vvol { get; set; }

        public string Wid { get; set; }

        public void Copy(OperationModel model)
        {
            StateCommande = model.StateCommande;
            OtherInfo = model.OtherInfo;
            Categorie = model.Categorie;
            Clt = model.Clt;
            Codage = model.Codage;
            DateAchat = (DateTime)model.DateAchat;
            DateVente = (DateTime)model.DateVente;
            Designation = model.Designation;
            Frs = model.Frs;
            IsValid = model.IsValid;
            Magpref = model.Magpref;
            Nomfrns = model.Nomfrns;
            Nomvers = model.Nomvers;
            Place = model.Place;
            Refers = model.Refers;
            Unite = model.Unite;
            Pachat = StdCalcul.DoubleToSpaceFormat((float)model.Pachat);
            PDetail = StdCalcul.DoubleToSpaceFormat((float)model.PDetail);
            PEstime = StdCalcul.DoubleToSpaceFormat((float)model.PEstime);
            PExtra = StdCalcul.DoubleToSpaceFormat((float)model.PExtra);
            PGros = StdCalcul.DoubleToSpaceFormat((float)model.PGros);
            Previent = StdCalcul.DoubleToSpaceFormat((float)model.Previent);
            PSpecial = StdCalcul.DoubleToSpaceFormat((float)model.PSpecial);
            Px = StdCalcul.DoubleToSpaceFormat((float)model.Px);
            Qachat = StdCalcul.DoubleToSpaceFormat((float)model.Qachat);
            Qavoir = StdCalcul.DoubleToSpaceFormat((float)model.Qavoir);
            Qdefect = StdCalcul.DoubleToSpaceFormat((float)model.Qdefect);
            Qercpt = StdCalcul.DoubleToSpaceFormat((float)model.Qercpt);
            QEstime = StdCalcul.DoubleToSpaceFormat((float)model.QEstime);
            QStock = StdCalcul.DoubleToSpaceFormat((float)model.QStock);
            Qte = StdCalcul.DoubleToSpaceFormat(model.Qte);
            Qvente = StdCalcul.DoubleToSpaceFormat((float)model.Qvente);
            Qvol = StdCalcul.DoubleToSpaceFormat((float)model.Qvol);
            Qrebut = StdCalcul.DoubleToSpaceFormat((float)model.Qrebut);
            Vachat = StdCalcul.DoubleToSpaceFormat((float)model.Vachat);
            Vavoir = StdCalcul.DoubleToSpaceFormat((float)model.Vavoir);
            Vdefect = StdCalcul.DoubleToSpaceFormat((float)model.Vdefect);
            Vercpt = StdCalcul.DoubleToSpaceFormat((float)model.Vercpt);
            Vstock = StdCalcul.DoubleToSpaceFormat((float)model.Vstock);
            Vvente = StdCalcul.DoubleToSpaceFormat((float)model.Vvente);
            Vvol = StdCalcul.DoubleToSpaceFormat((float)model.Vvol);
            QSeuil = StdCalcul.DoubleToSpaceFormat((float)model.QSeuil);
            Vrebut = StdCalcul.DoubleToSpaceFormat((float)model.Vrebut);
            Ndx = StdCalcul.DoubleToSpaceFormat((float)model.Ndx);
            IdCat = StdCalcul.DoubleToSpaceFormat((float)model.IdCat);
            IdPlace = StdCalcul.DoubleToSpaceFormat((float)model.IdPlace);
            S1 = model.S1;
            S2 = model.S2;
            if (model.Q is null)
            {
                model.Q = 0;
            }
            if (model.Q1 is null)
            {
                model.Q1 = 0;
            }
            if (model.Q2 is null)
            {
                model.Q2 = 0;
            }
            Q = StdCalcul.DoubleToSpaceFormat((float)model.Q);
            Q1 = StdCalcul.DoubleToSpaceFormat((float)model.Q1);
            Q2 = StdCalcul.DoubleToSpaceFormat((float)model.Q2);
            if (model.D1 != null)
            {
                D1 = (DateTime)model.D1;
            }
            if (model.D2 != null)
            {
                D2 = (DateTime)model.D2;
            }
            B1 = model.B1;
            B2 = model.B2;
            Cview = model.Cview;
        }
    }
}