using Core.Entities;
using Core.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T>
    {
        public Task<T> GetByIdAsync(int id);
        public Task<IReadOnlyList<T>> ListAllAsync();
        public Task<T> GetEntityWithSpecification(ISpecification<T> specification);
        public Task<IReadOnlyList<T>> ListAsync(ISpecification<T> specification);
    }
}
