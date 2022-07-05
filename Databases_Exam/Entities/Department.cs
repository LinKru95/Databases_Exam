using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_Exam
{
    public class Department : BaseEntity
    {
        public List<Student> Students { get; set; }
        public List<Lecture> Lectures { get; set; }
        private Department() 
        {
            Students = new List<Student>();
            Lectures = new List<Lecture>();
        }
        public Department(string name)
        {
            Name = name;
            Students = new List<Student>();
            Lectures = new List<Lecture>();
        }
    }
}
