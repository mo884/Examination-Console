
namespace Examination.BL.CourseRep.Command.Reposoratory
{
    public class AddCourse : IAddCourse
    {
        public void Add(Course course)
        {
            if(course is Course) 
                DataBase.Courses.Add(course);
        }
    }
}
