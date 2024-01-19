namespace Examination.DAL.Entities.Courses
{
    public class Course
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double FinalDegree { get; set; }
        //Navigation Property
        public List<Exam> Exams { get; set; } = new List<Exam>();
        public List<Student> students { get; set; } = new List<Student>();


    }
}
