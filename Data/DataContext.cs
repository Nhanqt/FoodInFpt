using foodFptApi.Models;
using FoodInFpt.Models;
using Microsoft.EntityFrameworkCore;
namespace foodFptApi.Data
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountRole>().HasKey(sc => new { sc.AccountId, sc.RoleId });
            modelBuilder.Entity<AccountRole>()
                .HasOne<Account>(sc => sc.Account)
                .WithMany(s => s.AccountRoles)
                .HasForeignKey(sc => sc.AccountId);


            modelBuilder.Entity<AccountRole>()
                .HasOne<Role>(sc => sc.Role)
                .WithMany(s => s.AccountRoles)
                .HasForeignKey(sc => sc.RoleId);
        }

        public DbSet<Food> Products { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
    }
}