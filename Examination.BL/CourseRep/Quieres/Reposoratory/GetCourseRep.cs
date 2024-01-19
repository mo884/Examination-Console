using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.CourseRep.Quieres.Reposoratory
{
    public class GetCourseRep : IGetCourseRep
    {
        public List<Course>? getAll()
        {
            return DataBase.Courses.ToList();
        }
    }
}
