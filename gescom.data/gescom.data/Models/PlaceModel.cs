using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class PlaceHelpers
    {
        public static bool Create(string code, string nom, int reserved)
        {
            var model = new PlaceModel { Code = code, Nom = nom, IsReserved = reserved };
            var repository = new PlaceRepository();
            return repository.Create(model);
        }

        public static void UpdateName(long id, string name)
        {
            var repo = new PlaceRepository();
            var item = repo.Get(id);
            item.Nom = name;
            repo.Update(new PlaceModel(item));
        }

        // place selon son identifiant id.
        public static PlaceItem Get(long id)
        {
            var reptory = new PlaceRepository();
            return reptory.Get(id);
        }

        public static string GetCode(int id)
        {
            return Get(id).Nom;
        }

        public static long GetId(string code)
        {
            long result = -1;
            foreach (PlaceItem item in GetList().Where(item => item.Code == code))
            {
                result = item.Id;
            }
            return result;
        }

        public static PlaceItem GetIndex(long id)
        {
            var result = new PlaceItem();
            foreach (PlaceItem item in GetList().Where(item => item.Id == id))
            {
                result = item;
            }
            return result;
        }

        public static List<PlaceItem> GetList()
        {
            var cart = new PlaceCart();
            return cart.Places;
        }

        public static List<string> GetListPlaces()
        {
            return GetList().Select(item => item.Combined).ToList();
        }

        public static string GetName(long id)
        {
            string result = null;
            foreach (PlaceItem item in GetList().Where(item => item.Id == id))
            {
                result = item.Nom;
            }
            return result;
        }

        public static void Reserve(long id)
        {
            var reptory = new PlaceRepository();
            var item = reptory.Get(id);
            item.IsReserved = 1;
            reptory.Save();
        }

        public static void Fill(long id)
        {
            var reptory = new PlaceRepository();
            var item = reptory.Get(id);
            item.Occupation = 1;
            reptory.Save();
        }

        public static bool Update(long id, string code, string nom, int reserved)
        {
            var model = new PlaceModel { Id = id, Code = code, Nom = nom, IsReserved = reserved };
            var repository = new PlaceRepository();
            return repository.Update(model);
        }
    }

    public class PlaceCart : IEnumerable<PlaceItem>
    {
        public PlaceCart()
        {
            Places = new List<PlaceItem>();
            var repository = new PlaceRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (PlaceItem element in repository.Places())
            {
                PlaceItem item = element;
                item.Combined = item.Code + " " + item.Nom;
                item.Rang = StdCalcul.DoubleToSpaceFormat(item.Id);
                item.Full = item.Occupation > 0;
                Places.Add(item);
            }
        }

        public List<PlaceItem> Places { get; set; }

        public IEnumerator<PlaceItem> GetEnumerator()
        {
            return Places.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class PlaceItem
    {
        public bool DuplicateError { get; set; }

        public bool Full { get; set; }

        public int Index { get; set; }

        public bool IsValid { get; set; }
        public string Combined { get; set; }

        public string Rang { get; set; }

        public void Copy(PlaceModel model)
        {
            Id = model.Id;
            Code = model.Code;
            Nom = model.Nom;
            IsReserved = model.IsReserved;
            DuplicateError = model.DuplicateError;
            Description = model.Description;
            Rang = model.Rang;
            Full = model.Full;
            Index = model.Index;
            Occupation = model.Occupation;
            Combined = model.Combined;
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

    public class PlaceModel
    {
        public PlaceModel()
        {
            //
        }

        public PlaceModel(PlaceItem place)
        {
            Copy(place);
        }

        public string Code { get; set; }

        public int Contenance { get; set; }

        public string Description { get; set; }

        public bool DuplicateError { get; set; }
        public string Combined { get; set; }

        public bool Full { get; set; }

        public long Id { get; set; }

        public int Index { get; set; }

        // true if reserved, false also
        public int IsReserved { get; set; }

        public bool IsValid { get; set; }

        public string Nom { get; set; }

        public long Numero { get; set; }

        public long Occupation { get; set; }

        public string Rang { get; set; }

        public void Copy(PlaceItem item)
        {
            Id = item.Id;
            Code = item.Code;
            Nom = item.Nom;
            if (item.IsReserved != null) IsReserved = (int)item.IsReserved;
            Description = item.Description;
            DuplicateError = item.DuplicateError;
            IsValid = item.IsValid;
            Rang = item.Rang;
            Full = item.Full;
            Occupation = item.Occupation;
            Index = item.Index;
            Combined = item.Combined;
        }
    }

    public class PlaceRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.PlaceItems.Count();
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

        public void Add(PlaceItem place)
        {
            _context.PlaceItems.InsertOnSubmit(place);
        }

        public bool Create(PlaceModel model)
        {
            var place = new PlaceItem
            {
                IsReserved = 0,
                Occupation = 0
            };
            model.Id = Count() + 1;
            place.Copy(model);
            Add(place);
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

        public void Delete(PlaceItem place)
        {
            _context.PlaceItems.DeleteOnSubmit(place);
        }

        public PlaceItem Get(long id)
        {
            PlaceItem item = _context.PlaceItems.SingleOrDefault(d => d.Id == id);
            if (item == null)
            {
                return null;
            }
            return item;
        }

        public IQueryable<PlaceItem> Places()
        {
            return _context.PlaceItems;
        }

        public bool Update(PlaceModel model)
        {
            PlaceItem item = Get(model.Id);
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