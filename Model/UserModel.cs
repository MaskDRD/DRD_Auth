using System.ComponentModel.DataAnnotations.Schema;

namespace auth.Model
{
    [Table("users")]
    public class UserModel : BaseModel
    {
        [Column("login")]
        public string? Login { get; set; }

        [Column("password")]
        public string? Password { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("check_active")]
        public bool CheckActive { get; set; } = true;

        [Column("check_conf_email")]
        public bool CheckConfEmail { get; set; } 
    }
}
