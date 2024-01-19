using Examination.BL.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BL.IdentityRep.Quireies
{
    public static class identityRepo
    {
        public static Identity ChecK(LoginVM loginVM)
        {
            foreach (var item in DataBase.Courses)
            {
                return item.students.Where(std => std.Email == loginVM.Email && std.Password == loginVM.Passward).SingleOrDefault();
            }
            return null;
        }
    }
}
