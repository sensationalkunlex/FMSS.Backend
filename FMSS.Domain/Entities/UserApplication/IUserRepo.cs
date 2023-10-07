using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSS.Domain.Entities.UserApplication
{
    public interface IUserRepo
    {
       Task Insert(UserApplication user);
    }
}
