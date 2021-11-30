using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using foodFptApi.Data;
using FoodInFpt.Dtos;
using FoodInFpt.Models;
using FoodInFpt.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FoodInFpt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly DataContext _datacontext;
        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpPost]
        public async Task<ActionResult> CreateAccount(AccountDto accountDto)
        {
            // Account account = new Account
            // {

            // }
            // var products = await _accountRepository.Add();
            return Ok();
        }

        [HttpGet("GetAll")]
        public IEnumerable<Account> Get()
        {

            return _accountRepository.GetAll().ToList();
        }
    }
}