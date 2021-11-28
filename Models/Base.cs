using System;
namespace foodFptApi.Models
{
    public class Base
    {
        public DateTime createBy { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updateBy { get; set; }
        public DateTime updateAt { get; set; }
    }
}