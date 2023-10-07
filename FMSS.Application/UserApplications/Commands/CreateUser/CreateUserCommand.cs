using FMSS.Application.Configuration.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FMSS.Application.UserApplications.Commands.CreateUser
{
    public sealed record CreateUserCommand(string Username, string Password, string Department, string Region, string Email, Guid RoleId) : ICommand<Guid>;
  
}
