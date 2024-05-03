using Godot;

namespace Items {
    [GlobalClass]
    public partial class Item : Resource
    {
        [Export] public string Name;
        [Export] public string Description;
        [Export] public int BuyCost;
        [Export] public int SellCost;

        public Item(
            string name,
            string description,
            int buyCost,
            int sellCost)
        {
            Name = name;
            Description = description;
            BuyCost = buyCost;
            SellCost = sellCost;
        }
    }
}