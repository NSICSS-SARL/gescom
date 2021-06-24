using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace gescom.data.Models
{
    public static class TarifHelpers
    {
    }

    public class TarifCart
    {
        public List<TarifItem> Tarifs { get; set; }
    }

    public class TarifItem
    {
        public MssqlQuery _query { get; set; }

        public TarifItem(string tableName)
        {
            Init(tableName);
        }

        public TarifItem()
        {
            Init();
        }

        public TarifItem(float prixAchat, float coeffficient, float margeGros, float margeDetail,
             float margeSpecial,
             float margeExtra)
        {
            Achat = prixAchat;
            Revient = coeffficient;
            Gros = margeGros;
            Detail = margeDetail;
            Special = margeSpecial;
            Extra = margeExtra;
        }

        public TarifItem(float prixAchat, decimal coeffficient, decimal margeGros, decimal margeDetail,
           decimal margeSpecial, decimal margeExtra)
        {
            Achat = prixAchat;
            Revient = StdCalcul.DecimalToFloat(coeffficient);
            Gros = StdCalcul.DecimalToFloat(margeGros);
            Detail = StdCalcul.DecimalToFloat(margeDetail);
            Special = StdCalcul.DecimalToFloat(margeSpecial);
            Extra = StdCalcul.DecimalToFloat(margeExtra);
        }

        public float Achat { get; set; }
        public string UniteFrns { get; set; }
        public string InsParams { get; set; }
        public string UpdParams { get; set; }
        public float Detail { get; set; }

        public float Extra { get; set; }

        public float Gros { get; set; }

        public long Id { get; set; }

        public float Quantite { get; set; }

        public float Revient { get; set; }

        public float Special { get; set; }

        public string TableName { get; set; }

        public void Copy(TarifItem item)
        {
            Id = item.Id;
            Achat = item.Achat;
            Revient = item.Revient;
            Gros = item.Gros;
            Detail = item.Detail;
            Special = item.Special;
            Extra = item.Extra;
            UniteFrns = item.UniteFrns;
        }

        public void Copy(TaxableItem item)
        {
            Id = item.Id;
            if (item.Achat != null) Achat = (float)item.Achat;
            if (item.Revient != null) Revient = (float)item.Revient;
            if (item.Gros != null) Gros = (float)item.Gros;
            if (item.Detail != null) Detail = (float)item.Detail;
            if (item.Special != null) Special = (float)item.Special;
            if (item.Extra != null) Extra = (float)item.Extra;
            UniteFrns = item.UniteFrns;
        }

        public void Copy(MargeItem item)
        {
            Id = item.Id;
            if (item.Achat != null) Achat = (float)item.Achat;
            if (item.Revient != null) Revient = (float)item.Revient;
            if (item.Gros != null) Gros = (float)item.Gros;
            if (item.Detail != null) Detail = (float)item.Detail;
            if (item.Special != null) Special = (float)item.Special;
            if (item.Extra != null) Extra = (float)item.Extra;
        }

        public void Copy(HorsItem item)
        {
            Id = item.Id;
            if (item.Achat != null) Achat = (float)item.Achat;
            if (item.Revient != null) Revient = (float)item.Revient;
            if (item.Gros != null) Gros = (float)item.Gros;
            if (item.Detail != null) Detail = (float)item.Detail;
            if (item.Special != null) Special = (float)item.Special;
            if (item.Extra != null) Extra = (float)item.Extra;
        }

        public void Copy(PrimeItem item)
        {
            Id = item.Id;
            if (item.Achat != null) Achat = (float)item.Achat;
            if (item.Revient != null) Revient = (float)item.Revient;
            if (item.Gros != null) Gros = (float)item.Gros;
            if (item.Detail != null) Detail = (float)item.Detail;
            if (item.Special != null) Special = (float)item.Special;
            if (item.Extra != null) Extra = (float)item.Extra;
        }

        public void Copy(TaxeItem item)
        {
            Id = item.Id;
            if (item.Achat != null) Achat = (float)item.Achat;
            if (item.Revient != null) Revient = (float)item.Revient;
            if (item.Gros != null) Gros = (float)item.Gros;
            if (item.Detail != null) Detail = (float)item.Detail;
            if (item.Special != null) Special = (float)item.Special;
            if (item.Extra != null) Extra = (float)item.Extra;
        }

        public bool Read(long id)
        {
            if (!VerifierExistence(id))
            {
                return false;
            }
            string[] reader = _query.Reader(id, 7);
            Achat = float.Parse(reader[0]);
            Revient = float.Parse(reader[1]);
            Gros = float.Parse(reader[2]);
            Detail = float.Parse(reader[3]);
            Special = float.Parse(reader[4]);
            Extra = float.Parse(reader[5]);
            Quantite = float.Parse(reader[6]);
            return true;
        }

        public void ReadFast(long id)
        {
            string[] reader = _query.Reader(id, 7);
            Achat = float.Parse(reader[0]);
            Revient = float.Parse(reader[1]);
            Gros = float.Parse(reader[2]);
            Detail = float.Parse(reader[3]);
            Special = float.Parse(reader[4]);
            Extra = float.Parse(reader[5]);
            Quantite = float.Parse(reader[6]);
        }

        public void SafeCreate(long id)
        {
            _query.InsertOutId();
            _query.SetLongParam("id", id);
            SetParams();
        }

        public void SafeCreate(string unite)
        {
            var sb = new StringBuilder();
            var query = new MssqlQuery();
            sb.Append("INSERT INTO TaxableItem (Id, Achat, Revient, Gros, Detail, ");
            sb.Append("Special, Extra, Quantite, UniteFrns) VALUES ('");
            sb.Append(Id + "','" + Achat + "','" + Revient + "','" + Gros + "','" + Detail + "','" +
            Special + "','" + Extra + "','" + Quantite + "','" + UniteFrns + "')");
            string commande = sb.ToString();
            Console.WriteLine(commande);
            query.Command.CommandText = commande;
            query.ExecuterQuery();
        }

        public void SafeCreate()
        {
            _query.InsertOutId();
            _query.SetLongParam("id", Id);
            SetParams();
            _query.ExecuteUpdate();
        }

        public void SafeUpdate()
        {
            _query.BeforeUpdate();
            SetParams();
            _query.SetIdParam(Id);
            _query.ExecuteUpdate();
        }

        public void Soustract(TarifItem t1, TarifItem t2)
        {
            Gros = t1.Gros - t2.Gros;
            Detail = t1.Detail - t2.Detail;
            Special = t1.Special - t2.Special;
            Extra = t1.Extra - t2.Extra;
        }

        private void Init(string tableName)
        {
            TableName = tableName;
            // paramètres en insertion***/
            InsParams = "(@ID, @ACHAT, @REVIENT, @GROS, @DETAIL, @SPECIAL, @EXTRA, @QUANTITE);";
            // paramètres de mise à jour***/
            UpdParams = "ACHAT = @ACHAT, REVIENT = @REVIENT, GROS = @GROS, DETAIL = @DETAIL, SPECIAL = @SPECIAL, EXTRA = @EXTRA , QUANTITE = @QUANTITE WHERE ID = @ID";
            // paramètres SqlConnections dans SqlConnection class.***/
            var p = new Query(tableName, InsParams, UpdParams);
            _query = new MssqlQuery(p);
        }

        private void Init()
        {
            TableName = "TaxableItem";
            // paramètres en insertion***/
            InsParams = "(@ID, @ACHAT, @REVIENT, @GROS, @DETAIL, @SPECIAL, @EXTRA, @QUANTITE, @UNITEFRNS);";
            // paramètres de mise à jour***/
            UpdParams = "ACHAT = @ACHAT, REVIENT = @REVIENT, GROS = @GROS, DETAIL = @DETAIL, SPECIAL = @SPECIAL, EXTRA = @EXTRA , QUANTITE = @QUANTITE WHERE ID = @ID";
            // paramètres SqlConnections dans SqlConnection class.***/
            var p = new Query(TableName, InsParams, UpdParams);
            _query = new MssqlQuery(p);
        }

        private void SetParams()
        {
            // parametres.***/
            _query.SetDoubleParam("achat", Achat);
            _query.SetDoubleParam("revient", Revient);
            _query.SetDoubleParam("gros", Gros);
            _query.SetDoubleParam("detail", Detail);
            _query.SetDoubleParam("special", Special);
            _query.SetDoubleParam("extra", Extra);
            _query.SetDoubleParam("quantite", Quantite);
        }

        private bool VerifierExistence(long id)
        {
            int count = _query.CountRecordsById(id);
            if (count > 0)
            {
                return true;
            }
            return false;
        }
    }

    public class TarifModel
    {
        public TarifModel()
        {
            Init();
        }

        public TarifModel(bool taxable)
        {
            Init();
            IsTaxable = taxable;
        }

        public string UniteFrns { get; set; }

        public TarifItem Exonere { get; set; }

        public long Id { get; set; }

        public bool IsTaxable { get; set; }

        public TarifItem Marge { get; set; }

        public TarifItem Prime { get; set; }

        public TarifItem Taxable { get; set; }

        public TarifItem Taxe { get; set; }

        public string InsParams { get; set; }

        public void Copy(MargeItem item)
        {
            Marge.Copy(item);
        }

        public void Copy(TaxableItem item)
        {
            Taxable.Copy(item);
        }

        public void Copy(HorsItem item)
        {
            Exonere.Copy(item);
        }

        public void Copy(TaxeItem item)
        {
            Taxe.Copy(item);
        }

        public void Copy(PrimeItem item)
        {
            Prime.Copy(item);
        }

        public void Create()
        {
            if (Marge.Achat <= 0)
            {
                return;
            }
            Marge.SafeCreate();
            Exonere.SafeCreate();
            Taxe.SafeCreate();
            Prime.SafeCreate();
            Taxable.SafeCreate("NO UNIT");
            CreateItems();
        }

        public bool Read(long id)
        {
            var item = ArticleHelpers.Get(id);
            if (item == null)
            {
                return false;
            }
            ReadFast(id);
            return true;
        }

        public void ReadFast(long id)
        {
            Id = id;
            Marge.Copy(PriceHelpers.ObtenirMarge(id));
            Exonere.Copy(PriceHelpers.ObtenirPrixHt(id));
            Taxe.Copy(PriceHelpers.ObtenirTaxe(id));
            Taxable.Copy(PriceHelpers.ObtenirPrixTtc(id));
            Prime.Copy(PriceHelpers.GetPrime(id));
        }

        public void SafeUpdate()
        {
            Marge.SafeUpdate();
            Exonere.SafeUpdate();
            Taxable.SafeUpdate();
            Taxe.SafeUpdate();
            Prime.SafeUpdate();
        }

        public void SetId(long id)
        {
            if (id <= 0)
            {
                return;
            }
            Id = id;
            Exonere.Id = id;
            Marge.Id = id;
            Taxe.Id = id;
            Taxable.Id = id;
            Prime.Id = id;
        }

        public void SetMarge(long id, float prixAchat, decimal coefficient, decimal margeGros, decimal margeDetail,
            decimal margeSpecial, decimal margeExtra, bool isTaxable)
        {
            SetId(id);
            Marge.Achat = prixAchat;
            Marge.Revient = StdCalcul.DecimalToFloat(coefficient);
            Marge.Gros = StdCalcul.DecimalToFloat(margeGros);
            Marge.Detail = StdCalcul.DecimalToFloat(margeDetail);
            Marge.Special = StdCalcul.DecimalToFloat(margeSpecial);
            Marge.Extra = StdCalcul.DecimalToFloat(margeExtra);
            IsTaxable = isTaxable;
            SetTarif();
        }

        public void SetMarge(long id, float prixAchat, decimal coefficient, decimal margeGros, decimal margeDetail,
          decimal margeSpecial, decimal margeExtra, bool isTaxable, float primeRate)
        {
            SetId(id);
            Marge.Achat = prixAchat;
            Marge.Revient = StdCalcul.DecimalToFloat(coefficient);
            Marge.Gros = StdCalcul.DecimalToFloat(margeGros);
            Marge.Detail = StdCalcul.DecimalToFloat(margeDetail);
            Marge.Special = StdCalcul.DecimalToFloat(margeSpecial);
            Marge.Extra = StdCalcul.DecimalToFloat(margeExtra);
            IsTaxable = isTaxable;
            SetTarif(primeRate);
        }

        private void CreateItems()
        {
            ArticleItem article = ArticleHelpers.Get(Id);
            ActeHelpers.Create(Id);
            var query = new MssqlQuery();
            var sb = new StringBuilder();
            sb.Append("INSERT INTO ProdItem VALUES('");
            sb.Append(Id);
            sb.Append("','" + article.CompleteCode);
            sb.Append("','" + article.Nom);
            sb.Append("','" + article.Refce);
            sb.Append("','");
            sb.Append(Marge.Achat);
            sb.Append("','");
            sb.Append(article.Iu);
            sb.Append("','-1','0','NB','0','rq','0','0','-1','-1','0','0','0');");
            string commande = sb.ToString();
            query.Command.CommandText = commande;
            query.ExecuterQuery();
            sb.Clear();
            sb.Append("INSERT INTO DistItem VALUES('");
            sb.Append(Id);
            sb.Append("','.");
            sb.Append("','0','AUCUN','0','USR');");
            commande = sb.ToString();
            query.Command.CommandText = commande;
            query.ExecuterQuery();
            sb.Clear();
            sb.Append("INSERT INTO EventsItem VALUES('");
            sb.Append(Id);
            sb.Append("', '");
            sb.Append(DateTime.Now.ToString(CultureInfo.InvariantCulture));
            sb.Append("', '");
            sb.Append(DateTime.Now.ToString(CultureInfo.InvariantCulture));
            sb.Append("','-1','-1');");
            commande = sb.ToString();
            query.Command.CommandText = commande;
            query.ExecuterQuery();
            sb.Clear();
            SituationHelpers.Create(Id);
            /*sb.Append("INSERT INTO SituationItem VALUES('");
            sb.Append(Id);
            sb.Append("','','');");
            commande = sb.ToString();
            query.Command.CommandText = commande;
            query.ExecuterQuery();*/
        }

        private void Init()
        {
            Marge = new TarifItem("MargeItem");
            Exonere = new TarifItem("HorsItem");
            Taxe = new TarifItem("TaxeItem");
            Taxable = new TarifItem("TaxableItem");
            Prime = new TarifItem("PrimeItem");
        }

        private void SetPrime(float primeRate)
        {
            Prime.Achat = primeRate;
            if (primeRate <= 0)
            {
                return;
            }
            Prime.Revient = Exonere.Revient;
            Prime.Gros = (Exonere.Gros - Prime.Revient) * primeRate / 100;
            Prime.Gros = StdCalcul.LissagePrixF(Prime.Gros);
            if (Prime.Gros < 0)
            {
                Prime.Gros = 0;
            }
            Prime.Detail = (Exonere.Detail - Prime.Revient) * primeRate / 100;
            Prime.Detail = StdCalcul.LissagePrixF(Prime.Detail);
            if (Prime.Detail < 0)
            {
                Prime.Detail = 0;
            }
            Prime.Special = (Exonere.Special - Prime.Revient) * primeRate / 100;
            Prime.Special = StdCalcul.LissagePrixF(Prime.Special);
            if (Prime.Special < 0)
            {
                Prime.Special = 0;
            }
            Prime.Extra = (Exonere.Extra - Prime.Revient) * primeRate / 100;
            Prime.Extra = StdCalcul.LissagePrixF(Prime.Extra);
            if (Prime.Extra < 0)
            {
                Prime.Extra = 0;
            }
        }

        private void SetTarif(float primeRate)
        {
            Exonere.Achat = Marge.Achat;
            Taxe.Achat = Marge.Achat;
            Taxable.Achat = Marge.Achat;
            Exonere.Revient = StdCalcul.GetPrixCompleteF(Exonere.Achat, Marge.Revient);
            Exonere.Revient = StdCalcul.GetSimpleLisseF(Exonere.Revient);
            Exonere.Gros = StdCalcul.GetCompleteLisseF(Exonere.Revient, Marge.Gros);
            Exonere.Detail = StdCalcul.GetCompleteLisseF(Exonere.Revient, Marge.Detail);
            Exonere.Special = StdCalcul.GetCompleteLisseF(Exonere.Revient, Marge.Special);
            Exonere.Extra = StdCalcul.GetCompleteLisseF(Exonere.Revient, Marge.Extra);
            Taxable.Copy(Exonere);
            SetPrime(primeRate);
            if (!IsTaxable)
            {
                return;
            }
            var taux = PriceHelpers.GetTaxe();
            Taxable.Gros = StdCalcul.GetCompleteLisseF(Exonere.Gros, taux);
            Taxable.Detail = StdCalcul.GetCompleteLisseF(Exonere.Detail, taux);
            Taxable.Special = StdCalcul.GetCompleteLisseF(Exonere.Special, taux);
            Taxable.Extra = StdCalcul.GetCompleteLisseF(Exonere.Extra, taux);
            Taxable.Revient = Exonere.Revient;
            Taxe.Revient = Exonere.Revient;
            Taxe.Soustract(Taxable, Exonere);
        }

        private void SetTarif()
        {
            Exonere.Achat = Marge.Achat;
            Taxe.Achat = Marge.Achat;
            Taxable.Achat = Marge.Achat;
            Exonere.Revient = StdCalcul.GetPrixCompleteF(Exonere.Achat, Marge.Revient);
            Exonere.Revient = StdCalcul.GetSimpleLisseF(Exonere.Revient);
            Exonere.Gros = StdCalcul.GetCompleteLisseF(Exonere.Revient, Marge.Gros);
            Exonere.Detail = StdCalcul.GetCompleteLisseF(Exonere.Revient, Marge.Detail);
            Exonere.Special = StdCalcul.GetCompleteLisseF(Exonere.Revient, Marge.Special);
            Exonere.Extra = StdCalcul.GetCompleteLisseF(Exonere.Revient, Marge.Extra);
            Taxable.Copy(Exonere);
            if (!IsTaxable)
            {
                return;
            }
            var taux = PriceHelpers.GetTaxe();
            Taxable.Gros = StdCalcul.GetCompleteLisseF(Exonere.Gros, taux);
            Taxable.Detail = StdCalcul.GetCompleteLisseF(Exonere.Detail, taux);
            Taxable.Special = StdCalcul.GetCompleteLisseF(Exonere.Special, taux);
            Taxable.Extra = StdCalcul.GetCompleteLisseF(Exonere.Extra, taux);
            Taxable.Revient = Exonere.Revient;
            Taxe.Revient = Exonere.Revient;
            Taxe.Soustract(Taxable, Exonere);
        }
    }
}