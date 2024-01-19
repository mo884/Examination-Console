
namespace Examination.PL.Controller.Questions
{
    public static class GetQuistionById
    {
        public static GetQuistionByIdVM AddQuetionsVM()
        {
            Console.Clear();
            GetQuistionByIdVM getQuistionByIdVM = new GetQuistionByIdVM();
            getQuistionByIdVM.CourseID = Validate.getIntNumber(
                @$"







                    Plz Enter  Course ID : 


"

                );

            getQuistionByIdVM.ExamID = Validate.getIntNumber(
               @$"
                   
                    Plz Enter  Exam ID :  
"

               );

            getQuistionByIdVM.QuistionId = Validate.getIntNumber(
             @$"
                   
                    Plz Enter  Quistion ID :  
"

             );
            return getQuistionByIdVM;
        }


    }
}
