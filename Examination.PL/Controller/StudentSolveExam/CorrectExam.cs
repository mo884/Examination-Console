

namespace Examination.PL.Controller.StudentSolveExam
{
    public  class CorrectExam
    {
       
        public static void GetStudentChoise(Exam exam,Student student)
        {

            Console.Clear();
            
            double Degree = exam.StudentExams[student].studentAnswer.Where(a => a.CorrectAnswer == a.StudentAnswerChoose).Sum(a => a.Degree);
            exam.StudentExams[student].FinallStudentDegree = Degree;

             Console.WriteLine($@"







                                                    Your Degree : {Degree}


                                                    {getAppreciation(exam.StudentExams[student].studentAnswer.Sum(a => a.Degree), Degree)}

                                         


                                         ");

           


        }
        public static string getAppreciation(double TotalDegree, double studentDegree)
        {
            double appre = (studentDegree/ TotalDegree)*100;
            if (appre<50&&appre>0)
                return "Failed :< ";
            else if (appre>=50&&appre<=65)
                return "Passable :(";
            else if (appre>=65&&appre<=75)
                return "Good ....";
            else if (appre>=75&&appre<=85)
                return "Very Good :|";
            else
                return "Excellent :)";

        }

    }
}
