using Catalog.Entities;

namespace Catalog.Models{

    public interface IItemModel
    {
        Item GetItem(Guid id);
        IEnumerable<Item> getItems();
    }}