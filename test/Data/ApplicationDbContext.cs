using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using test.Models;

namespace test.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<WorkStep> WorkSteps { get; set; }
        public DbSet<WSHeaderObject> WSHeaderObjects { get; set; }
        public DbSet<WSDetailView> WSDetailViews { get; set; }
        public DbSet<WSDVDetailObject> GetWSDVDetailObjects { get; set; }
    }
}
