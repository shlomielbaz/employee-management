using EM.Data;
using EM.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EM.Services
{
    public class TasksSerevice : ITasksSerevice
    {
        private readonly Repository<EMContext> db;

        public TasksSerevice(IRepository<EMContext> repository)
        {
            db = (Repository<EMContext>)repository;
        }
        public void Add(Domain.Entities.Task entity)
        {
            db.Add<EM.Domain.Entities.Task>(entity);

            db.Save();
        }

        public void Delete(long id)
        {
            var entity = this.Get(id);
            if (entity != null)
            {
                db.Delete<Domain.Entities.Task>(entity);
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

        public IEnumerable<EM.Domain.Entities.Task> Get()
        {
            return db.GetList<EM.Domain.Entities.Task>();
        }

        public EM.Domain.Entities.Task Get(long id)
        {
            return db.Get<EM.Domain.Entities.Task>(e => e.Id == id);
        }

        public IEnumerable<Domain.Entities.Task> GetBy(Expression<Func<Domain.Entities.Task, bool>> predicate)
        {
            return db.GetList<EM.Domain.Entities.Task>(predicate);
        }

        public void Update(EM.Domain.Entities.Task entity)
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
