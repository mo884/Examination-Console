using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.CourseRep.Quieries.Abstraction
{
    public interface IGetAllStudent
    {
        List<Student> getAll( int courseid);
    }
}
