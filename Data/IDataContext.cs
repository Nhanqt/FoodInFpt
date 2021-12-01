using System.Threading;
using System.Threading.Tasks;
using foodFptApi.Models;
using FoodInFpt.Models;
using Microsoft.EntityFrameworkCore;

namespace foodFptApi.Data
{
    public interface IDataContext
    {
        DbSet<Food> Products { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        DbSet<Account> Accounts { get; set; }
        DbSet<Role> Roles { get; set; }
    }
}