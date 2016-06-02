using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CanAmLegacy.Models
{ 
    public class NorthLinksFront9Repository : INorthLinksFront9Repository
    {
        CanAmCupContext context = new CanAmCupContext();

        public IQueryable<NorthLinksFront9> All
        {
            get { return context.NorthLinksFront9; }
        }

        public IQueryable<NorthLinksFront9> AllIncluding(params Expression<Func<NorthLinksFront9, object>>[] includeProperties)
        {
            IQueryable<NorthLinksFront9> query = context.NorthLinksFront9;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public NorthLinksFront9 Find(int id)
        {
            return context.NorthLinksFront9.Find(id);
        }

        public void InsertOrUpdate(NorthLinksFront9 northlinksfront9)
        {
            if (northlinksfront9.Id == default(int)) {
                // New entity
                context.NorthLinksFront9.Add(northlinksfront9);
            } else {
                // Existing entity
                context.Entry(northlinksfront9).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var northlinksfront9 = context.NorthLinksFront9.Find(id);
            context.NorthLinksFront9.Remove(northlinksfront9);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface INorthLinksFront9Repository
    {
        IQueryable<NorthLinksFront9> All { get; }
        IQueryable<NorthLinksFront9> AllIncluding(params Expression<Func<NorthLinksFront9, object>>[] includeProperties);
        NorthLinksFront9 Find(int id);
        void InsertOrUpdate(NorthLinksFront9 northlinksfront9);
        void Delete(int id);
        void Save();
    }
}