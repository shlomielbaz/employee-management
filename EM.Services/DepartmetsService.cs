using EM.Data;
using EM.Domain.Entities;
using EM.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EM.Services
{
    public class DepartmetsService : IDepartmetsService
    {
        private readonly Repository<EMContext> db;

        public DepartmetsService(IRepository<EMContext> repository)
        {
            db = (Repository<EMContext>)repository;
        }

        public void Add(Department entity)
        {
            try
            {
                db.Add<Department>(entity);

                db.Save();
            } 
            catch(Exception)
            {
                throw;
            }
        }

        public void Delete(long id)
        {
            var entity = this.Get(id);
            if (entity != null)
            {
                db.Delete<Department>(entity);
            }
            else
            {
                throw new Exception("The item you ment to delete dosen't exist");
            }
        }

        public bool Exists(long id)
        {
            return this.Get(id) != null;
        }

        public IEnumerable<Department> Get()
        {
            return db.GetList<Department>();
        }

        public Department Get(long id)
        {
            return db.Get<Department>(e => e.Id == id);
        }

        public IEnumerable<Department> GetBy(Expression<Func<Department, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Department entity)
        {
            try
            {
                db.Update(entity);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

        }
    }
}
