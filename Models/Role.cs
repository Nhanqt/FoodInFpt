using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using foodFptApi.Models;

namespace FoodInFpt.Models
{
    public class Role : Base
    {
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }

        public IList<Account> Accounts { get; set; }
    }
}