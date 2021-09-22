using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Interfaces.Specification
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get; }
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        public Expression<Func<T, object>> OrderBy { get; private set; }

        public Expression<Func<T, object>> OrderByDesending { get; private set; }

        public int Take { get; private set; }

        public int Skip { get; private set; }

        public bool IsPagingEnabled { get; private set; }

        public BaseSpecification() 
        {
        }

        public BaseSpecification(Expression<Func<T, bool>> criteria) 
        {
            Criteria = criteria;
        }

        protected void AddInclude(Expression<Func<T, object>> includeExpression) 
        {
            Includes.Add(includeExpression);
        }

        protected void AddOrderBy(Expression<Func<T, object>> orderByExpression) 
        {
            OrderBy = orderByExpression;
        }

        protected void AddOrderByDesending(Expression<Func<T, object>> orderByDesendingExpression) 
        {
            OrderByDesending = orderByDesendingExpression;
        }

        protected void ApplyPaging(int skip, int take) 
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }
    }
}
