using System;
using System.Collections.Generic;
using System.Text;
using University.DataAccess.Entities;

namespace University.Manager.IMangers
{
    public interface IStudentManager
    {
        public List<Student> GetAllStudents();
        public void AddStudent(StudentRequestModel student);
    }
}
