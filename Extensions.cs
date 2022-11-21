using Catalog.DTOs;
using Catalog.Entities;

namespace Catalog{
    public static class Extensions{
        public static ItemDTO asDTO(this Item item){
            return new ItemDTO{
      id = item.id,
      name = item.name,
      price = item.price,
      createdDate = item.createdDate
    
        };
    }
}
}