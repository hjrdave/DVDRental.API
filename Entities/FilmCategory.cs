using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("film_category", Schema = "public")]
    public class FilmCategory
    {
        [Key]
        [Column("film_id")]
        public short FilmId { get; set; }

        [Column("category_id")]
        public short CategoryId { get; set; }

        [Required(ErrorMessage = "Last update is required")]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

        [ForeignKey("FilmId")]
        public virtual Film? Film { get; set; }
    }
}
