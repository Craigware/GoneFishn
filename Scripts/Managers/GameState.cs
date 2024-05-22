using Godot;
using Items;
using Fish;

namespace World 
{
    public partial class GameState : Node
    {
        public int TotalSoldFish;
        // Might need to replace item with string or some sort of struct that has the item type and the name
        public Godot.Collections.Dictionary<Item, int> SoldFish;

        public void FishSold(Fish.Fish fish) {
            if (SoldFish.ContainsKey(fish)) {
                SoldFish[fish]++;
            } else {
                SoldFish.Add(fish, 1);
            }
            TotalSoldFish++;
        }

        
    }
}