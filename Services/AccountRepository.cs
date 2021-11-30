using System.Collections.Generic;
using System.Threading.Tasks;
using foodFptApi.Data;
using FoodInFpt.Models;

namespace FoodInFpt.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IDataContext _context;
        public AccountRepository(IDataContext context)
        {
            _context = context;
        }
        public async Task Add(Account account)
        {
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Account> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Account>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Account account)
        {
            throw new System.NotImplementedException();
        }
    }
}