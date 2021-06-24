using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class PriceHelpers
    {
        public static float CalculReboursHt(long id, float prix)
        {
            var item = ArticleHelpers.Get(id);
            float result = prix;
            if (item.Taxable == 1)
            {
                result = prix - CalculReboursTva(prix);
            }
            result = StdCalcul.GetSimpleLisseF(result);
            return result;
        }

        public static float CalculReboursTva(float prix)
        {
            float result = 0;
            float numerator = GetTaxe() / 100;
            float denominator = 1 + numerator;
            if (numerator > 0)
            {
                numerator = numerator / denominator;
                result = prix * numerator;
            }
            result = StdCalcul.GetSimpleLisseF(result);
            return result;
        }

        public static TaxableItem GetItem(long id)
        {
            var repo = new TaxableRepository();
            return repo.Get(id);
        }

        public static float GetPAchat(long id)
        {
            float result = 0;
            float? prix = ObtenirMarge(id).Achat;
            if (prix != null) result = (float)prix;
            return result;
        }

        public static float GetPDetail(long id)
        {
            float result = 0;
            float? prix = ObtenirPrixTtc(id).Detail;
            if (prix != null) result = (float)prix;
            return result;
        }

        public static float GetPExtra(long id)
        {
            float result = 0;
            float? prix = ObtenirPrixTtc(id).Extra;
            if (prix != null) result = (float)prix;
            return result;
        }

        public static float GetPGros(long id)
        {
            float result = 0;
            float? prix = ObtenirPrixTtc(id).Gros;
            if (prix != null) result = (float)prix;
            return result;
        }

        public static float GetPRevient(long id)
        {
            float result = 0;
            float? prix = ObtenirPrixHt(id).Revient;
            if (prix != null) result = (float)prix;
            return result;
        }

        public static float GetPrice(long id, long groupe)
        {
            switch (groupe)
            {
                case -1:
                    return GetPRevient(id);

                case 1:
                    return GetPGros(id);

                case 2:
                    return GetPDetail(id);

                case 3:
                    return GetPSpecial(id);

                case 4:
                    return GetPExtra(id);

                default:
                    return GetPAchat(id);
            }
        }

        public static PrimeItem GetPrime(long id)
        {
            var reptory = new PrimeRepository();
            return reptory.Get(id);
        }

        public static float GetPrixItem(long id)
        {
            float result = 0;
            float? prix = GetItem(id).Detail;
            if (prix != null) result = (float)prix;
            return result;
        }

        public static float GetPSpecial(long id)
        {
            float result = 0;
            float? prix = ObtenirPrixTtc(id).Special;
            if (prix != null) result = (float)prix;
            return result;
        }

        public static float GetTaxe()
        {
            var reptory = new TvaRepository();
            return reptory.Get(1).Taux;
        }

        public static MargeItem ObtenirMarge(long id)
        {
            var reptory = new MargeRepository();
            return reptory.Get(id);
        }

        public static List<MargeItem> ObtenirMarges()
        {
            var cart = new MargeCart();
            return cart.Marges;
        }

        public static List<PrimeItem> ObtenirPrimes()
        {
            var cart = new PrimeCart();
            return cart.Primes;
        }

        public static HorsItem ObtenirPrixHt(long id)
        {
            var reptory = new HorsRepository();
            return reptory.Get(id);
        }

        public static TaxableItem ObtenirPrixTtc(long id)
        {
            var reptory = new TaxableRepository();
            return reptory.Get(id);
        }

        public static List<HorsItem> ObtenirTarifHt()
        {
            var cart = new HorsCart();
            return cart.Hors;
        }

        public static List<TaxableItem> ObtenirTarifTtc()
        {
            var cart = new TaxableCart();
            return cart.Taxables;
        }

        public static TaxeItem ObtenirTaxe(long id)
        {
            var reptory = new TaxeRepository();
            return reptory.Get(id);
        }

        public static List<TaxeItem> ObtenirTaxes()
        {
            var cart = new TaxeCart();
            return cart.Taxes;
        }

        public static void UpdateTaxe(float taux)
        {
            var reptory = new TvaRepository();
            reptory.Update(taux);
        }

        public static bool UpdateUniteNameTaxable(long id, string unite)
        {
            var repo = new TaxableRepository();
            var item = repo.Get(id);
            item.UniteFrns = unite;
            return repo.Save();
        }
    }

    public class HorsCart : IEnumerable<HorsItem>
    {
        public HorsCart()
        {
            Hors = new List<HorsItem>();
            var repository = new HorsRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (HorsItem element in repository.Hors())
            {
                HorsItem item = element;
                Hors.Add(item);
            }
        }

        public List<HorsItem> Hors { get; set; }

        public IEnumerator<HorsItem> GetEnumerator()
        {
            return Hors.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class HorsItem
    {
        public bool DuplicateError { get; set; }

        public bool IsValid { get; set; }

        public void Copy(PriceModel model)
        {
            IsValid = model.IsValid;
            DuplicateError = model.DuplicateError;
            Id = model.Id;
            Achat = model.Achat;
            Revient = model.Revient;
            Gros = model.Gros;
            Detail = model.Detail;
            Special = model.Special;
            Extra = model.Extra;
            Quantite = model.Quantite;
        }
    }

    public class HorsRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(HorsItem hors)
        {
            _context.HorsItems.InsertOnSubmit(hors);
        }

        public int Count()
        {
            return _context.HorsItems.Count();
        }

        public void Create(PriceModel model)
        {
            if (!model.HasError())
            {
                var item = new HorsItem { Id = Count() + 1 };
                item.Copy(model);
                Add(item);
                _context.SubmitChanges();
            }
        }

        public void Delete(HorsItem item)
        {
            _context.HorsItems.DeleteOnSubmit(item);
        }

        public HorsItem Get(long id)
        {
            return _context.HorsItems.SingleOrDefault(d => d.Id == id);
        }

        public IQueryable<HorsItem> Hors()
        {
            return _context.HorsItems;
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

    public class MargeCart : IEnumerable<MargeItem>
    {
        public MargeCart()
        {
            Marges = new List<MargeItem>();
            var repository = new MargeRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (MargeItem element in repository.Marges())
            {
                MargeItem item = element;
                Marges.Add(item);
            }
        }

        public List<MargeItem> Marges { get; set; }

        public IEnumerator<MargeItem> GetEnumerator()
        {
            return Marges.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class MargeItem
    {
        public bool DuplicateError { get; set; }

        public bool IsValid { get; set; }

        public void Copy(PriceModel model)
        {
            IsValid = model.IsValid;
            DuplicateError = model.DuplicateError;
            Id = model.Id;
            Achat = model.Achat;
            Revient = model.Revient;
            Gros = model.Gros;
            Detail = model.Detail;
            Special = model.Special;
            Extra = model.Extra;
            Quantite = model.Quantite;
        }
    }

    public class MargeRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(MargeItem item)
        {
            _context.MargeItems.InsertOnSubmit(item);
        }

        public int Count()
        {
            return _context.MargeItems.Count();
        }

        public void Create(PriceModel model)
        {
            if (!model.HasError())
            {
                var item = new MargeItem { Id = Count() + 1 };
                item.Copy(model);
                Add(item);
                _context.SubmitChanges();
            }
        }

        public void Delete(MargeItem item)
        {
            _context.MargeItems.DeleteOnSubmit(item);
        }

        public MargeItem Get(long id)
        {
            return _context.MargeItems.SingleOrDefault(d => d.Id == id);
        }

        public IQueryable<MargeItem> Marges()
        {
            return _context.MargeItems;
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

    public class PriceModel
    {
        public PriceModel()
        {
            Achat = 0;
            Detail = 0;
            Extra = 0;
            Gros = 0;
            Id = 0;
            Quantite = 0;
            Revient = 0;
            Special = 0;
        }

        public float Achat { get; set; }

        public float Detail { get; set; }

        public bool DuplicateError { get; set; }

        public float Extra { get; set; }

        public float Gros { get; set; }

        public long Id { get; set; }

        public bool IsValid { get; set; }

        public float Quantite { get; set; }

        public float Revient { get; set; }

        public float Special { get; set; }

        public void Copy(MargeItem item)
        {
            if (item == null) { return; }
            if (item.Achat != null) Achat = (float)item.Achat;
            if (item.Detail != null) Detail = (float)item.Detail;
            if (item.Extra != null) Extra = (float)item.Extra;
            if (item.Gros != null) Gros = (float)item.Gros;
            Id = item.Id;
            if (item.Quantite != null) Quantite = (float)item.Quantite;
            if (item.Revient != null) Revient = (float)item.Revient;
            if (item.Special != null) Special = (float)item.Special;
        }

        public void Copy(TaxeItem item)
        {
            if (item == null) { return; }
            if (item.Achat != null) Achat = (float)item.Achat;
            if (item.Detail != null) Detail = (float)item.Detail;
            if (item.Extra != null) Extra = (float)item.Extra;
            if (item.Gros != null) Gros = (float)item.Gros;
            Id = item.Id;
            if (item.Quantite != null) Quantite = (float)item.Quantite;
            if (item.Revient != null) Revient = (float)item.Revient;
            if (item.Special != null) Special = (float)item.Special;
        }

        public void Copy(TaxableItem item)
        {
            if (item == null) { return; }
            if (item.Achat != null) Achat = (float)item.Achat;
            if (item.Detail != null) Detail = (float)item.Detail;
            if (item.Extra != null) Extra = (float)item.Extra;
            if (item.Gros != null) Gros = (float)item.Gros;
            Id = item.Id;
            if (item.Quantite != null) Quantite = (float)item.Quantite;
            if (item.Revient != null) Revient = (float)item.Revient;
            if (item.Special != null) Special = (float)item.Special;
        }

        public void Copy(HorsItem item)
        {
            if (item == null) { return; }
            if (item.Achat != null) Achat = (float)item.Achat;
            if (item.Detail != null) Detail = (float)item.Detail;
            if (item.Extra != null) Extra = (float)item.Extra;
            if (item.Gros != null) Gros = (float)item.Gros;
            Id = item.Id;
            if (item.Quantite != null) Quantite = (float)item.Quantite;
            if (item.Revient != null) Revient = (float)item.Revient;
            if (item.Special != null) Special = (float)item.Special;
        }

        public bool HasError()
        {
            IsValid = ((Achat > 0) && (Revient > 0) && (Gros > 0) && (Detail > 0) && (Special > 0) && (Extra > 0));
            if ((Achat > Revient) || (Special < Revient) || (Extra < Revient) || (Detail < Gros))
            {
                IsValid = false;
            }
            return IsValid;
        }
    }

    public class PrimeCart : IEnumerable<PrimeItem>
    {
        public PrimeCart()
        {
            Primes = new List<PrimeItem>();
            var repository = new PrimeRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (PrimeItem element in repository.Primes())
            {
                PrimeItem item = element;
                Primes.Add(item);
            }
        }

        public List<PrimeItem> Primes { get; set; }

        public IEnumerator<PrimeItem> GetEnumerator()
        {
            return Primes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class PrimeItem
    {
        public bool DuplicateError { get; set; }

        public bool IsValid { get; set; }

        public void Copy(PriceModel model)
        {
            IsValid = model.IsValid;
            DuplicateError = model.DuplicateError;
            Id = model.Id;
            Achat = model.Achat;
            Revient = model.Revient;
            Gros = model.Gros;
            Detail = model.Detail;
            Special = model.Special;
            Extra = model.Extra;
            Quantite = model.Quantite;
        }
    }

    public class PrimeRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(PrimeItem item)
        {
            _context.PrimeItems.InsertOnSubmit(item);
        }

        public int Count()
        {
            return _context.PrimeItems.Count();
        }

        public void Create(PriceModel model)
        {
            if (!model.HasError())
            {
                var item = new PrimeItem { Id = Count() + 1 };
                item.Copy(model);
                Add(item);
                _context.SubmitChanges();
            }
        }

        public void Delete(PrimeItem item)
        {
            _context.PrimeItems.DeleteOnSubmit(item);
        }

        public PrimeItem Get(long id)
        {
            return _context.PrimeItems.SingleOrDefault(d => d.Id == id);
        }

        public IQueryable<PrimeItem> Primes()
        {
            return _context.PrimeItems;
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

    public class TaxableCart : IEnumerable<TaxableItem>
    {
        public TaxableCart()
        {
            Taxables = new List<TaxableItem>();
            var repository = new TaxableRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (TaxableItem element in repository.Taxables())
            {
                TaxableItem item = element;
                Taxables.Add(item);
            }
        }

        public List<TaxableItem> Taxables { get; set; }

        public IEnumerator<TaxableItem> GetEnumerator()
        {
            return Taxables.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class TaxableItem
    {
        public bool DuplicateError { get; set; }

        public bool IsValid { get; set; }

        public void Copy(PriceModel model)
        {
            IsValid = model.IsValid;
            DuplicateError = model.DuplicateError;
            Id = model.Id;
            Achat = model.Achat;
            Revient = model.Revient;
            Gros = model.Gros;
            Detail = model.Detail;
            Special = model.Special;
            Extra = model.Extra;
            Quantite = model.Quantite;
        }
    }

    public class TaxableRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(TaxableItem item)
        {
            _context.TaxableItems.InsertOnSubmit(item);
        }

        public int Count()
        {
            return _context.TaxableItems.Count();
        }

        public void Create(PriceModel model)
        {
            if (!model.HasError())
            {
                var item = new TaxableItem { Id = Count() + 1 };
                item.Copy(model);
                Add(item);
                _context.SubmitChanges();
            }
        }

        public void Delete(TaxableItem item)
        {
            _context.TaxableItems.DeleteOnSubmit(item);
        }

        public TaxableItem Get(long id)
        {
            return _context.TaxableItems.SingleOrDefault(d => d.Id == id);
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

        public IQueryable<TaxableItem> Taxables()
        {
            return _context.TaxableItems;
        }
    }

    public class TaxeCart : IEnumerable<TaxeItem>
    {
        public TaxeCart()
        {
            Taxes = new List<TaxeItem>();
            var repository = new TaxeRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (TaxeItem element in repository.Taxes())
            {
                TaxeItem item = element;
                Taxes.Add(item);
            }
        }

        public List<TaxeItem> Taxes { get; set; }

        public IEnumerator<TaxeItem> GetEnumerator()
        {
            return Taxes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class TaxeItem
    {
        public bool DuplicateError { get; set; }

        public bool IsValid { get; set; }

        public void Copy(PriceModel model)
        {
            IsValid = model.IsValid;
            DuplicateError = model.DuplicateError;
            Id = model.Id;
            Achat = model.Achat;
            Revient = model.Revient;
            Gros = model.Gros;
            Detail = model.Detail;
            Special = model.Special;
            Extra = model.Extra;
            Quantite = model.Quantite;
        }
    }

    public class TaxeRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(TaxeItem item)
        {
            _context.TaxeItems.InsertOnSubmit(item);
        }

        public int Count()
        {
            return _context.TaxeItems.Count();
        }

        public void Create(PriceModel model)
        {
            if (!model.HasError())
            {
                var item = new TaxeItem { Id = Count() + 1 };
                item.Copy(model);
                Add(item);
                _context.SubmitChanges();
            }
        }

        public void Delete(TaxeItem item)
        {
            _context.TaxeItems.DeleteOnSubmit(item);
        }

        public TaxeItem Get(long id)
        {
            return _context.TaxeItems.SingleOrDefault(d => d.Id == id);
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

        public IQueryable<TaxeItem> Taxes()
        {
            return _context.TaxeItems;
        }
    }

    public partial class TvaItem
    {
        public bool DuplicateError { get; set; }

        public bool IsValid { get; set; }
    }

    public class TvaRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(TvaItem item)
        {
            _context.TvaItems.InsertOnSubmit(item);
        }

        public int Count()
        {
            return _context.TvaItems.Count();
        }

        public void Delete(TvaItem item)
        {
            _context.TvaItems.DeleteOnSubmit(item);
        }

        public TvaItem Get(long id)
        {
            return _context.TvaItems.SingleOrDefault(d => d.Id == id);
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

        public IQueryable<TvaItem> Tvas()
        {
            return _context.TvaItems;
        }

        public void Update(float taux)
        {
            if (taux <= 0) { return; }
            var item = Get(1);
            item.Taux = taux;
            Save();
        }
    }
}