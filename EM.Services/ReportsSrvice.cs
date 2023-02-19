using EM.Data;
using EM.Domain.Entities;
using EM.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EM.Services
{
    public class ReportsSrvice : IReportsSrvice
    {
        private readonly Repository<EMContext> db;

        public ReportsSrvice(IRepository<EMContext> repository)
        {
            db = (Repository<EMContext>)repository;
        }
        public void Add(Report entity)
        {
            db.Add<Report>(entity);

            db.Save();
        }

        public void Delete(long id)
        {
            var entity = this.Get(id);
            if (entity != null)
            {
                db.Delete<Report>(entity);
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

        public IEnumerable<Report> Get()
        {
            return db.GetList<Report>().ToList();
        }

        public Report Get(long id)
        {
            return db.Get<Report>(e => e.Id == id);
        }

        public IEnumerable<Report> GetBy(Expression<Func<Report, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Report entity)
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
