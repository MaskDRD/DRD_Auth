using System.ComponentModel.DataAnnotations;

namespace auth.DTO
{
    public class UserDtoCreated
    {
        [Required]
        public string? Login { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? Email { get; set; }
    }
}
