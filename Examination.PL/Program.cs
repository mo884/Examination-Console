using Examination.DAL.Data;
using Examination.DAL.Entities.Courses;
using Examination.DAL.Entities.ExamVM;
using Examination.PL.Controller.AdminDashBord;
using Examination.PL.Controller.Chooses;
using Examination.PL.Controller.Courses;
using Examination.PL.Controller.Exams;
using Examination.PL.Controller.Identities;
using Examination.PL.Controller.Questions;

namespace Examination.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataBase.GetData();
            IdentetyController identetyController = new IdentetyController();
            identetyController.Roles();
            
          
        }
    }
}
