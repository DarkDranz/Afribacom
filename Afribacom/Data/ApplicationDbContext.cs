using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Afribacom.Models;

namespace Afribacom.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Afribacom.Models.Category> Category { get; set; }
        public DbSet<Afribacom.Models.Articles> Articles { get; set; }
    }
}
