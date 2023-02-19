﻿using EM.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace EM.Domain.Interfaces
{
    public interface ICrudService<T> where T : BaseEntity, new()
    {
        public IEnumerable<T> Get();
        public T Get(long id);
        public void Update(T entity);
        public void Add(T entity);
        public void Delete(long id);
        public bool Exists(long id);
        public IEnumerable<T> GetBy(Expression<Func<T, bool>> predicate);
    }
}
