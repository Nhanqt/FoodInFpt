
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using foodFptApi.Models;

namespace FoodInFpt.Models
{
    public class Account : Base
    {
        public int AccountId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Phone { get; set; }
        public IList<AccountRole> AccountRoles { get; set; }
    }
}