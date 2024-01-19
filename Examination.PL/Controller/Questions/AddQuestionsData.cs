namespace Examination.PL.Controller.Questions
{
    public static class AddQuestionsData
    {
        public static AddExamVM  AddQuetionsVM()
        {
            Console.Clear();
            AddExamVM addQuestionVM = new AddExamVM();
            addQuestionVM.CourseID = Validate.getIntNumber(
                @$"







                    Plz Enter  Course ID :"

                );

            addQuestionVM.ExamID = Validate.getIntNumber(
               @$"
                   
                    Plz Enter  Exam ID :"

               );
            return addQuestionVM;
        }


        public static Question AddQuetions(int ID)
        {
            Console.Clear();
            Console.WriteLine(" =========================================Input Question Info=============================");
            Question question = new Question();
            question.ID = ID;
            Console.WriteLine($@"


                   Plz Enter Question Header :");
            question.header = Console.ReadLine();

 
            question.mark =Validate.getIntNumber(
                @$"


                    Plz Enter  Question Mark :");
            int Count = Validate.getIntNumber(
                @$"


                    Plz Add Num of Questions :");
            Console.Clear();

            for (int i = 0;i<Count;i++)
            {
                
                Console.WriteLine("================================Input Exam Question====================================");
                ListQuestion listQuestion = new ListQuestion()
                {
                    ID =  i+1,          
                    CorrectChoise = Validate.getIntNumber(
                @$"


                    Plz Enter ListQuestion CorrectChoise  {i+1}  :")
                };
                Console.Write($@"


                   Plz Enter Question Body {i+1}  :");
                listQuestion.Body = Console.ReadLine();
               

                question.body.Add(listQuestion);
                Console.Clear();
                int chooseCount = Validate.getIntNumber(
               @$"


                    Plz Enter Num Of Choise :");
                for (int j = 0; j < chooseCount; j++)
                {
                   
                    Console.WriteLine(@"


                           ========================Input Question  Coose ==========


");
                    Choose choose = new Choose();
                    choose.ID  = j+1;
                    Console.WriteLine(@"

                                              Plz Enter Choose Descripe :");
                    choose.Descripe = Console.ReadLine();

                    question.body[i].Chooses.Add(choose);
                }

            }
            return question;
        }
    }
}
