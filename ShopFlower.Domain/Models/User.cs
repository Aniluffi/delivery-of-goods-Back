using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFlower.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        [Required]
        public string Login { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        public DateTime BirthOfDay { get; set; } 
        public List<RolesUser> Roles { get; set; } = new List<RolesUser>();
        public int CartId { get; set; } 
        public Cart? Cart { get; set; } = new Cart();
        public int WishListId { get; set; }
        public WishList? WishList { get; set; } = new WishList();
        public int AddressesId { get; set; }
        public Addresses? Addresses { get; set; } = new Addresses();
        public int OrderId { get; set; }
        public Orders? Orders { get; set; } = new Orders();


        public static IEnumerable<Exception> IsValidName(string name)
        {
            var error = new List<Exception>();
            if (string.IsNullOrEmpty(name))
            {
                error.Add(new ArgumentNullException("Имя не может быть null"));
                return error;
            }
            if (name.Length > 40) error.Add(new ArgumentException("Имя слишком длинное"));
            if (name.Length <= 0) error.Add(new ArgumentException("Имя слишком короткое"));
            return error != null ? error : new List<Exception>();
        }

        public static IEnumerable<Exception> IsValidSecondName(string SecondName)
        {
            var error = new List<Exception>();
            if (string.IsNullOrEmpty(SecondName))
            {
                error.Add(new ArgumentNullException("Фамилия не может быть null"));
                return error;
            }
            if (SecondName.Length > 40) error.Add(new ArgumentException("Фамилия слишком длинная"));
            if (SecondName.Length <= 0) error.Add(new ArgumentException("Фамилия слишком короткая"));
            return error != null ? error : new List<Exception>();
        }

        public static IEnumerable<Exception> IsValidEmail(string email)
        {
            var error = new List<Exception>();
            if (string.IsNullOrEmpty(email))
            {
                error.Add(new ArgumentNullException("Почта не может быть null"));
                return error;
            }
            return error != null ? error : new List<Exception>();
        }

        public static IEnumerable<Exception> IsValidLogin(string Login)
        {
            var error = new List<Exception>();
            if (string.IsNullOrEmpty(Login))
            {
                error.Add(new ArgumentNullException("Логин не может быть null"));
                return error;
            }

            if (Login.Length > 40) error.Add(new ArgumentException("Логин слишком длинный"));
            if (Login.Length <= 0) error.Add(new ArgumentException("Логин слишком короткий"));
            return error != null ? error : new List<Exception>();
        }

        public static IEnumerable<Exception> IsValidPassword(string Password)
        {
            var error = new List<Exception>();
            if (string.IsNullOrEmpty(Password))
            {
                error.Add(new ArgumentNullException("Пароль не может быть null"));
                return error;
            }
            if (Password.Length > 40) error.Add(new ArgumentException("Пароль слишком длинный"));
            if (Password.Length < 8) error.Add(new ArgumentException("Пароль слишком короткий"));
            return error != null ? error : new List<Exception>();
        }
        public static List<Exception> IsValidDayOfBirth(DateTime dateOfBirth)
        {
            var exceptions = new List<Exception>();

            var today = DateTime.Now;

            if (today < dateOfBirth)
                exceptions.Add(new ArgumentOutOfRangeException("День рождение не может быть в будущем!"));

            if (today.Year - dateOfBirth.Year >= 150)
                exceptions.Add(new ArgumentOutOfRangeException("Указан слишком большой возраст"));

            return exceptions;
        }
    }
}
