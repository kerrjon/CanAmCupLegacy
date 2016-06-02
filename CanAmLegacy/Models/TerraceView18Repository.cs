using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CanAmLegacy.Models
{ 
    public class TerraceView18Repository : ITerraceView18Repository
    {
        CanAmCupContext context = new CanAmCupContext();

        public IQueryable<TerraceView18> All
        {
            get { return context.TerraceView18; }
        }

        public IQueryable<TerraceView18> AllIncluding(params Expression<Func<TerraceView18, object>>[] includeProperties)
        {
            IQueryable<TerraceView18> query = context.TerraceView18;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public TerraceView18 Find(int id)
        {
            return context.TerraceView18.Find(id);
        }

        public void InsertOrUpdate(TerraceView18 terraceview18)
        {
            if (terraceview18.Id == default(int)) {
                // New entity
                context.TerraceView18.Add(terraceview18);
            } else {
                // Existing entity
                context.Entry(terraceview18).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var terraceview18 = context.TerraceView18.Find(id);
            context.TerraceView18.Remove(terraceview18);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ITerraceView18Repository
    {
        IQueryable<TerraceView18> All { get; }
        IQueryable<TerraceView18> AllIncluding(params Expression<Func<TerraceView18, object>>[] includeProperties);
        TerraceView18 Find(int id);
        void InsertOrUpdate(TerraceView18 terraceview18);
        void Delete(int id);
        void Save();
    }
}