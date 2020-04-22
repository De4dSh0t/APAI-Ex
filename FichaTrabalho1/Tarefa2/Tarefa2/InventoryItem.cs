namespace Tarefa2
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(string name, int weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Name[{Name}] | Weight[{Weight}] | Quantity[{Quantity}]";
        }
    }
}