using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("city", Schema = "public")]
    public class City
    {
        [Key]
        [Column("city_id")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "City name is required")]
        [StringLength(50, ErrorMessage = "City name cannot be longer than 50 characters")]
        [Column("city")]
        public string? CityName { get; set; }

        [Required(ErrorMessage = "Country ID is required")]
        [Column("country_id")]
        public short CountryId { get; set; }

        [Required(ErrorMessage = "Last update is required")]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
