using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFlower.Data.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int TotalSum { get; set; }
        public List<Product>? Products { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}
