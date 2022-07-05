using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_Exam
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
        public List<Lecture> Lectures { get; set; }
        private Student() 
        {
            Lectures = new List<Lecture>();
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Lectures = new List<Lecture>();
        }
    }
}
