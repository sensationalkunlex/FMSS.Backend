
using FMSS.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSS.Domain.Entities
{
    public class UserRole : IBaseEntity
    {
        public Guid Id { get ; set ; }
        public string RoleName { get ; set ; }
    }
}
