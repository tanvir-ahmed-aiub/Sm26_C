using AutoMapper;
using BLL.Models;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class DepartmentService
    {
        DepartmentRepo repo;
        IMapper mapper;
        public DepartmentService(DepartmentRepo repo, IMapper mapper) { 
            this.repo = repo;
            this.mapper = mapper;
        }

        public List<DepartmentModel> All() {
            //call to DAL
            var data = repo.Get();
            var mapped = mapper.Map<List<DepartmentModel>>(data);
            //logic apply
            return mapped;
        }

        public List<DepartmentStudentModel> GetwithStudent() { 
            var data = repo.GetWithStudents();
            var mapped = mapper.Map<List<DepartmentStudentModel>>(data);
            return mapped;
        }

        public List<DepartmentInfo> GetDepartmentInfos() { 
            var data = repo.GetFullInfo();
            var mapped = mapper.Map<List<DepartmentInfo>>(data);
            return mapped;
        }
    }
}
