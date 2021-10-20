using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : IGenericDal<Comment>
    {
        public void Insert(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment entity)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        Comment IGenericDal<Comment>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
