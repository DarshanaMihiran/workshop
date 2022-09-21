using System;
using System.Collections.Generic;
using System.Text;
using University.DataAccess.Entities;

namespace University.Repository.IRepositories
{
    public interface IStudentRepository
    {
        public List<Student> GetAllStudents();
        public void AddStudent(StudentRequestModel student);
    }
}
