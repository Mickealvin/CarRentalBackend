﻿using CarRental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null, int? take = null, int? skip = null);
        Task<T> GetById(int Id);
        Task Insert(T entity);
        void Update(T entity);
        Task Delete(int Id);
    }
}
