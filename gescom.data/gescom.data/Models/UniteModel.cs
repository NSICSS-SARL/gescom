using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class UniteHelpers
    {
        public static bool Create(string code, string nom)
        {
            var model = new UniteModel { Code = code, Nom = nom };
            var repository = new UniteRepository();
            return repository.Create(model);
        }

        // unite selon son identifiant id.
        public static UniteItem Get(long id)
        {
            var result = new UniteItem();
            foreach (UniteItem item in GetList().Where(item => item.Id == id))
            {
                result = item;
            }
            return result;
        }

        /** modification de unite**/

        public static string GetCode(long id)
        {
            string result = null;
            foreach (UniteItem item in GetList().Where(item => item.Id == id))
            {
                result = item.Code;
            }
            return result;
        }

        public static long GetId(string name)
        {
            long result = -1;
            foreach (UniteItem item in GetList().Where(item => item.Nom == name))
            {
                result = item.Id;
            }
            return result;
        }

        public static List<UniteItem> GetList()
        {
            var cart = new UniteCart();
            return cart.Unites;
        }

        public static List<string> GetListUnites()
        {
            return GetList().Select(item => item.Nom).ToList();
        }

        public static string GetName(long id)
        {
            string result = null;
            foreach (UniteItem item in GetList().Where(item => item.Id == id))
            {
                result = item.Nom;
            }
            return result;
        }

        public static bool Update(long id, string code, string nom)
        {
            var model = new UniteModel { Id = id, Code = code, Nom = nom };
            var repository = new UniteRepository();
            return repository.Update(model);
        }
    }

    public class UniteCart : IEnumerable<UniteItem>
    {
        public UniteCart()
        {
            Unites = new List<UniteItem>();
            var repository = new UniteRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (UniteItem element in repository.Unites())
            {
                UniteItem item = element;
                item.Rang = StdCalcul.DoubleToSpaceFormat(item.Id);
                Unites.Add(item);
            }
        }

        public List<UniteItem> Unites { get; set; }

        public IEnumerator<UniteItem> GetEnumerator()
        {
            return Unites.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class UniteItem
    {
        public bool DuplicateError { get; set; }

        public bool IsValid { get; set; }

        public string Rang { get; set; }

        public void Copy(UniteModel model)
        {
            Id = model.Id;
            Code = model.Code;
            Nom = model.Nom;
            DuplicateError = model.DuplicateError;
            Rang = model.Rang;
        }

        public void HasError()
        {
            if (Code == null)
            {
                IsValid = false;
            }
            if (Nom == null)
            {
                IsValid = false;
            }
        }
    }

    public class UniteModel
    {
        public UniteModel()
        {
            //
        }

        public UniteModel(UniteItem unite)
        {
            Copy(unite);
        }

        public string Code { get; set; }

        public bool DuplicateError { get; set; }

        public long Id { get; set; }

        public bool IsValid { get; set; }

        public string Nom { get; set; }

        public string Rang { get; set; }

        public void Copy(UniteItem item)
        {
            Id = item.Id;
            Code = item.Code;
            Nom = item.Nom;
            DuplicateError = item.DuplicateError;
            IsValid = item.IsValid;
            Rang = item.Rang;
        }
    }

    public class UniteRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.UniteItems.Count();
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

        public void Add(UniteItem unite)
        {
            _context.UniteItems.InsertOnSubmit(unite);
        }

        public bool Create(UniteModel model)
        {
            var unite = new UniteItem();
            model.Id = Count() + 1;
            unite.Copy(model);
            Add(unite);
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

        public void Delete(UniteItem unite)
        {
            _context.UniteItems.DeleteOnSubmit(unite);
        }

        public UniteItem Get(long id)
        {
            return _context.UniteItems.SingleOrDefault(d => d.Id == id);
        }

        public IQueryable<UniteItem> Unites()
        {
            return _context.UniteItems;
        }

        public bool Update(UniteModel model)
        {
            var item = Get(model.Id);
            item.Copy(model);
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
}