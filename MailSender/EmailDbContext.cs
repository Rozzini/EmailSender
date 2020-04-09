using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MailSender
{
    public partial class EmailDbContext : DbContext
    {
        public EmailDbContext()
        {
        }

        public EmailDbContext(DbContextOptions<EmailDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Models> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EmailDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
