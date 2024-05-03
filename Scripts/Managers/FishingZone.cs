using Godot;

namespace World 
{
    public partial class FishingZone : Interactable
    {
        [Export] public Biome Biome;

        public override void Interact() {
            GD.Print(Biome);
        }
    }
}