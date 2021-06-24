using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class DistHelpers
    {
        public static DistItem Get(long id)
        {
            var reptory = new DistRepository();
            return reptory.Get(id);
        }

        public static long GetId(string name)
        {
            long result = -1;
            foreach (DistItem item in GetList().Where(item => item.Nom == name))
            {
                result = item.Id;
            }
            return result;
        }

        public static int CountPlace(long id)
        {
            return GetList().Count(item => item.Numero == id);
        }

        public static List<DistItem> GetList()
        {
            var cart = new DistCart();
            return cart.Dists;
        }

        public static List<string> GetListDists()
        {
            return GetList().Select(item => item.Nom).ToList();
        }

        public static string GetName(long id)
        {
            string result = null;
            foreach (DistItem item in GetList().Where(item => item.Id == id))
            {
                result = item.Nom;
            }
            return result;
        }

        public static long GetPlaceNumber(long id)
        {
            long result = -1;
            foreach (DistItem item in GetList().Where(item => item.Id == id))
            {
                if (item.Numero != null) result = (long)item.Numero;
            }
            return result;
        }

        public static void PutDescription(long id, string text)
        {
            var repository = new DistRepository();
            DistItem item = repository.Get(id);
            if (string.IsNullOrEmpty(text))
            {
                return;
            }
            item.Description = text;
            repository.Save();
        }

        public static bool Update(DistItem item)
        {
            var model = new DistModel();
            model.Copy(item);
            var repository = new DistRepository();
            return repository.Update(model);
        }
    }

    public class DistCart : IEnumerable<DistItem>
    {
        public DistCart()
        {
            Dists = new List<DistItem>();
            var repository = new DistRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (DistItem element in repository.Dists())
            {
                DistItem item = element;
                Dists.Add(item);
            }
        }

        public List<DistItem> Dists { get; set; }

        public IEnumerator<DistItem> GetEnumerator()
        {
            return Dists.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class DistItem
    {
        public bool DuplicateError { get; set; }

        public bool IsValid { get; set; }

        public string Place { get; set; }

        public void Copy(DistModel model)
        {
            Id = model.Id;
            Nom = model.Nom;
            Numero = model.Numero;
            DuplicateError = model.DuplicateError;
            Description = model.Description;
            Place = model.Place;
            Quantite = model.Quantite;
        }
    }

    public class DistModel
    {
        public string Description { get; set; }

        public bool DuplicateError { get; set; }

        public long Id { get; set; }

        public bool IsValid { get; set; }

        public string Nom { get; set; }

        public long Numero { get; set; }

        public string Place { get; set; }

        public float Quantite { get; set; }

        public void Copy(DistItem item)
        {
            Id = item.Id;
            Nom = item.Nom;
            if (item.Numero != null) Numero = (long)item.Numero;
            DuplicateError = item.DuplicateError;
            Description = item.Description;
            Place = item.Place;
            if (item.Quantite != null) Quantite = (float)item.Quantite;
        }

        public void HasError()
        {
            if (Nom == null)
            {
                IsValid = false;
            }
        }
    }

    public class DistRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.DistItems.Count();
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

        public void Add(DistItem dist)
        {
            _context.DistItems.InsertOnSubmit(dist);
        }

        public bool Create(DistModel model)
        {
            var dist = new DistItem();
            model.Id = Count() + 1;
            dist.Copy(model);
            Add(dist);
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

        public void Delete(DistItem dist)
        {
            _context.DistItems.DeleteOnSubmit(dist);
        }

        public IQueryable<DistItem> Dists()
        {
            return _context.DistItems;
        }

        public DistItem Get(long id)
        {
            return _context.DistItems.SingleOrDefault(d => d.Id == id);
        }

        public bool Update(DistModel model)
        {
            DistItem item = Get(model.Id);
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