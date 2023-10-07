using FMSS.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FMSS.Domain.Entities.UserApplication
{
    public  class UserApplication : ITrackDateTime, IUserTracker, ISoftDelete
    {
        public UserId Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public Guid? UserId { get; set; }
        public UserRole Role { get; set; }
        public Guid RoleId { get; set; }
        public bool IsDelete { get; set; }
        public string Department { get; set; }
        public string Region { get; set; }
        public bool _welcomeEmailWasSent { get; set; }


        private UserApplication(string email, string department, string region, string password, Guid roleId, string username)
        {
            this.Id = new UserId(Guid.NewGuid());
            this.Email = email;
            this.Department = department;
            this.Region = region;
            this.Password=password;
            this.RoleId = roleId;
            this.Username= username;
            _welcomeEmailWasSent = false;
           

            //this.AddDomainEvent(new CustomerRegisteredEvent(this.Id));
        }

        public static UserApplication CreateRegistered(
           string email, string department, string region, string password, Guid roleId, string username
            )
        {
            
            return new UserApplication(email, department, region, password, roleId, username);
        }
    }
}
