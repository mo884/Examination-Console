using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.DAL.Entities.ExamVM
{
    public class Degree:IComparable<Degree>
    {
        public List<StudentAnswer> studentAnswer { get; set; } = new List<StudentAnswer>();
        public double FinallStudentDegree { get; set; }

        public int CompareTo(Degree? other)
        {
            if(other == null) return -1;
            if(this == other) return 1;
            if (this.FinallStudentDegree < other.FinallStudentDegree) return 1;
            if (this.FinallStudentDegree == other.FinallStudentDegree) return 0;
            return -1;
        }
    }
}
