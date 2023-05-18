﻿using Domain.Common;
using Domain.Models;

namespace Repository.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int? id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

        Task<IEnumerable<T>> Search(string? name);
        Task<IEnumerable<T>> CountrySearch(string? name);
    }
}
