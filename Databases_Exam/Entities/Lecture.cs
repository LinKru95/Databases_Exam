using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_Exam
{
    public class Lecture : BaseEntity
    {
        public int Credits { get; set; }
        public List<Department> Departments { get; set; }
        public List<Student> Students { get; set; }
        private Lecture() 
        {
            Departments = new List<Department>();
        }
        public Lecture(string name, int credits)
        {
            Name = name;
            Credits = credits;
            Departments = new List<Department>();
        }
    }
}
