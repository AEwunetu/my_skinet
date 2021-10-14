using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(pdto => pdto.ProductBrand, opt => opt.MapFrom(p => p.ProductBrand.Name))
                .ForMember(pdto => pdto.ProductType, opt => opt.MapFrom(p => p.ProductType.Name))
                .ForMember(pdto => pdto.PictureUrl, opt => opt.MapFrom<ProductUrlResolver>());

            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}
