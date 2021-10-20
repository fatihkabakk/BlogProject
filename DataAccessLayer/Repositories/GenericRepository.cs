using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Insert(T entity)
        {
            using Context context = new();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using Context context = new();
            context.Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            using Context context = new();
            context.Update(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using Context context = new();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using Context context = new();
            return context.Set<T>().Find(id);
        }
    }
}
