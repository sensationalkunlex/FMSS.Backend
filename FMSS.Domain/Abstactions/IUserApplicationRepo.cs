using FMSS.Domain.Entities.UserApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSS.Domain.Abstactions
{
    public  interface IUserApplicationRepo
    {
        void Insert(UserApplication user);
        UserApplication GetUserDetail(Guid id);
        void UpdateUser(UserApplication user);
        IEnumerable<UserApplication> GetAllUsers();
    }
}
