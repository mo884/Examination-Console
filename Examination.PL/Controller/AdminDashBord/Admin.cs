namespace Examination.PL.Controller.AdminDashBord
{
    public class Admin
    {
        StudentController studentController;
        CourseController courseController;
        ExamsController examsController;
        QuestionsController Question;
        public Admin()
        {
            studentController = new StudentController();
            courseController = new  CourseController();
            examsController = new ExamsController();
            Question = new QuestionsController();

        }
        public static int List()
        {
            Console.Clear();
            int num = Validate.getIntNumber(@"






                       Enter 1 if You Want Add student
                       Enter 2 if yoy want Get student By Id           
                       Enter 3 if you want Get All Students 
                       Enter 4 if you want Add Course 
                       Enter 5 if yoy want Get Course By Id           
                       Enter 6 if you want Get All Courses 
                       Enter 7 if you want Add Exam To Course 
                       Enter 8 if you want Add Quession To Exam
                       Enter 9 if You Want Shaw Exam
                       Enter 10 if You Want Logout
                       ======================================
                       >>");
            return num;
        }

        public void AdminDashBoard()
        {
            int Nummber = 0;
            int CourseId;
            do
            {
                Nummber= List();
                switch (Nummber)
                {
                    case 1:
                        Console.Clear();
                        CourseId = Validate.getIntNumber(@"
                                         Plz Enter Course ID : ");
                        studentController.Add(CourseId);
                        break;
                    case 2:
                        Console.Clear();
                        studentController.GetById();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        CourseId = Validate.getIntNumber(@"
                                         Plz Enter Course ID : ");
                        studentController.GetAll(CourseId);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        courseController.Add();
                        break;
                    case 5:
                        Console.Clear();
                        courseController.GetById();
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        courseController.GetAll();
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.Clear();
                        examsController.Add();
                        Console.Clear();
                        CourseId =ExamsController.GetIdLastExam;
                        Question.Add(new AddExamVM() { CourseID=CourseId, ExamID=ExamsController.GetCourseIdLAstExam });
                        break;
                    case 8:
                        Console.Clear();
                        Question.Add(AddQuestionsData.AddQuetionsVM());
                        break;

                    case 9:
                        Console.Clear();
                        examsController.ExamPracties();
                        Console.ReadLine();
                        break;
                    case 10:
                        
                        break;
                }
                if (Nummber ==10)
                    break;
            } while (Nummber != null);
            IdentetyController.Login();
        }
    }
}
