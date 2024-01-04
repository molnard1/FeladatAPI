using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeladatAPI.Models
{
    public class Author
    {
        [Key]
        [Column("AuthorID", TypeName = "varchar(36)")]
        [MaxLength(36)]
        public Guid AuthorId { get; set; } = Guid.NewGuid();

        [Column("FirstName", TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;

        [Column("LastName", TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}