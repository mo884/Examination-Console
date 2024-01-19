using Examination.BL.StudentSolve.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.StudentSolve.Command
{
    public class AddStudentAnswer
    {
        public void studentAnswer(StudentAnswerVM studentAnswerVM)
        {
            Exam exam = DataBase.Courses?.Where(c => c.Id == studentAnswerVM.Id)?.FirstOrDefault()?.Exams?.Where(exam => exam.ID == studentAnswerVM.ExamId)?.FirstOrDefault();
            
            List<StudentAnswer> studentAnswers = new List<StudentAnswer>();

            int Count = 0;
            for (int i = 0; i < exam.Questions.Count; i++)
            {
                
                for (int j = 0; j < exam.Questions[i].body.Count; j++)
                {
                    studentAnswers.Add(new StudentAnswer() { StudentAnswerChoose=studentAnswerVM.CorrectAnser[Count++], CorrectAnswer= exam.Questions[i].body[j].CorrectChoise });
                }
            }
            exam.StudentExams.Add(studentAnswerVM.Student, studentAnswers);



        }
    }
}
