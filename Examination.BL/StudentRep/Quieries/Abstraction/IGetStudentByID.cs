namespace Examination.BL.CourseRep.Quieries.Abstraction
{
    public interface IGetStudentByID
    {
        Student getById(int studentid , int courseid);
    }
}
