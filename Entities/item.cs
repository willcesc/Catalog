using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalog.Entities
{

    public record Item
    {

        public int id { get; init; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string name { get; init; }

        public decimal price { get; init; }

        public DateTimeOffset createdDate { get; init; }

    }

}