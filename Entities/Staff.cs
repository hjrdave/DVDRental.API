using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("staff", Schema = "public")]
    public class Staff
    {
        [Key]
        [Column("staff_id")]
        public int StaffId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(45, ErrorMessage = "First name cannot be longer than 45 characters")]
        [Column("first_name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(45, ErrorMessage = "Last name cannot be longer than 45 characters")]
        [Column("last_name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Address ID is required")]
        [Column("address_id")]
        public short AddressId { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Store ID is required")]
        [Column("store_id")]
        public short StoreId { get; set; }

        [Required(ErrorMessage = "Active status is required")]
        [Column("active")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(16, ErrorMessage = "Username cannot be longer than 16 characters")]
        [Column("username")]
        public string? Username { get; set; }

        [Column("password")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Last update is required")]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [Column("picture")]
        public byte[]? Picture { get; set; }

    }
}
