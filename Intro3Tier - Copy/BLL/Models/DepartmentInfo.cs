using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class DepartmentInfo : DepartmentModel
    {
        public int CountStudents { get; set; }
        public int CountCourses { get; set; }
    }
}
