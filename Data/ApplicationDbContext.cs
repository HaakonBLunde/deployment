using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Unicode;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sykeplayer_1.Models;

namespace sykeplayer_1.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

       

        public DbSet<Questions> Questions { get; set; }
        
        public DbSet<GameModel> Games { get; set; }
        
        public DbSet<Character> Characters { get; set; }
        
        public DbSet<IndexInfo> IndexInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GameModel>()
                .HasKey(gm => new {gm.Id, gm.Version});
            base.OnModelCreating(builder);
        }

        
    }
}
