using System;
using System.Collections.Generic;
using System.Text;

namespace Tarefa2
{
    public class Inventory
    {
        public List<InventoryItem> Items = new List<InventoryItem>();

        public void AddToList(InventoryItem item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            string list = String.Empty;

            for (int i = 0; i < Items.Count; i++)
            {
                list = $"Item nº{i+1}: {Items[i]}";
            }

            return list;
        }
    }
}