
namespace Examination.PL.Controller.Chooses
{
    public class ChooseController
    {
        IChoooseRep addchoisse;
        public ChooseController()
        {
            addchoisse = new AddChooseRep();
        }


        public void Add()
        {
            List<Choose> chooses = new List<Choose>();
            int Count = Validate.getIntNumber(@"

                                              Plz Enter Numm of Choose Want To Add :");
            
            for (int i = 0;i<Count;i++)
            {
                Choose choose = new Choose();
                choose.ID  = Validate.getIntNumber(@"

                                              Plz Enter Choose ID :");
                Console.WriteLine(@"

                                              Plz Enter Choose Descripe :");
                choose.Descripe = Console.ReadLine();

                chooses.Add(choose);
            }
            

            Console.Clear();
            ChooseVM chooseVM = new ChooseVM();
            chooseVM.CourseId  = Validate.getIntNumber(@"

                                              Plz Enter Course ID      :");

            chooseVM.ExamId  = Validate.getIntNumber(@"

                                              Plz Enter Exam ID        :");
            chooseVM.QuestionID  = Validate.getIntNumber(@"

                                              Plz Enter Question ID    :");
            chooseVM.QuestionListID  = Validate.getIntNumber(@"

                                              Plz Enter QuestionListID :");
            addchoisse.Add(chooses, chooseVM);
        }
    }
}
