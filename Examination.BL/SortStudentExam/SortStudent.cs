using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.SortStudentExam
{
    internal class SortStudent : IEqualityComparer<Degree>
    {
       

        public bool Equals(Degree x, Degree y)
        {
            return (x.FinallStudentDegree == y.FinallStudentDegree);
        }

      
        public int GetHashCode([DisallowNull] Degree obj)
        {
            throw new NotImplementedException();
        }
    }
}
