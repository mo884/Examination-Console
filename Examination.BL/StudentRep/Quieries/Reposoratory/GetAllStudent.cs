using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.CourseRep.Quieries.Reposoratory
{
    public class GetAllStudent : IGetAllStudent
    {
        public List<Student>? getAll(int courseid)
        {
          return  DataBase.Courses?.Where(course => course.Id == courseid)?.FirstOrDefault()?.students.ToList();
        }
    }
}
