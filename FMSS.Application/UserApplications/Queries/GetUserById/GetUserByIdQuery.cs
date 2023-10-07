using FMSS.Application.Configuration.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSS.Application.UserApplications.Queries.GetUserById
{
    public sealed record GetUserByIdQuery(Guid userId): IQuery<ApplicationUser>;
    
}
