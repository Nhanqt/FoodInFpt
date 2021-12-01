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
            //manytomany
            // modelBuilder.Entity<AccountRole>().HasKey(sc => new { sc.AccountId, sc.RoleId });
            // modelBuilder.Entity<AccountRole>()
            //     .HasOne<Account>(sc => sc.Account)
            //     .WithMany(s => s.AccountRoles)
            //     .HasForeignKey(sc => sc.AccountId);


            // modelBuilder.Entity<AccountRole>()
            //     .HasOne<Role>(sc => sc.Role)
            //     .WithMany(s => s.AccountRoles)
            //     .HasForeignKey(sc => sc.RoleId);

            // configures one-to-many relationship
            modelBuilder.Entity<Account>()
                .HasOne<Role>(s => s.Role)
                .WithMany(g => g.Accounts)
                .HasForeignKey(s => s.RoleId);
        }

        public DbSet<Food> Products { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}