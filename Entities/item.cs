namespace Catalog.Entities{

    public record Item{

        public Guid id { get; init; }

        public string name { get; init; } 

        public decimal price { get; init; }

        public DateTimeOffset createdDate  { get; init; }

    }

}