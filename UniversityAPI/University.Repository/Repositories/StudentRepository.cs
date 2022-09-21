using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.DataAccess;
using University.DataAccess.Entities;
using University.Repository.IRepositories;

namespace University.Repository.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly UniversityContext _universityContext;

        public StudentRepository(UniversityContext universityContext)
        {
            _universityContext = universityContext;
        }

        public List<Student> GetAllStudents()
        {
            return _universityContext.Students.ToList();
        }

        public void AddStudent(StudentRequestModel student)
        {
            var std = new Student
            {
                StudentName = student.StudentName,
                StudentAge = student.StudentAge
            };
            _universityContext.Students.Add(std);
            _universityContext.SaveChanges();
        }
    }
}
