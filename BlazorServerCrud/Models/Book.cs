using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerCrud.Models
{
    [Table(name:"Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public required string Title { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public required string Author { get; set; }
        
        [Range(1, 10000, ErrorMessage = "El campo {0} debe estar entre {1} y {2}")]
        public int Pages { get; set; }

        [Range(1.00, 100000.00, ErrorMessage = "El campo {0} debe estar entre {1} y {2}")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
