using System;
namespace foodFptApi.Models
{
    public class BaseDto
    {
        public string createBy { get; set; }
        public DateTime createdAt { get; set; }
        public string updateBy { get; set; }
        public DateTime updateAt { get; set; }
    }
}