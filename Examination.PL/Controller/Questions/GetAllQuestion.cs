

namespace Examination.PL.Controller.Questions
{
    public static class GetAllQuestion
    {
        public static BL.QuestionRep.ModelVM.GetAllQuestionVM GetQuetionVM()
        {
            Console.Clear();
            BL.QuestionRep.ModelVM.GetAllQuestionVM addQuestionVM = new BL.QuestionRep.ModelVM.GetAllQuestionVM();
            addQuestionVM.CourseID = Validate.getIntNumber(
                @$"







                    Plz Enter  Course ID : 


"

                );

            addQuestionVM.ExamID = Validate.getIntNumber(
               @$"
                   
                    Plz Enter  Exam ID :  
"

               );
            return addQuestionVM;
        }


    }
}
