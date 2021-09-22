using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Specification
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecificationParams productPrams)
            : base(x =>
                (string.IsNullOrEmpty(productPrams.Search) || x.Name.ToLower().Contains(productPrams.Search)) &&
                (!productPrams.BrandId.HasValue || x.ProductBrandId == productPrams.BrandId) &&
                (!productPrams.TypeId.HasValue || x.ProductTypeId == productPrams.TypeId)
            )
        {
        }
    }
}
