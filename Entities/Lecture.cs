using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public List<Department> Departments { get; set; }
        public Lecture(string name, int credits)
        {
            Name = name;
            Credits = credits;
            Departments = new List<Department>();
        }
    }
}
