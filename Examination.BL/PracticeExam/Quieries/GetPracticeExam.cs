
namespace Examination.BL.PracticeExam.Quieries
{
    public static class GetPracticeExam
    {
        
        public static void GetExam( Exam exam,Course course)
        {
           Console.WriteLine( @$"

                Exam Time :  {exam.ExamTime}             Degree :{exam.Questions.Sum(a=>a.mark)}

                ----------------------------------------------------------------------------------

");

            foreach (var item in exam.Questions)
            {
                Console.WriteLine(
                    @$"

                   {item}
"
 );
                foreach (var Questions in item.body)
                {
                    Console.WriteLine(@$"
                          {Questions}

");
                    foreach (var chooses in Questions.Chooses)
                    {
                        Console.WriteLine(@$"
                  {chooses}
                        
");
                    }

                    Console.WriteLine(@$"
                ----------------------------------------------------------------------------
                          Correct Answer >> {Questions.CorrectChoise}
");
                }


                Console.WriteLine($"============================================End Question ======================================");
            }

            Console.WriteLine($@"

                                                                                               Best wishes  :(
                                            ===========================
                                            CourseName : {course.name}
                                            ===========================

");

        }
    }
}
