using Entity;
using Godot;
using Items;

namespace World 
{
    public partial class ShoppingZone : Interactable
    {
        public int Wallet = 400;
        public KeyItem[] Selling;

        public override void Interact(Player interactor)
        {
            // Show shop UI
            // Add bought items to inventory
            // Remote sold items
            GD.Print(this, "Interacted.");
        }
    }
}