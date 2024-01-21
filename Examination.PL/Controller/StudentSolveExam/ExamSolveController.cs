


namespace Examination.PL.Controller.StudentSolveExam
{
    public class ExamSolveController
    {
        ExamsController ExamsController;
        IGetCourseByIdRep getCourseByID;
       
        public ExamSolveController()
        {
            ExamsController = new ExamsController();
            getCourseByID = new GetCourseByIdRep();
           
        }
        public SolvingVM Solve(int examID)
        {
            SolvingVM solvingVM = new SolvingVM();
            solvingVM.Exam = ExamsController.GetById();
            solvingVM.answer =examSolve.GetExam(solvingVM.Exam, getCourseByID.getById(examID));
            return solvingVM;
        }
    }
}
