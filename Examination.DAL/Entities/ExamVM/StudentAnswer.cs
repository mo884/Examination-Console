using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.DAL.Entities.ExamVM
{
    public class StudentAnswer
    {
        public int CorrectAnswer { get; set; }
        public int StudentAnswerChoose { get; set; }
        public double Degree { get; set; }
    }
}
