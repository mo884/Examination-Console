using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.StudentSolve.ModelVM
{
    public class StudentAnswerVM
    {
        public Student Student { get; set; }
        public int Id { get; set; }
        public int ExamId { get; set; }
        public List<int> CorrectAnser { get; set; }
    }
}
