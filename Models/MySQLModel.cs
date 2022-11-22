using Catalog.Entities;
using Catalog.Models;

namespace Catalog.Repositories
{
    public class MySQLRepository : IItemModel
    {
        public void createItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void deleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item getItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> getItems()
        {
            throw new NotImplementedException();
        }

        public void updateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}