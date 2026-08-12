using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class StudentModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public double Cgpa { get; set; }

        public int DeptId { get; set; }
    }
}
