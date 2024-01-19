

namespace Examination.BL.CourseRep.Quieres.Reposoratory
{
    public class GetCourseByIdRep : IGetCourseByIdRep
    {
        public Course? getById(int courseid)
        {
            return DataBase.Courses?.Where(course => course.Id == courseid)?.FirstOrDefault();
        }
    }
}
