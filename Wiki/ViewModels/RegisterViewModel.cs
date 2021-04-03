using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Wiki.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string EMail { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        public string Пароль { get; set; }

        [Required]
        [Compare("Пароль", ErrorMessage = "Пароли не совпадают")]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }

        [Required]
        [Display(Name = "Дата рождения")]
        public DateTime ДатаРождения { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string Фамилия { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string Имя { get; set; }

        [Required]
        [Display(Name = "Отчество")]
        public string Отчество { get; set; }

        [Required]
        [Display(Name = "Пол")]
        public string Пол { get; set; }
    }
}
