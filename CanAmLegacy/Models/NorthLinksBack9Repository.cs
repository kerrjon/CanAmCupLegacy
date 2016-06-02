using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CanAmLegacy.Models
{ 
    public class NorthLinksBack9Repository : INorthLinksBack9Repository
    {
        CanAmCupContext context = new CanAmCupContext();

        public IQueryable<NorthLinksBack9> All
        {
            get { return context.NorthLinksBack9; }
        }

        public IQueryable<NorthLinksBack9> AllIncluding(params Expression<Func<NorthLinksBack9, object>>[] includeProperties)
        {
            IQueryable<NorthLinksBack9> query = context.NorthLinksBack9;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public NorthLinksBack9 Find(int id)
        {
            return context.NorthLinksBack9.Find(id);
        }

        public void InsertOrUpdate(NorthLinksBack9 northlinksback9)
        {
            if (northlinksback9.Id == default(int)) {
                // New entity
                context.NorthLinksBack9.Add(northlinksback9);
            } else {
                // Existing entity
                context.Entry(northlinksback9).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var northlinksback9 = context.NorthLinksBack9.Find(id);
            context.NorthLinksBack9.Remove(northlinksback9);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface INorthLinksBack9Repository
    {
        IQueryable<NorthLinksBack9> All { get; }
        IQueryable<NorthLinksBack9> AllIncluding(params Expression<Func<NorthLinksBack9, object>>[] includeProperties);
        NorthLinksBack9 Find(int id);
        void InsertOrUpdate(NorthLinksBack9 northlinksback9);
        void Delete(int id);
        void Save();
    }
}