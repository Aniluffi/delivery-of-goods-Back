using System.ComponentModel.DataAnnotations;

namespace ShopFlower.Models
{
    public class Registr
    {
        [Required(ErrorMessage = "Это поле обязательно")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Это поле обязательно")]
        public string Login { get; set; } = string.Empty;
        [Required(ErrorMessage = "Это поле обязательно")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Это поле обязательно")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
