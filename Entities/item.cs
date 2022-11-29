using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalog.Entities
{

    public class Item
    {

        public int id { get; init; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string name { get; set; }

        public decimal price { get; set; }

        public DateTimeOffset createdDate { get; init; }

    }

}