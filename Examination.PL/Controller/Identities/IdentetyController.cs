using Examination.BL.ExamSolveRep;
using Examination.BL.IdentityRep.Quireies;
using Examination.BL.ModelVM;
using Examination.BL.StudentSolve.Command;
using Examination.BL.StudentSolve.ModelVM;
using Examination.PL.Controller.AdminDashBord;
using Examination.PL.Controller.Students;
using Examination.PL.Controller.StudentSolveExam;

namespace Examination.PL.Controller.Identities
{
    public  class IdentetyController
    {
        Admin admin;
        ExamSolveController ExamSolveController;
        IGetStudentByID StudentController;
        AddStudentAnswer addStudentAnswer;
        
        
        public IdentetyController()
        {
            admin = new Admin();
            ExamSolveController = new ExamSolveController();
            StudentController = new GetStudentByID();
            addStudentAnswer = new AddStudentAnswer();
           
        }
        public static Identity Login()
        {
            LoginVM loginVM = new LoginVM();
            Identity user ;
            do
            {
                Console.Clear();
                Console.Write(@"








                                                       Plz Enter Email :");
                loginVM.Email = Console.ReadLine();

                Console.Write(@"








                                                         Plz Enter Password :");
                loginVM.Passward = Console.ReadLine();

                user = identityRepo.ChecK(loginVM);
            } while (user== null);
            return user;
        }

        public void Roles()
        {
            Identity identity = Login();
            if (identity.PersonType == PersonType.admin)
            {
                admin.AdminDashBoard();
            }
            else
            {
               int CourseID = Validate.getIntNumber(@"
                         Plz Enter CourseNum :");
                Student student = StudentController.getById(identity.Id, CourseID);
                
                StudentAnswerVM studentAnswerVM = new StudentAnswerVM();
                SolvingVM solvingVM = ExamSolveController.Solve(CourseID);
                studentAnswerVM.Student = student;
                studentAnswerVM.ExamId =solvingVM.Exam.ID;
                studentAnswerVM.Id  =CourseID;
                studentAnswerVM.CorrectAnser = solvingVM.answer;


                addStudentAnswer.studentAnswer(studentAnswerVM);

                CorrectExam.GetStudentChoise(solvingVM.Exam, student);
            }
        }
    }
}
