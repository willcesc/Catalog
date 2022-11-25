using Catalog.Entities;
namespace Catalog.Repositories
{

    public class InMemItemsRepository
    {
        public List<Item> items = new()
    {
            new Item{id = 1, name = "Potion",price = 9, createdDate = DateTimeOffset.UtcNow},
            new Item{id = 2, name = "Iron Sword",price = 20, createdDate = DateTimeOffset.UtcNow},
            new Item{id = 3, name = "Bronze Shield",price = 18, createdDate = DateTimeOffset.UtcNow  }
        };



        public List<Item> getItems()
        {
            return items;
        }
    }




}

