using Catalog.DTOs;
using Catalog.Entities;
using Catalog.Repositories;

namespace Catalog.Models
{
    public class ItemModelSQL : IItemModel
    {

        private MySQLDbContextFactory mySQLDbContextFactory = new();
        private MySQLDbContext _db;

        string[] connStringDummy = { "ab", "ab" };

        public ItemModelSQL() // dbContext, Hvor skal vi få denne fra? Hvordan bliver den injected/instantieret SØG HOW TO PASS DBCONTEXT TO MODEL - Skal den ligge i samme repo some context?
        {
            _db = mySQLDbContextFactory.CreateDbContext(connStringDummy);
        }


        public void createItem(Item item)
        {
            _db.Add(item);
            _db.SaveChanges();
        }

        public void deleteItem(int id)
        {
            Item item = new() { id = id };
            _db.Remove(item);
            _db.SaveChanges();
        }

        public Item getItem(int id)
        {
            return _db.items.FirstOrDefault(x => x.id == id);
        }


        public IEnumerable<Item> getItems()
        {
            return _db.items.ToList();
        }

        public void updateItem(Item item, UpdateItemDTO updateItemDTO)
        {
            item.name = updateItemDTO.name;
            item.price = updateItemDTO.price;
        }
    }
}