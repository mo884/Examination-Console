
using Examination.BL.ExamRep.Command;
using Examination.BL.ExamRep.ModelVM;
using Examination.BL.ExamRep.Queries;
using Examination.BL.PracticeExam.Quieries;
using Examination.DAL.Entities.ExamVM;

namespace Examination.PL.Controller.Exams
{
    public class ExamsController
    {

        IGenericAddRep<Exam, ExamVM> AddExamrep;
        IGetCourseByIdRep getCourseByIdRep;
       
        IGetById<Exam, GetExamByIdVM> getExamByID;
        public ExamsController()
        {
            AddExamrep = new AddExamRep();
            getExamByID = new GetExam();
            getCourseByIdRep = new GetCourseByIdRep();
        }
        public void Add()
        {
            Exam exam = AddExamData.Get();
            ExamVM examVM = AddExamData.AddExamsVM();
            AddExamrep.Add(exam, examVM);
            GetIdLastExam =exam.ID;
            GetCourseIdLAstExam =examVM.CourseId;
        }
        public Exam GetById()
        {
            Console.Clear();
            GetExamByIdVM getExamByIdVM = new GetExamByIdVM();
            getExamByIdVM.CourseID =Validate.getIntNumber(@$"

                                    Plz Enter Course ID :");
            getExamByIdVM.ExamID=Validate.getIntNumber(@$"

                                    Plz Enter Exam ID   :");
            Exam exam = getExamByID.GetById(getExamByIdVM);
            return exam;
        }
        public void ExamPracties()
        {
            Console.Clear();
            GetExamByIdVM getExamByIdVM = new GetExamByIdVM();
            getExamByIdVM.CourseID =Validate.getIntNumber(@$"

                                    Plz Enter Course ID :");
            getExamByIdVM.ExamID=Validate.getIntNumber(@$"

                                    Plz Enter Exam ID   :");
            Exam exam = getExamByID.GetById(getExamByIdVM);
            Console.Clear();
            GetPracticeExam.GetExam(exam, getCourseByIdRep.getById(getExamByIdVM.CourseID));
        }
        public static int GetIdLastExam = 0;
       

        public static int GetCourseIdLAstExam= 0;
      
    }
}
