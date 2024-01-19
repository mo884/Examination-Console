using Examination.DAL.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.PL.Controller.Courses
{
    public static class AddCourseData
    {

        public static Course addCourse()
        {
            Course course = new Course();

            course.Id = Validate.getIntNumber(@"                              

                                                          Plz Enter Course ID :");
            Console.Write(@"                              



                                                          Plz Enter Course Name :");
            course.name = Console.ReadLine();
            return course;
        }
    }
}
