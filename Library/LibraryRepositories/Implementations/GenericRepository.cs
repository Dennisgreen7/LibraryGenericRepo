using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDb
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _context;
        private DbSet<T> _entities;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public virtual void Add(T entity)
        {
            try
            {
                _context.Add(entity);
                Save();
            }
            catch
            {
                return;
            }
        }
        public virtual List<T> Filter(int selectedFilter, string value)
        {
            return null;
        }

        public List<T> Find(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _context.Set<T>().Where(predicate).ToList<T>();
            }
            catch
            {
                return null;
            }
        }

        public virtual List<T> GetAll()
        {
            try
            {
                return _entities.ToList<T>();

            }
            catch
            {
                return null;
            }
        }

        public T GetById(int id)
        {
            T entity = _entities.Find(id);
            if (entity != null)
            {
                return entity;
            }
            return null;
        }

        public virtual bool Remove(int id)
        {
            T entity = _entities.Find(id);
            if(entity != null) 
            {
                _context.Remove(entity);
                Save();
                return true;
            }
            return false;
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }

            catch
            {
                return;
            }
        }

        public void Update(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                Save();
            }
            catch
            {
                return;
            }
        }
    }
}
