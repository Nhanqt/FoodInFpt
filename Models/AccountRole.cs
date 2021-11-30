using System;
using foodFptApi.Models;

namespace FoodInFpt.Models
{
    public class AccountRole : Base
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}