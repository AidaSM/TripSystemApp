using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TripSystemApp.Interfaces;
using TripSystemApp.Models;
using TripSystemApp.Helpers;

namespace TripSystemApp.DataAccess
{
    public class GenericRepository<TEntity> : Subject ,IRepository<TEntity> where TEntity : class
    {
        protected readonly TravelDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(TravelDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();

            NotifyAll(this, EventArgs.Empty);
        }

        public IEnumerable<TEntity> GetAll() 
        {
            return _dbSet.ToList(); 
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

            NotifyAll(this, EventArgs.Empty);
        }
        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
            NotifyAll(this, EventArgs.Empty);
        }
        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();

                NotifyAll(this, EventArgs.Empty);
            }
        }
    }
}
