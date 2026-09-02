using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;

namespace BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Department,DepartmentModel>().ReverseMap();
            CreateMap<Department, DepartmentStudentModel>();
            CreateMap<Student, StudentModel>();
            CreateMap<Department,DepartmentInfo>()
                .ForMember(d=>d.CountCourses,
                           s=>s.MapFrom(s=>s.Courses.Count))
                .ForMember(d => d.CountStudents,
                           s => s.MapFrom(s => s.Students.Count));
        }
    }
}
