using DAL.EF;
using DAL.EF.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class DepartmentRepo
    {
        Sm26CContext db;
        public DepartmentRepo(Sm26CContext db) { 
            this.db = db;
        }
        public List<Department> Get() { 
            return db.Departments.ToList();
        }
        public bool Create(Department d) { 
            //create d in db
            db.Departments.Add(d);
            return db.SaveChanges() > 0;
        }
        public Department Get(int id) {
            return db.Departments.Find(id);
        }
        public List<Department> GetWithStudents() {
            var data = db.Departments
                .Include(d => d.Students)
                .ToList();
            return data;
        }
        public List<Department> GetFullInfo() {
            var data = db.Departments
                .Include(d => d.Students)
                .Include(d => d.Courses)
                .ToList();
            return data;
        }
    }
}
