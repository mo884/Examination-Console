
namespace Examination.BL.ChooseRep.Queries
{
    public class GetAllChoiseByQuestionId : IGetAllRep<Choose, ChooseVM>
    {
        public List<Choose>? GetAllRep(ChooseVM modelVm)
        {
            return DataBase.Courses?.Where(c => c.Id == modelVm.CourseId)?.FirstOrDefault()?.Exams.Where(exam => exam.ID == modelVm.ExamId)?.FirstOrDefault()?.Questions?.Where(q => q.ID==modelVm.QuestionID)?.FirstOrDefault()?.body?.Where(qList => qList.ID == modelVm.QuestionListID)?.FirstOrDefault()?.Chooses?.ToList();
        }
    }
}
