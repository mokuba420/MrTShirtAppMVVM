using MrTshirtAppMVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MrTshirtAppMVVM.Services.Interface
{
   public class TShirtDatabase : IDatabase
    {

        private SQLiteAsyncConnection database;

        public TShirtDatabase()
        {
            string dbPath = GetDbPath();

            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<TShirttable>().Wait();

            SeedData();
        }
        private string GetDbPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TShirttable.db3");
        }

        public Task<List<TShirttable>> GetTShirttable()
        {
            return database.Table<TShirttable>().ToListAsync();
        }

        public async Task<TShirttable> GetLatestTShirttable()
        {
            int count = await database.Table<TShirttable>().CountAsync();
            var latest = await database.Table<TShirttable>().Where(x => x.ID == count).FirstOrDefaultAsync();

            return latest;
        }

        public Task<int> DeleteProduct(TShirttable TShirttable)
        {
            return database.DeleteAsync(TShirttable);
        }

        public async Task<int> UpdateProduct(TShirttable TShirttable)
        {

            return await database.UpdateAsync(TShirttable);

        }

        public async Task<List<TShirttable>> GetSortedData()
        {
            return await database.Table<TShirttable>().OrderByDescending(o => o.Size).ToListAsync();
        }

        private async void SeedData()
        {
            if (await database.Table<TShirttable>().CountAsync() == 0)
            {
                var TShirttable = new TShirttable
                {
                    Name = "Xamarin",
                    Size = 20,
                    ShippingAddress = "Software"
                   
                };
                await database.InsertAsync(TShirttable);
            }




        }

    }
}
