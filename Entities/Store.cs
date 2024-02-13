using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("store", Schema = "public")]
    public class Store
    {
        [Key]
        [Column("store_id")]
        public int StoreId { get; set; }

        [Required(ErrorMessage = "Manager staff ID is required")]
        [Column("manager_staff_id")]
        public short ManagerStaffId { get; set; }

        [Required(ErrorMessage = "Address ID is required")]
        [Column("address_id")]
        public short AddressId { get; set; }

        [Required(ErrorMessage = "Last update is required")]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

    }
}
