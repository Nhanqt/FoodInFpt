using System;
namespace foodFptApi.Models
{
    public class Food : Base
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public string image { get; set; }
    }
}