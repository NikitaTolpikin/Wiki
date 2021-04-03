using System.ComponentModel.DataAnnotations;

namespace Wiki.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Не указан Email")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Пароль { get; set; }
    }
}
