
namespace Examination.BL.ExamRep.Queries
{
    public class GetExam:IGetById<Exam,GetExamByIdVM>
    {
        public Exam? GetById(GetExamByIdVM modelVm)
        {
            return DataBase.Courses?.Where(c => c.Id == modelVm.CourseID)?.FirstOrDefault()?.Exams.Where(exam => exam.ID == modelVm.ExamID).FirstOrDefault();
        }
    }
}
