namespace University.DataAccess.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set;}
        public int StudentAge { get; set;}

        public virtual Department Department { get; set; }
    }
}
