using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;

namespace gescom.data.Models
{
    public static class EventsHelper
    {
        public static void UpdateOnBuy(long id, long pid)
        {
            var repository = new EventsRepository();
            EventsItem item = repository.Get(id);
            if (item == null) return;
            item.Da = DateTime.Now;
            item.Vid = pid;
            repository.Save();
        }

        public static void UpdateOnSold(long id, long pid)
        {
            var repository = new EventsRepository();
            EventsItem item = repository.Get(id);
            if (item == null) return;
            item.Dv = DateTime.Now;
            item.Cid = pid;
            repository.Save();
        }
    }

    public class EventsCart : IEnumerable<EventsItem>
    {
        public EventsCart()
        {
            Events = new List<EventsItem>();
            var repository = new EventsRepository();
            int count = repository.Count();
            if (count == 0)
            {
                return;
            }
            foreach (EventsItem element in repository.Events())
            {
                EventsItem item = element;
                Events.Add(item);
            }
        }

        public List<EventsItem> Events { get; set; }

        public IEnumerator<EventsItem> GetEnumerator()
        {
            return Events.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public partial class EventsItem
    {
        public void Copy(EventsModel model)
        {
            Id = model.Id;
            Vid = model.Vid;
            Cid = model.Cid;
            Da = model.Da;
            Dv = model.Dv;
        }
    }

    public class EventsModel
    {
        public EventsModel()
        {
            Init();
        }

        public long Cid { get; set; }

        public DateTime Da { get; set; }

        public DateTime Dv { get; set; }

        public long Id { get; set; }

        public long Vid { get; set; }

        public void Copy(EventsItem item)
        {
            Id = item.Id;
            if (item.Dv != null) Dv = (DateTime)item.Dv;
            if (item.Da != null) Da = (DateTime)item.Da;
            if (item.Vid != null) Vid = (long)item.Vid;
            if (item.Cid != null) Cid = (long)item.Cid;
        }

        private void Init()
        {
            Vid = -1;
            Cid = -1;
            Dv = DateTime.Now;
            Da = DateTime.Now;
        }
    }

    public class EventsRepository : IData
    {
        private readonly DataGescomDataContext _context = new DataGescomDataContext();

        public int Count()
        {
            return _context.EventsItems.Count();
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

        public void Add(EventsItem item)
        {
            _context.EventsItems.InsertOnSubmit(item);
        }

        public bool Create(EventsModel model)
        {
            var item = new EventsItem();
            item.Copy(model);
            Add(item);
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

        public void Delete(EventsItem item)
        {
            _context.EventsItems.DeleteOnSubmit(item);
        }

        public IQueryable<EventsItem> Events()
        {
            return _context.EventsItems;
        }

        public EventsItem Get(long id)
        {
            return _context.EventsItems.SingleOrDefault(d => d.Id == id);
        }

        public bool Update(EventsModel model)
        {
            EventsItem item = Get(model.Id);
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