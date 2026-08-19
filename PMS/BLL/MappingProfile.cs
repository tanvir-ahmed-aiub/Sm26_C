using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;

namespace BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Customer,CustomerModel>().ReverseMap();
            CreateMap<Product,ProductModel>().ReverseMap();
        }
    }
}
