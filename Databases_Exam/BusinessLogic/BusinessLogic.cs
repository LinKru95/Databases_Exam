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
        public void ShowDepartments()
        {
            Console.WriteLine("Department's ID, Name:");
            foreach (var department in _repository.RetrieveDepartments())
            {
                Console.WriteLine($"{department.Id}, {department.Name}");
            }            
        }
        public void ShowLectures()
        {
            Console.WriteLine("Lecture's ID, Name, No. of credits:");
            foreach (var lecture in _repository.RetrieveLectures())
            {
                Console.WriteLine($"{lecture.Id}, {lecture.Name}, {lecture.Credits}");
            }
        }
        public void ShowStudents()
        {
            Console.WriteLine("Student's ID, Name, Age:");
            foreach (var student in _repository.RetrieveStudents())
            {
                Console.WriteLine($"{student.Id}, {student.Name}, {student.Age}");
            }
        }
        public void AssignDepartmentToLecture(int departmentId, int lectureId)
        {
            Department department = _repository.RetrieveDepartmentById(departmentId);
            Lecture lecture = _repository.RetrieveLectureById(lectureId);

            lecture.Departments.Add(department);

            _repository.SaveChanges();
        }
    }
}
