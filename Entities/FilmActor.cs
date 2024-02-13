using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("film_actor", Schema = "public")]
    public class FilmActor
    {
        [Key]
        [Column("actor_id")]
        public short ActorId { get; set; }

        [Column("film_id")]
        public short FilmId { get; set; }

        [Required(ErrorMessage = "Last update is required")]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

    }
}
