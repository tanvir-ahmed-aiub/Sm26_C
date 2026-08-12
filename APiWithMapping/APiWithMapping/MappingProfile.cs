using APiWithMapping.EF.Tables;
using APiWithMapping.Models;
using AutoMapper;

namespace APiWithMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Department,DepartmentModel>().ReverseMap();
        }
    }
}
