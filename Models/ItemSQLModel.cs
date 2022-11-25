using Catalog.Entities;
using Catalog.Models;
using Catalog.Repositories;

namespace Catalog.Models
{
    public class ItemSQLModel : IItemModel
    {

        private MySQLDbContextFactory mySQLDbContextFactory = new();
        private MySQLDbContext _db;

        string[] connStringDummy = { "ab", "ab" };

        public ItemSQLModel() // dbContext, Hvor skal vi få denne fra? Hvordan bliver den injected/instantieret SØG HOW TO PASS DBCONTEXT TO MODEL - Skal den ligge i samme repo some context?
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
            throw new NotImplementedException();
        }

        public Item getItem(int id)
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