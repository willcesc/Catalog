using Catalog.Entities;
namespace Catalog.Repositories
{

    public class InMemItemsRepository
    {
        public List<Item> items = new()
    {
            new Item{id = Guid.NewGuid(), name = "Potion",price = 9, createdDate = DateTimeOffset.UtcNow},
            new Item{id = Guid.NewGuid(), name = "Iron Sword",price = 20, createdDate = DateTimeOffset.UtcNow},
            new Item{id = Guid.NewGuid(), name = "Bronze Shield",price = 18, createdDate = DateTimeOffset.UtcNow  }
        };



        public List<Item> getItems()
        {
            return items;
        }
    }




}

