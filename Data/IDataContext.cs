using System.Threading;
using System.Threading.Tasks;
using foodFptApi.Models;
using Microsoft.EntityFrameworkCore;

namespace foodFptApi.Data
{
    public interface IDataContext
    {
        DbSet<Food> Products { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}