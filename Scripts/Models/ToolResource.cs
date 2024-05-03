using Godot;
using World;

namespace Items
{
    [GlobalClass]
    public partial class ToolResource : KeyItem
    {
        [Export] public int Durrability;

        public ToolResource(
            string name, 
            string description, 
            int buyCost,
            int durrability) : base(name, description, buyCost)
        {
            Durrability = durrability;
        }
    }
}