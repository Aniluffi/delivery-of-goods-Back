﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFlower.Domain.ViewModels.LoginAndRegistration
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Укажите имя 3-20 символов")]
        [MaxLength(20,ErrorMessage = "Имя должно иметь длину меньше 20 символов")]
        [MinLength(3,ErrorMessage = "Имя доолжно иметь болле 3 символов")]
        public string Login {  get; set; }

        [EmailAddress(ErrorMessage = "Некорректный адрес электроной почты")]
        [Required(ErrorMessage = "Укажите почту")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Укажите пароль")]
        [MinLength(6,ErrorMessage = "Пароль не может быть меньше 6 символов")]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string PasswordConfirm { get; set; }
    }
}