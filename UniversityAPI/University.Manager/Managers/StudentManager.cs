using System;
using System.Collections.Generic;
using System.Text;
using University.DataAccess.Entities;
using University.Manager.IMangers;
using University.Repository.IRepositories;

namespace University.Manager.Managers
{
    public class StudentManager : IStudentManager
    {
        private readonly IStudentRepository _studentRepository;

        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public void AddStudent(StudentRequestModel student)
        {
            _studentRepository.AddStudent(student);
        }
    }
}
