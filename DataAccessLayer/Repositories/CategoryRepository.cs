using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        private readonly Context _context = new();
        public List<Category> ListAllCategories()
        {
            return _context.Categories.ToList();
        }

        public void AddCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Insert(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
