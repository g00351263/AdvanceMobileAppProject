using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace App5
{
    public class TodoItemDatabase
    {
        readonly SQLiteAsyncConnection database;

        public TodoItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Contact>().Wait();
        }

        public Task<List<Contact>> GetItemsAsync()
        {
            return database.Table<Contact>().ToListAsync();
        }

        public Task<List<Contact>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Contact>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<Contact> GetItemAsync(int id)
        {
            return database.Table<Contact>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Contact item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Contact item)
        {
            return database.DeleteAsync(item);
        }
    }
}

