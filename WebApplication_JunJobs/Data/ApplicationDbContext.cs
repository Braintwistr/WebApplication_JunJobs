using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication_JunJobs.Models;

namespace WebApplication_JunJobs.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplication_JunJobs.Models.Vacancy> Vacancy { get; set; }
        public DbSet<WebApplication_JunJobs.Models.CV> CV { get; set; }
    }
}
