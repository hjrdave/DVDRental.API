using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("address", Schema = "public")]
    public class Address
    {
        [Key]
        [Column("address_id")]
        public int AddressId { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(50, ErrorMessage = "Address cannot be longer than 50 characters")]
        [Column("address")]
        public string? AddressLine { get; set; }

        [StringLength(50, ErrorMessage = "Address2 cannot be longer than 50 characters")]
        [Column("address2")]
        public string? AddressLine2 { get; set; }

        [Required(ErrorMessage = "District is required")]
        [StringLength(20, ErrorMessage = "District cannot be longer than 20 characters")]
        [Column("district")]
        public string? District { get; set; }

        [Required(ErrorMessage = "City ID is required")]
        [Column("city_id")]
        public int CityId { get; set; } // Change data type to int

        [StringLength(10, ErrorMessage = "Postal code cannot be longer than 10 characters")]
        [Column("postal_code")]
        public string? PostalCode { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [StringLength(20, ErrorMessage = "Phone cannot be longer than 20 characters")]
        [Column("phone")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Last update is required")]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("CityId")]
        public virtual City? City { get; set; }
    }
}
