using CascadingDropdownsWithAjax.UI.DbSeeder;
using CascadingDropdownsWithAjax.UI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CascadingDropdownsWithAjax.UI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            SeedDbWithInitialData.Seed(builder);
            base.OnModelCreating(builder);
        }
    }
}
