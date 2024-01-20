using Examination.BL.Validation;
using Examination.DAL.Entities.ExamVM;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
                //int count = 0;
                foreach (var Questions in item.body)
                {
                    using (StreamWriter writer = new StreamWriter(@"D:\\ITI\\C#\\Day7\\New Text Document.txt", true))
                    {
                        writer.WriteLine(Questions);
                    }
                    //Questions.sw.WriteLine(Questions.ToString());
                    Console.WriteLine(@$"
                          {Questions}

");
                    foreach (var chooses in Questions.Chooses)
                    {
                        Console.WriteLine(@$"
                  {chooses}
                        
");
                    }

                    Console.Write(@$"
                ----------------------------------------------------------------------------
                          Your Answer >>");
                    studentAnswer.Add(Validate.getIntNumber(""));
                    Console.Write(@$"
                -----------------------------------------------------------------------------

                         Correct Answer >> {Questions.Chooses.Where(a=>a.ID ==Questions.CorrectChoise).FirstOrDefault().Descripe}

                ======================================================================================================================
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
            return studentAnswer;
        }
    }
}
