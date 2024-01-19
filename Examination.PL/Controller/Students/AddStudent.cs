
namespace Examination.PL.Controller.Students
{
    public static class AddStudent
    {
        public static Student GetStudentData()
        {
            Student student = new Student();


            student.Id = Validate.getIntNumber(@"                 
                                                    Plz Enter ID :");



            Console.Write(@"


                                                    Plz Enter Name :");
            student.Name = Console.ReadLine();
            student.PersonType = PersonType.student;
            student.level = Validate.getIntNumber(@" 
                                                    Plz Enter Student Level :");
            Console.Write(@"
                                                    Plz Enter Email :");
            student.Email = Console.ReadLine();
            Console.Write(@"    
                                                    Plz Enter Password :");
            student.Password = Console.ReadLine();
            Console.Write(@"
                                                    Plz Enter Department Name :");
            student.DepartmentName = Console.ReadLine();

           

            return student;
        }
    }
}
