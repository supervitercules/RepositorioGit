
using AccountManager.Data.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace AccountManager.Data
{
    public class AccountManagerDBContext : DbContext
    {
        public AccountManagerDBContext(
            DbContextOptions<AccountManagerDBContext> options) : base(options)
        {

        }

        public DbSet<AccountType> AccountType { get; set; }

        public DbSet<Account> Account { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountType>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Account>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Account>()
                .HasOne(r => r.AccountType)
                .WithMany(r => r.Account)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
