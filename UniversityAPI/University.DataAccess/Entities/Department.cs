using System.Collections.Generic;
using University.DataAccess.Entities;

namespace University.DataAccess
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
