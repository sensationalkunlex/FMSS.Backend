using FMSS.Domain.Entities;
using FMSS.Domain.Entities.UserApplication;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSS.Infrastructure.Persistence.Database
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<UserApplication> UserApplications { get; set; }
        public  DbSet<UserRole> UserRoles { get; set; } 


        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
   
}
