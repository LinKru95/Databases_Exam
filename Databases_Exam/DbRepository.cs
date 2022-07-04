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
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
