using Catalog.DTOs;
using Catalog.Entities;

namespace Catalog.Models
{

    public interface IItemModel
    {
        Task<Item> getItemAsync(int id);
        IEnumerable<Item> getItems();

        void createItem(Item item);

        void updateItem(Item item, UpdateItemDTO updateItemDTO);

        void deleteItem(int id);
    }
}