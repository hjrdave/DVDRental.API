using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("film", Schema = "public")]
    public class Film
    {
        [Key]
        [Column("film_id")]
        public int FilmId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(255, ErrorMessage = "Title cannot be longer than 255 characters")]
        [Column("title")]
        public string? Title { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("release_year")]
        public short? ReleaseYear { get; set; }

        [Required(ErrorMessage = "Language ID is required")]
        [Column("language_id")]
        public short LanguageId { get; set; }

        [Required(ErrorMessage = "Rental duration is required")]
        [Column("rental_duration")]
        public short RentalDuration { get; set; }

        [Required(ErrorMessage = "Rental rate is required")]
        [Column("rental_rate")]
        public decimal RentalRate { get; set; }

        [Column("length")]
        public short? Length { get; set; }

        [Required(ErrorMessage = "Replacement cost is required")]
        [Column("replacement_cost")]
        public decimal ReplacementCost { get; set; }

        // [Column("rating")]
        // public MpaaRating? Rating { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [Column("special_features")]
        public string[]? SpecialFeatures { get; set; }

        // [Required(ErrorMessage = "Fulltext is required")]
        // [Column("fulltext")]
        // public string? Fulltext { get; set; }

    }

    public enum MpaaRating
    {
        G,
        PG,
        PG13,
        R,
        NC17
    }
}
