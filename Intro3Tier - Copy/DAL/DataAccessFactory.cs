using DAL.EF;
using DAL.EF.Tables;
using DAL.Interfaces;
using DAL.Repository;

namespace DAL
{
    public class DataAccessFactory
    {
        Sm26CContext db;
        public DataAccessFactory(Sm26CContext db) {
            this.db = db;
        }
        public IRepo<Department,int> DepartmentData() {
            return new DepartmentRepo(db);
        }
        public IDepartmentFeature DepartmentFeature()
        {
            return new DepartmentRepo(db);
        }
        public IRepo<Course, int> CourseData() { 
            return new CourseRepo(db);
        }
    }
}
