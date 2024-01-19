using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.Validation
{
    public class Validate
    {
        public static int getIntNumber(string Message)
        {
            int Num;
            do
            {
                Console.Write(@$"{Message}");
            } while (!int.TryParse(Console.ReadLine(), out Num));
            return Num;
        }
    }
}
