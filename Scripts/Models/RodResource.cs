using Godot;
using Items;

namespace Tools 
{
    [GlobalClass]
    public partial class RodResource : ToolResource
    {
        [Export] public Godot.Collections.Array<Fish.Size> FishSizes;
        [Export] public Godot.Collections.Array<Fish.WaterColumnLocation> RodDepth;

        public RodResource(
            string name,
            string description,
            int buyCost,
            int durrability,
            Godot.Collections.Array<Fish.Size> fishSizes,
            Godot.Collections.Array<Fish.WaterColumnLocation> rodDepth) : base(name, description, buyCost, durrability)
        {
            FishSizes = fishSizes;
            RodDepth = rodDepth;
        }
    }
}