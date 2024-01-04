using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeladatAPI.Models
{

    public class Book
    {
        [Key]
        [Column("BookID", TypeName = "varchar(36)")]
        [MaxLength(36)]
        public Guid BookId { get; set; } = Guid.NewGuid();

        [Column("Title", TypeName = "varchar(100)")]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [Column("PublicationYear", TypeName = "int(4)")]
        [MaxLength(4)]
        public int PublicationYear { get; set; }

        [Column("Genre", TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string Genre { get; set; } = null!;

        [ForeignKey("Author")]
        [Column("AuthorID", TypeName = "varchar(36)")]
        [MaxLength(36)]
        public Guid AuthorId { get; set; }

        public virtual Author Author { get; set; } = null!;
    }
}