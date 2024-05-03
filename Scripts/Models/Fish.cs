using System.Linq.Expressions;
using Godot;
using Items;
using World;

namespace World 
{
    public enum Biome 
    {
        RIVER,
        OCEAN,
        POND,
        LAKE,
        STREAM,
        CREAK
    }
}

namespace Fish 
{
    public enum Size
    {
        SMALL,
        MEDIUM,
        LARGE,
        BIGBIG
    }

    public enum WaterColumnLocation 
    {
        SURFACE,
        MID,
        BOTTOM
    }

    [GlobalClass]
    public partial class Fish : Item
    {
        [Export] public Biome Habitat;
        [Export] public WaterColumnLocation DepthFound;
        [Export] public Size Size;
        [Export] public Texture Icon;

        public Fish(
            string name, 
            Biome habitat, 
            string description, 
            int buyCost, 
            int sellCost) : base(name, description, buyCost, sellCost)
        {
            Habitat = habitat;
        }
    }
}