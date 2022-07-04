using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_Exam
{
    public class BusinessLogic
    {
        private readonly DbRepository _repository;
        public BusinessLogic()
        {
            _repository = new DbRepository();
        }
        public void CreateDepartment(string name)
        {
            var department = new Department(name);

            _repository.AddDepartment(department);
            _repository.SaveChanges();
        }
        public void CreateLecture(string name, int credits)
        {
            var lecture = new Lecture(name, credits);

            _repository.AddLecture(lecture);
            _repository.SaveChanges();
        }
        public void CreateStudent(string name, int age)
        {
            var student = new Student(name, age);

            _repository.AddStudent(student);
            _repository.SaveChanges();
        }
    }
}
