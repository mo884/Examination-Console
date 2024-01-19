
namespace Examination.BL.CourseRep.Quieries.Reposoratory
{
    public class GetStudentByID : IGetStudentByID
    {
        public Student? getById(int studentid, int courseid)
        {
          Course? course =  DataBase.Courses.Where(course => course.Id == courseid).FirstOrDefault();
            return course?.students?.Where(student => student.Id == studentid)?.FirstOrDefault();
        }
    }
}
