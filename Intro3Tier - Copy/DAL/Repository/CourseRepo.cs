using DAL.EF;
using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    internal class CourseRepo : IRepo<Course,int>
    {
        Sm26CContext db;
        public CourseRepo(Sm26CContext db) { 
            this.db = db;
        }

        public bool Create(Course obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> Get()
        {
            throw new NotImplementedException();
        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Course obj)
        {
            throw new NotImplementedException();
        }
    }
}
