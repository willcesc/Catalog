using System.ComponentModel.DataAnnotations;

namespace Catalog.DTOs
{
    public record UpdateItemDTO
    {
        public string name { get; set; }
        [Range(0, 1000)] // We get an error code 400 if we go out of range or miss an argument + explanation
        public decimal price { get; set; }
    }
}