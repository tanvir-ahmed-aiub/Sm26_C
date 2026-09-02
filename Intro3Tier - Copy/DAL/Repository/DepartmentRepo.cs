using DAL.EF;
using DAL.EF.Tables;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    internal class DepartmentRepo : IRepo<Department,int>, IDepartmentFeature
    {
        Sm26CContext db;
        public DepartmentRepo(Sm26CContext db) { 
            this.db = db;
        }

        public bool Create(Department obj)
        {
            db.Departments.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> Get()
        {
            return db.Departments.ToList();
        }

        public Department Get(int id)
        {
            return db.Departments.Find(id);
        }

        public bool Update(Department obj)
        {
            throw new NotImplementedException();
        }

        public Department GetWithStudents(int id) {
            var data = (from d in db.Departments.Include(d => d.Students)
                       where d.Id == id
                       select d).FirstOrDefault();
            return data;
        }
    }
}
