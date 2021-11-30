using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodInFpt.Models;

namespace FoodInFpt.Repositories
{
    public interface IAccountRepository
    {
        Task<Account> Get(int id);
        IEnumerable<Account> GetAll();
        Task Add(Account account);
        Task Delete(int id);
        Task Update(Account account);
    }
}