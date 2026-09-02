using AutoMapper;
using BLL.Models;
using DAL;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class DepartmentService
    {
        DataAccessFactory factory;
        IMapper mapper;
        public DepartmentService(DataAccessFactory factory, IMapper mapper) { 
            this.factory = factory;
            this.mapper = mapper;
        }

        public List<DepartmentModel> All() {
            //call to DAL
            var data = factory.DepartmentData().Get();
            var mapped = mapper.Map<List<DepartmentModel>>(data);
            //logic apply
            return mapped;
        }

        public List<DepartmentStudentModel> GetwithStudent()
        {
            var data = factory.DepartmentFeature().GetWithStudents(1);
            var mapped = mapper.Map<List<DepartmentStudentModel>>(data);
            return mapped;
        }

        //public List<DepartmentInfo> GetDepartmentInfos() { 
        //    var data = repo.GetFullInfo();
        //    var mapped = mapper.Map<List<DepartmentInfo>>(data);
        //    return mapped;
        //}
    }
}
