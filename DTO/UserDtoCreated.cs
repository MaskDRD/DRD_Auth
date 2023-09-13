using System.ComponentModel.DataAnnotations;

namespace auth.DTO
{
    public class UserDtoCreated
    {
        [Required(ErrorMessage = "Логин обязательное поле")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Пароль обязательное поле")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Почта обязательное поле")]
        public string? Email { get; set; }
    }
}
