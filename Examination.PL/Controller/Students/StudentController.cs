
using Examination.BL.CourseRep.Command.Abstraction;

namespace Examination.PL.Controller.Students
{
    public class StudentController
    {
        IGetAllStudent getAllStudent;
        IAddStudentRep addStudentRep;
        IGetStudentByID getStudentByID;
        public StudentController()
        {
            getAllStudent = new GetAllStudent();
            addStudentRep = new AddStudentRep();
            getStudentByID = new GetStudentByID();
        }
        public void Add(int courseid)
        {
            addStudentRep.Add(AddStudent.GetStudentData(), courseid);
        }
        public void GetAll(int CourseID)
        {
            var item = getAllStudent.getAll(CourseID);
            for (int i = 0;i< item?.Count;i++)
                Console.WriteLine(item[i]);
        }
        public void GetById()
        {
            Console.WriteLine( getStudentByID.getById(Validate.getIntNumber(@"Plz Enter Student Id :"), Validate.getIntNumber(@"Plz Enter Course Id :")));
        }
    }
}
