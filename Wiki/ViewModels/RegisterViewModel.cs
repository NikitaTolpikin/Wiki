using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Wiki.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Не указан электронный адрес")]
        [EmailAddress (ErrorMessage = "Некорректный адрес")]
        [Display(Name = "Email")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Не указан пероль")]
        [Display(Name = "Пароль")]
        public string Пароль { get; set; }

        [Compare("Пароль", ErrorMessage = "Пароли не совпадают")]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Не указана дата рождения")]
        [Display(Name = "Дата рождения")]
        public DateTime ДатаРождения { get; set; }

        [Required(ErrorMessage = "Не указана фамилия")]
        [Display(Name = "Фамилия")]
        public string Фамилия { get; set; }

        [Required(ErrorMessage = "Не указано имя")]
        [Display(Name = "Имя")]
        public string Имя { get; set; }

        [Required(ErrorMessage = "Не указано отчетство")]
        [Display(Name = "Отчество")]
        public string Отчество { get; set; }

        [Required(ErrorMessage = "Не указан пол")]
        [Display(Name = "Пол")]
        public string Пол { get; set; }
    }
}
