using FMSS.Application.Configuration.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSS.Application.UserApplications.Queries.GetUserById
{
    internal sealed class GetUserQueryHandler : IQueryHandler<GetUserByIdQuery, ApplicationUser>
    {
        public Task<ApplicationUser> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
