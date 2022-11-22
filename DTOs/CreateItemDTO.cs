using System.ComponentModel.DataAnnotations;

namespace Catalog.DTOs
{
    public record CreateItemDTO
    {
        [Required]
        public string name { get; init; }
        [Required]
        [Range(1, 1000)] // We get an error code 400 if we go out of range or miss an argument + explanation
        public decimal price { get; init; }
    }

}