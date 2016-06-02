using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CanAmLegacy.Models
{ 
    public class HoleStatusRepository : IHoleStatusRepository
    {
        CanAmCupContext context = new CanAmCupContext();

        public IQueryable<HoleStatus> All
        {
            get { return context.HoleStatus; }
        }

        public IQueryable<HoleStatus> AllIncluding(params Expression<Func<HoleStatus, object>>[] includeProperties)
        {
            IQueryable<HoleStatus> query = context.HoleStatus;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public HoleStatus Find(int id)
        {
            return context.HoleStatus.Find(id);
        }

        public void InsertOrUpdate(HoleStatus holestatus)
        {
            if (holestatus.Id == default(int)) {
                // New entity
                context.HoleStatus.Add(holestatus);
            } else {
                // Existing entity
                context.Entry(holestatus).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var holestatus = context.HoleStatus.Find(id);
            context.HoleStatus.Remove(holestatus);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IHoleStatusRepository
    {
        IQueryable<HoleStatus> All { get; }
        IQueryable<HoleStatus> AllIncluding(params Expression<Func<HoleStatus, object>>[] includeProperties);
        HoleStatus Find(int id);
        void InsertOrUpdate(HoleStatus holestatus);
        void Delete(int id);
        void Save();
    }
}