using Catalog.Entities;

namespace Catalog.Models
{

    public interface IItemModel
    {
        Item getItem(Guid id);
        IEnumerable<Item> getItems();

        void createItem(Item item);

        void updateItem(Item item);

        void deleteItem(Guid id);
    }
}