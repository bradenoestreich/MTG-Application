using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MTG_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTG_Application.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Card> Cards { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
