using FMSS.Domain.Entities.UserApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSS.Infrastructure.Persistence.Database.Repositories
{
    public sealed class UserRepo : IUserRepo
    {
        private readonly ApplicationDbContext _context;
        public UserRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Insert(UserApplication user)
        {
            await  _context.UserApplications.AddAsync(user);
        }
    }
}
