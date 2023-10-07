using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSS.Domain.Entities.Interfaces
{
    public interface IUserTracker
    {
        public Guid? UserId { get; set; }
    }
}
