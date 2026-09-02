using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IDepartmentFeature
    {
        Department GetWithStudents(int id);
    }
}
