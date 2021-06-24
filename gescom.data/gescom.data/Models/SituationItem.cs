using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace gescom.data.Models
{
    public static class SituationHelpers
    {
      

        public static bool Create(long id)
        {
            var model = new SituationModel { Id = id };
            var repository = new SituationRepository();
            return repository.Create(model);
        }

        // unite selon son identifiant id.
        public static SituationItem Get(long id)
        {
            var result = new SituationItem();
            foreach (SituationItem item in GetList().Where(item => item.Id == id))
            {
                result = item;
            }
            return result;
        }
       

        public static List<SituationItem> GetList()
        {
            var cart = new SituationCart();
            return cart.Situations;
        }

      
        public static bool Update(long id, string cce, string frns)
        {
            var model = new SituationModel { Id = id, Commerce = cce, Fournisseur = frns };
            var repository = new SituationRepository();
            return repository.Update(model);
        }
    }

    public class SituationCart : IEnumerable<SituationItem>
    {
        public SituationCart()
        {
            Situations = new List<SituationItem>();
            var repository = new SituationRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (SituationItem element in repository.Situations())
            {
                SituationItem item = element;                
                Situations.Add(item);
            }
        }

        public List<SituationItem> Situations { get; set; }

        public IEnumerator<SituationItem> GetEnumerator()
        {
            return Situations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class SituationItem
    {
      
        public void Copy(SituationModel model)
        {
            Id = model.Id;
            Commerce = model.Commerce;
            Fournisseur = model.Fournisseur;
        }

        public void HasError()
        {

        }
    }

    public class SituationModel
    {
        public long Id { get; set; }
        public string Commerce { get; set; }
        public string Fournisseur { get; set; }
        public SituationModel()
        {
            //
        }

        public SituationModel(SituationItem unite)
        {
            Copy(unite);
        }

    
        public void Copy(SituationItem item)
        {
            Id = item.Id;
            Commerce = item.Commerce;
            Fournisseur = item.Fournisseur;
        }
    }

    public class SituationRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.SituationItems.Count();
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

        public void Add(SituationItem unite)
        {
            _context.SituationItems.InsertOnSubmit(unite);
        }

        public bool Create(SituationModel model)
        {
            var unite = new SituationItem();
            //model.Id = Count() + 1;
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

        public void Delete(SituationItem unite)
        {
            _context.SituationItems.DeleteOnSubmit(unite);
        }

        public SituationItem Get(long id)
        {
            return _context.SituationItems.SingleOrDefault(d => d.Id == id);
        }

        public IQueryable<SituationItem> Situations()
        {
            return _context.SituationItems;
        }

        public bool Update(SituationModel model)
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