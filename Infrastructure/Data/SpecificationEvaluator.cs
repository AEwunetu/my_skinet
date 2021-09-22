using Core.Entities;
using Core.Interfaces.Specification;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<T> where T : BaseEntity
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification) 
        {
            var query = inputQuery;

            if (specification.Criteria != null) 
            {
                query = query.Where(specification.Criteria);
            }

            if (specification.OrderBy != null) 
            {
                query = query.OrderBy(specification.OrderBy);
            }

            if (specification.OrderByDesending != null) 
            {
                query = query.OrderByDescending(specification.OrderByDesending);
            }

            if (specification.IsPagingEnabled) 
            {
                query = query.Skip(specification.Skip).Take(specification.Take);
            }

            query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}
