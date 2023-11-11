﻿
using Logistica.Domain.Entities;

namespace Logistica.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(T entity);

        public Task<T> Get(Guid id, CancellationToken cancellationToken);
        public Task<T> GetAll(CancellationToken cancellationToken);
    }
}
