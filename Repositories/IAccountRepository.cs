using System.Collections.Generic;
using System.Threading.Tasks;
using FoodInFpt.Models;

namespace FoodInFpt.Repositories
{
    public interface IAccountRepository
    {
        Task<Account> Get(int id);
        Task<IEnumerable<Account>> GetAll();
        Task Add(Account account);
        Task Delete(int id);
        Task Update(Account account);
    }
}