namespace Examination.BL.QuestionRep.Queries
{
    public class GetQuestionById : IGetById<Question, GetQuistionByIdVM>
    {

        public Question? GetById( GetQuistionByIdVM modelVm)
        {
            return DataBase.Courses?.Where(c => c.Id == modelVm.CourseID)?.FirstOrDefault()?.Exams.Where(exam => exam.ID == modelVm.ExamID)?.FirstOrDefault().Questions.Where(q => q.ID==modelVm.QuistionId).FirstOrDefault();
        }
    }
}
