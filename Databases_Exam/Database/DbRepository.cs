using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_Exam
{
    public class DbRepository
    {
        private readonly StudentsDbContext _dbContext;
        public DbRepository()
        {
            _dbContext = new StudentsDbContext();
        }
        public void AddDepartment(Department department)
        {
            _dbContext.Departments.Add(department);
        }
        public void AddLecture(Lecture lecture)
        {
            _dbContext.Lectures.Add(lecture);
        }
        public void AddStudent(Student student)
        {
            _dbContext.Students.Add(student);
        }
        public List<Department> RetrieveDepartments()
        {
            return _dbContext.Departments.ToList();
        }
        public Department RetrieveDepartmentById(int id)
        {
            return _dbContext.Departments.First(x => x.Id == id);
        }
        public List<Lecture> RetrieveLectures()
        {
            return _dbContext.Lectures.ToList();
        }
        public Lecture RetrieveLectureById(int id)
        {
            return _dbContext.Lectures.First(x => x.Id == id);
        }
        public List<Student> RetrieveStudents()
        {
            return _dbContext.Students.ToList();
        }
        public Student RetrieveStudentById(int id)
        {
            return _dbContext.Students.First(x => x.Id == id);
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
