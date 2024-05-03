using System.Collections.Generic;

namespace Items {
    public class Inventory
    {
        public class InventoryItem 
        {
            public Item Item;
            public int Count;

            public InventoryItem(Item item, int count)
            {
                Item = item;
                Count = count;
            }
        }

        public List<InventoryItem> Items { get { return items; } }
        public List<KeyItem> KeyItems { get { return keyItems; } }

        private List<Tool> tools = new();
        private List<InventoryItem> items = new();
        private List<KeyItem> keyItems = new();

        public void Add(Item newItem, int amount) {
            foreach (var inventoryItem in items) {
                if (inventoryItem.Item == newItem) {  
                    inventoryItem.Count += amount;
                    return;
                }
            }

            items.Add(new InventoryItem(newItem, amount));
        }

        public void Remove(Item item, int amount) {
            foreach (var inventoryItem in items) {
                if (inventoryItem.Item == item) {  
                    inventoryItem.Count -= amount;
                    if (inventoryItem.Count <= 0) items.Remove(inventoryItem);
                }
            }
        }
 
    }
}