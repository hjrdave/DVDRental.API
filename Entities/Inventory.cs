using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("inventory", Schema = "public")]
    public class Inventory
    {
        [Key]
        [Column("inventory_id")]
        public int InventoryId { get; set; }

        [Required(ErrorMessage = "Film ID is required")]
        [Column("film_id")]
        public short FilmId { get; set; }

        [Required(ErrorMessage = "Store ID is required")]
        [Column("store_id")]
        public short StoreId { get; set; }

        [Required(ErrorMessage = "Last update is required")]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("FilmId")]
        public virtual Film? Film { get; set; }
    }
}
