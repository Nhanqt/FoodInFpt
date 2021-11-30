using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using foodFptApi.Data;
using FoodInFpt.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

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

        public IEnumerable<Account> GetAll()
        {
            var query = (from a in _context.Accounts
                         join ar in _context.AccountRoles on a.AccountId equals ar.AccountId
                         join r in _context.Roles on ar.RoleId equals r.RoleId
                         select new Account
                         {
                             AccountId = a.AccountId,
                             Username = a.Username,
                             AccountRoles = a.AccountRoles,
                             Phone = a.Phone,
                             Email = a.Email,
                             Password = a.Password,
                             Age = a.Age,
                             Fullname = a.Fullname,
                             role = r.RoleName
                         }).ToList();
            return query;
        }

        public Task Update(Account account)
        {
            throw new System.NotImplementedException();
        }
    }
}