
namespace Examination.PL.Controller.Questions
{
    public class QuestionsController
    {
        IGenericAddRep<Question, AddExamVM> AddQuestionrep;
        IGetAllRep<Question, GetAllQuestionVM> getAllQuetionRep;
        IGetById<Question, GetQuistionByIdVM> getQuestionByID;
        public QuestionsController()
        {
            AddQuestionrep = new AddQuestionRep();
            getAllQuetionRep = new GetAllQuestionsRep();
            getQuestionByID = new GetQuestionById();
        }
        public void Add(AddExamVM addExamVM)
        {
            
            int QuestionCount = Validate.getIntNumber(@"

                                           Plz Enter Num of Question :

");
            for (int i = 0; i < QuestionCount; i++)
            {
                AddQuestionrep.Add(AddQuestionsData.AddQuetions(i), addExamVM);

            }
        }
        public void GetAll(int CourseID)
        {
            var item = getAllQuetionRep.GetAllRep(GetAllQuestion.GetQuetionVM());
            for (int i = 0; i< item?.Count; i++)
            {
                Console.WriteLine(item[i]);
                int Count = 0;
                foreach (var ListQuestion in item[i].body)
                {
                   
                    Console.WriteLine(ListQuestion);
                }
            }
               
        }
        public void GetById()
        {
            Console.WriteLine(getQuestionByID.GetById(GetQuistionById.AddQuetionsVM()));
        }
    }
}
