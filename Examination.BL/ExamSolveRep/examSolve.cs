using Examination.BL.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.ExamSolveRep
{
    public static class examSolve
    {
        public static List<int> GetExam(Exam exam, Course course)
        {
            List<int>studentAnswer = new List<int>();
            Console.WriteLine(@$"

                Exam Time :  {exam.ExamTime}             Degree :{exam.Questions.Sum(a => a.mark)}

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
                          Correct Answer >>");
                    studentAnswer.Add(Validate.getIntNumber(""));
                }


                Console.WriteLine($"============================================End Question ======================================");
            }

            Console.WriteLine($@"

                                                                                               Best wishes  :(
                                            ===========================
                                            CourseName : {course.name}
                                            ===========================

");
            return studentAnswer;
        }
    }
}
