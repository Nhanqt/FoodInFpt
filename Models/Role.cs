using System.Collections.Generic;
using foodFptApi.Models;

namespace FoodInFpt.Models
{
    public class Role : Base
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public IList<AccountRole> AccountRoles { get; set; }
    }
}