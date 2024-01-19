
namespace Examination.BL.ExamRep.Command
{
    public class AddExamRep : IGenericAddRep<Exam, ExamVM>
    {
        public void Add(Exam item, ExamVM ModelVM)
        {
            DataBase.Courses?.Where(c => c.Id == ModelVM.CourseId)?.FirstOrDefault()?.Exams.Add(item);
        }
    }
}
