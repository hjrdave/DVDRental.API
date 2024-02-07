using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("country", Schema = "public")]
    public class Country
    {
        [Key]
        [Column("country_id")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "Country name is required")]
        [StringLength(50, ErrorMessage = "Country name cannot be longer than 50 characters")]
        [Column("country")]
        public string? CountryName { get; set; }

        [Required(ErrorMessage = "Last update is required")]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
