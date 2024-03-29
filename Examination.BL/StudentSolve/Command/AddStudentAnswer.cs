﻿using Examination.BL.StudentSolve.ModelVM;

namespace Examination.BL.StudentSolve.Command
{
    public class AddStudentAnswer
    {
        public void studentAnswer(StudentAnswerVM studentAnswerVM)
        {
            Exam exam = DataBase.Courses?.Where(c => c.Id == studentAnswerVM.Id)?.FirstOrDefault()?.Exams?.Where(exam => exam.ID == studentAnswerVM.ExamId)?.FirstOrDefault();
            Degree degree = new Degree();
            List<StudentAnswer> studentAnswers = new List<StudentAnswer>();

            int Count = 0;
            for (int i = 0; i < exam.Questions.Count; i++)
            {
                double Degree = exam.Questions[i].mark/exam.Questions[i].body.Count;
                for (int j = 0; j < exam.Questions[i].body.Count; j++)
                {
                    
                    studentAnswers.Add(new StudentAnswer() { StudentAnswerChoose=studentAnswerVM.CorrectAnser[Count++], CorrectAnswer= exam.Questions[i].body[j].CorrectChoise,Degree = Degree });
                }
            }
            degree.studentAnswer = studentAnswers;
            exam.StudentExams.Add(studentAnswerVM.Student, degree);



        }
    }
}
