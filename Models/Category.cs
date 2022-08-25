using System.ComponentModel.DataAnnotations;

namespace Ntuma.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrdeer { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
