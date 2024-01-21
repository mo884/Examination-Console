namespace Examination.PL.Controller.Exams
{
    public static class AddExamData
    {
        public static ExamVM AddExamsVM()
        {
            Console.Clear();
            ExamVM addexamVM = new ExamVM();
            addexamVM.CourseId = Validate.getIntNumber(
                @$"







                    Plz Enter  Course ID :"

                );

            
            return addexamVM;
        }

        public static Exam Get()
        {
            Exam exam = new Exam();

            Console.WriteLine(@"
 
                                   Add Exam 
                                  ===========

");
            exam.ID = Validate.getIntNumber(
                @$"







                    Plz Enter  Exam ID :"

                );

            Console.Write(@$"







                    Plz Enter  ExamTime : ");
            exam.ExamTime = Console.ReadLine();
            return exam;


        }



    }
}
