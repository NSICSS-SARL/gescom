using System;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class FamilleHelpers
    {
        public static bool Create(string code, string nom)
        {
            var model = new FamilleModel { Code = code, Nom = nom };
            var repository = new FamilleRepository();
            return repository.Create(model);
        }

        public static FamilleItem Get(long id)
        {
            var result = new FamilleItem();
            foreach (FamilleItem item in GetList().Where(item => item.Id == id))
            {
                result = item;
            }
            return result;
        }

        public static string GetCode(long id)
        {
            string result = null;
            foreach (FamilleItem item in GetList().Where(item => item.Id == id))
            {
                result = item.Code;
            }
            return result;
        }
        
        public static List<FamilleItem> GetList()
        {
            var cart = new DataGescomDataContext();
            return cart.FamilleItems.ToList();
        }

        public static List<string> GetListFamilles()
        {
            return GetList().Select(item => item.Nom).ToList();
        }

        public static string GetName(long id)
        {
            string result = null;
            foreach (FamilleItem item in GetList().Where(item => item.Id == id))
            {
                result = item.Nom;
            }
            return result;
        }

        public static bool Update(long id, string code, string nom)
        {
            var model = new FamilleModel { Id = id, Code = code, Nom = nom };
            var repository = new FamilleRepository();
            return repository.Update(model);
        }
    }

    public partial class FamilleItem
    {
        public bool DuplicateError { get; set; }

        public bool IsValid { get; set; }

        public string Rang { get; set; }

        public void Copy(FamilleModel model)
        {
            Id = model.Id;
            Code = model.Code;
            Nom = model.Nom;
            DuplicateError = model.DuplicateError;
            Rang = model.Rang;
        }

       
    }

    public class FamilleModel
    {
        public FamilleModel()
        {
            //
        }

       
        public string Code { get; set; }

        public bool DuplicateError { get; set; }

        public long Id { get; set; }

        public bool IsValid { get; set; }

        public string Nom { get; set; }

        public string Rang { get; set; }

       
    }

    public class FamilleRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public void Add(FamilleItem famille)
        {
            _context.FamilleItems.InsertOnSubmit(famille);
        }

        public int Count()
        {
            return _context.FamilleItems.Count();
        }

        public bool Create(FamilleModel model)
        {
            var famille = new FamilleItem();
            model.Id = Count() + 1;
            famille.Copy(model);
            Add(famille);
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

        
        public FamilleItem Get(long id)
        {
            return _context.FamilleItems.SingleOrDefault(d => d.Id == id);
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

        public bool Update(FamilleModel model)
        {
            FamilleItem item = Get(model.Id);
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