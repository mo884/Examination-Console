using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.ChooseRep.Command
{
    public interface IChoooseRep
    {
        void Add(List<Choose> items, ChooseVM ModelVM);
    }
}
