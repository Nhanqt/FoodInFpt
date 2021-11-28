using foodFptApi.Models;
using Microsoft.EntityFrameworkCore;
namespace foodFptApi.Data
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Food> Products { get; set; }
    }
}