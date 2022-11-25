using Catalog.Entities;

namespace Catalog.Models
{

    public interface IItemModel
    {
        Item getItem(int id);
        IEnumerable<Item> getItems();

        void createItem(Item item);

        void updateItem(Item item);

        void deleteItem(int id);
    }
}