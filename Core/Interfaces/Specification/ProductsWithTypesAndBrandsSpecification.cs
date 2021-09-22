using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Specification
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification(ProductSpecificationParams productPrams) 
            : base(x => 
                (string.IsNullOrEmpty(productPrams.Search) || x.Name.ToLower().Contains(productPrams.Search)) &&
                (!productPrams.BrandId.HasValue || x.ProductBrandId == productPrams.BrandId) &&
                (!productPrams.TypeId.HasValue || x.ProductTypeId == productPrams.TypeId)
            )
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);

            if (!string.IsNullOrEmpty(productPrams.Sort))
            {
                switch (productPrams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDesending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(p => p.Name);
                        break;
                }
            }
            else
            {
                AddOrderBy(x => x.Name);
            }

            ApplyPaging(productPrams.PageSize * (productPrams.PageIndex - 1), productPrams.PageSize);
        }
        public ProductsWithTypesAndBrandsSpecification(int id) : base(p => p.Id == id) 
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }
    }
}
