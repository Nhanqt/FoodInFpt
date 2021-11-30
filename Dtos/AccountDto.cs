using foodFptApi.Models;

namespace FoodInFpt.Dtos
{
    public class AccountDto : BaseDto
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
    }
}