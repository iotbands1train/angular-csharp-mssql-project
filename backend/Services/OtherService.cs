using System;
using System.Collections.Generic;
using System.Linq;
using backend.Models;

namespace backend.Services
{
    public class OtherService
    {
        private readonly List<OtherModel> _items;

        public OtherService()
        {
            // Initialize the list of items (this could be replaced with data from a database)
            _items = new List<OtherModel>
            {
                new OtherModel { Id = 1, Name = "Item 1", Description = "Description of item 1" },
                new OtherModel { Id = 2, Name = "Item 2", Description = "Description of item 2" },
                // Add more sample items if needed
            };
        }

        public IEnumerable<OtherModel> GetAllItems()
        {
            return _items;
        }

        public OtherModel GetItemById(int id)
        {
            return _items.FirstOrDefault(item => item.Id == id);
        }

        public void AddItem(OtherModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            item.Id = _items.Any() ? _items.Max(i => i.Id) + 1 : 1;
            _items.Add(item);
        }

        public void UpdateItem(OtherModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            var existingItem = _items.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Name = item.Name;
                existingItem.Description = item.Description;
                // Update other properties as needed
            }
        }

        public void DeleteItem(OtherModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _items.Remove(item);
        }
    }
}
