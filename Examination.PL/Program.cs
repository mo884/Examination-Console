namespace Examination.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DataBase.GetData();
            //IdentetyController identetyController = new IdentetyController();
            //identetyController.Roles();
            
             Student student = new Student() { Id=1,Name="Mohamed"};

            Student student1 =(Student)student.Clone();
            Console.WriteLine(student1);
        }
    }
}
