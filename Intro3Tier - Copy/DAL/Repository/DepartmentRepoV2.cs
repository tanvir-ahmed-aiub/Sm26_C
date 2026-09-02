using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    internal class DepartmentRepoV2 : IRepo<Department, int>
    {
        public bool Create(Department obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> Get()
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Department obj)
        {
            throw new NotImplementedException();
        }
        public bool CreateDepartment(Department s) { 
            return false;
        }
    }
}
