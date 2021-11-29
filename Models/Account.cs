
using System.Collections;
using System.Collections.Generic;
using foodFptApi.Models;

namespace FoodInFpt.Models
{
    public class Account : Base
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public IList<AccountRole> AccountRoles { get; set; }

    }
}