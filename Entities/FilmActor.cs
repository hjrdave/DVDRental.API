using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("film_actor", Schema = "public")]
    public class FilmActor
    {
        [Key]
        [Column("actor_id")]
        public int ActorId { get; set; }

        [Column("film_id")]
        public int FilmId { get; set; }

        [Required(ErrorMessage = "Last update is required")]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

    }
}
