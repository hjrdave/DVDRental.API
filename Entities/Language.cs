using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("language", Schema = "public")]
    public class Language
    {
        [Key]
        [Column("language_id")]
        public int LanguageId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, ErrorMessage = "Name cannot be longer than 20 characters")]
        [Column("name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Last update is required")]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
