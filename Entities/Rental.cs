using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("rental", Schema = "public")]
    public class Rental
    {
        [Key]
        [Column("rental_id")]
        public int RentalId { get; set; }

        [Required(ErrorMessage = "Rental date is required")]
        [Column("rental_date")]
        public DateTime RentalDate { get; set; }

        [Required(ErrorMessage = "Inventory ID is required")]
        [Column("inventory_id")]
        public int InventoryId { get; set; }

        [Required(ErrorMessage = "Customer ID is required")]
        [Column("customer_id")]
        public short CustomerId { get; set; }

        [Column("return_date")]
        public DateTime? ReturnDate { get; set; }

        [Required(ErrorMessage = "Staff ID is required")]
        [Column("staff_id")]
        public short StaffId { get; set; }

        [Required(ErrorMessage = "Last update is required")]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

    }
}
