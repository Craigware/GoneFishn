using Godot;


namespace Items 
{
    [GlobalClass]
    public partial class KeyItem : Resource
    {
        [Export] public string Name;
        [Export] public string Description;
        [Export] public int BuyCost;
        
        public KeyItem(string name, string description, int buyCost)
        {
            Name = name;
            Description = description;
            BuyCost = buyCost;
        }
    }
}