using Core.Interfaces.Specification;
using System.Collections.Generic;
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
