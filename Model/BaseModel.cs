using System.ComponentModel.DataAnnotations.Schema;

namespace auth.Model
{
    public class BaseModel
    {
        [Column("id")]
        public int Id { get; set; }
    }
}
