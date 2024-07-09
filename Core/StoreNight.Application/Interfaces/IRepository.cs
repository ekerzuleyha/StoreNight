﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreNight.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();

        Task CreateAsync (T entity);

        Task UpdateAsync (T entity);

        Task DeleteAsync (T id);

        Task<T> GetByIdAsync (int id);
        Task DeleteAsync(int ıd);
    }
}
