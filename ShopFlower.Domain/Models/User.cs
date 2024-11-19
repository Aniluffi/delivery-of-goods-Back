using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFlower.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<RolesUser> Roles { get; set; } = new List<RolesUser>();
        public int CartId { get; set; }
        public Cart? Cart { get; set; }
        public int WishListId { get; set; }
        public WishList? WishList { get; set; }
    }
}
