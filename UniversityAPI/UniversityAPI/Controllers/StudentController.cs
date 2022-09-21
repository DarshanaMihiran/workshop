using Microsoft.AspNetCore.Mvc;
using University.DataAccess.Entities;
using University.Manager.IMangers;

namespace UniversityAPI.Controllers
{
    [ApiController]
    [Route("V1/[controller]s")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentManager _studentManager;
        public StudentController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentManager.GetAllStudents());
        }

        [HttpPost]
        public IActionResult Post(StudentRequestModel student)
        {
            _studentManager.AddStudent(student);
            return Ok();
        }
    }
}
