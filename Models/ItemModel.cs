using System.Net;
using System.Xml.Serialization;
using Catalog.Entities;
using Catalog.Repositories; 

namespace Catalog.Models {

    public class ItemModel : IItemModel{
        public InMemItemsRepository repo = new();
        public List<Item> items;

        public ItemModel()
        {
            items = repo.getItems();
        }





        public IEnumerable<Item> getItems()
        {
            return items;

        }

        public Item getItem(Guid id)
        {
            return items.Where(item => item.id == id).SingleOrDefault();
        }

    }
}

