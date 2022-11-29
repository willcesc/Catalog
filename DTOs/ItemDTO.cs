
using System.ComponentModel.DataAnnotations;

namespace Catalog.DTOs
{

    public record ItemDTO
    {

        public int id { get; init; }

        public string name { get; init; }

        public decimal price { get; init; }

        public DateTimeOffset createdDate { get; init; }

    }
}