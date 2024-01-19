
namespace Examination.BL.CourseRep.Command.Reposorator
{
    public class AddStudentRep : IAddStudentRep
    {
        public void Add(Student student, int CourseID)
        {
            if(student is Student)
            {
                Course? data = DataBase.Courses?.Where(c => c.Id == CourseID).FirstOrDefault();
                data.students.Add(student);
            }
          
        }
    }
}
