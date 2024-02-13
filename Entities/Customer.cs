using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("customer", Schema = "public")]
    public class Customer
    {
        [Key]
        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Store ID is required")]
        [Column("store_id")]
        public short StoreId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(45, ErrorMessage = "First name cannot be longer than 45 characters")]
        [Column("first_name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(45, ErrorMessage = "Last name cannot be longer than 45 characters")]
        [Column("last_name")]
        public string? LastName { get; set; }

        [StringLength(50, ErrorMessage = "Email cannot be longer than 50 characters")]
        [Column("email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Address ID is required")]
        [Column("address_id")]
        public short AddressId { get; set; }

        [Required(ErrorMessage = "Active bool is required")]
        [Column("activebool")]
        public bool ActiveBool { get; set; }

        [Required(ErrorMessage = "Create date is required")]
        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [Column("active")]
        public int Active { get; set; }

    }
}
