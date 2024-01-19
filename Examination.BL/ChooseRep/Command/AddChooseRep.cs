using Examination.BL.ChooseRep.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.ChooseRep.Command
{
    public class AddChooseRep : IChoooseRep
    {
        public void Add(List<Choose> items, ChooseVM ModelVM)
        {
             DataBase.Courses?.Where(c => c.Id == ModelVM.CourseId)?.FirstOrDefault()?.Exams.Where(exam => exam.ID == ModelVM.ExamId)?.FirstOrDefault()?.Questions?.Where(q=>q.ID==ModelVM.QuestionID)?.FirstOrDefault()?.body.Where(qList=>qList.ID == ModelVM.QuestionListID).FirstOrDefault()?.Chooses.AddRange(items);
        }
    }
}
