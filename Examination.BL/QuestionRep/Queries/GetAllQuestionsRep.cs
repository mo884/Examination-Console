using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.QuestionRep.Queries
{
    public class GetAllQuestionsRep : IGetAllRep<Question, GetAllQuestionVM>
    {
        public List<Question>? GetAllRep(GetAllQuestionVM modelVm)
        {
            return DataBase.Courses?.Where(c => c.Id == modelVm.CourseID)?.FirstOrDefault()?.Exams.Where(exam => exam.ID == modelVm.ExamID)?.FirstOrDefault()?.Questions;
        }
    }
}
