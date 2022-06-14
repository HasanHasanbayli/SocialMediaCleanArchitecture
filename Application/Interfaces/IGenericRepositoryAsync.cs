﻿namespace Application.Interfaces;

public interface IGenericRepositoryAsync<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    
    Task<IReadOnlyList<T>> GetAllAsync();
    
    Task<IReadOnlyList<T>> GetPagedResponseAsync(int pageNumber, int pageSize);
    
    Task<T> AddAsync(T entity);
    
    Task UpdateAsync(T entity);
    
    Task DeleteAsync(T entity);
}