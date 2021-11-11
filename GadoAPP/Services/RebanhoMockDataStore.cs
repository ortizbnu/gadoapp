using GadoAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GadoAPP.Services
{
    public class RebanhoMockDataStore : IDataStore<Rebanho>
    {
        readonly List<Rebanho> items;

        public RebanhoMockDataStore()
        {
            items = new List<Rebanho>()
            {
                new Rebanho { Id = Guid.NewGuid().ToString(), Text = "112113", Description="Vaca Red Angus" },
                new Rebanho { Id = Guid.NewGuid().ToString(), Text = "112119", Description="Vaca Black Angus" },
                new Rebanho { Id = Guid.NewGuid().ToString(), Text = "112201", Description="Vaca Angus" },
                new Rebanho { Id = Guid.NewGuid().ToString(), Text = "115171", Description="Boi Angus" },
                new Rebanho { Id = Guid.NewGuid().ToString(), Text = "120501", Description="Novilha Angus" },
                new Rebanho { Id = Guid.NewGuid().ToString(), Text = "132201", Description="Touro Black Angus." }
            };
        }

        public async Task<bool> AddItemAsync(Rebanho item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Rebanho item)
        {
            var oldItem = items.Where((Rebanho arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Rebanho arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Rebanho> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Rebanho>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}