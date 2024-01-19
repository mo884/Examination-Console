

namespace Examination.BL.QuestionRep.Command
{
    public class AddQuestionRep : IGenericAddRep<Question, AddExamVM>
    {
        public void Add(Question item, AddExamVM modelvm)
        {
            if(item is Question)
            {
                Course? course = DataBase.Courses.Where(course => course.Id == modelvm.CourseID)?.FirstOrDefault();

                Exam? exam = course?.Exams.Where(exam => exam.ID == modelvm.ExamID)?.FirstOrDefault();

                exam?.Questions.Add(item);
            }
           
        }
    }
}
