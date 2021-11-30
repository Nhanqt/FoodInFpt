using System.Collections.Generic;
using System.Threading.Tasks;
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
        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetProducts()
        {
            var products = await _accountRepository.GetAll();
            return Ok(products);
        }
    }
}