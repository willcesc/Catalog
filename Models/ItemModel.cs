using System.Net;
using System.Xml.Serialization;
using Catalog.Entities;
using Catalog.Repositories;

namespace Catalog.Models
{

    public class ItemModel : IItemModel
    {
        public InMemItemsRepository repo = new();
        public List<Item> items;

        // Constructor
        public ItemModel()
        {
            items = repo.getItems();
        }

        // Methods
        public IEnumerable<Item> getItems()
        {
            return items;

        }

        public Item getItem(int id)
        {
            return items.Where(item => item.id == id).SingleOrDefault();
        }

        public void createItem(Item newItem)
        {
            items.Add(newItem);
        }

        public void updateItem(Item newItem)
        {
            int index = items.FindIndex(item => item.id == newItem.id);
            items[index] = newItem;
        }

        public void deleteItem(int id)
        {
            int index = items.FindIndex(item => item.id == id);
            items.RemoveAt(index);
        }
    }
}

