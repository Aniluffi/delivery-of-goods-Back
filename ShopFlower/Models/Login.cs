using System.ComponentModel.DataAnnotations;

namespace ShopFlower.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Это поле обязательно")]
        public string Email { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Это поле обязательно")]
        public string Password { get; set; } = string.Empty;
    }
}
