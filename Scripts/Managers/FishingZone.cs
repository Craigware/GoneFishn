using System;
using Godot;
using Items;

namespace World 
{
    public partial class FishingZone : Interactable
    {
        [Export] public Biome Biome;
        [Export] public Fish.Fish[] AvaiableFish;

        public override void Interact(Entity.Player interactor) {
            if (Biome == Biome.OCEAN) {

            } else {
                var randomInt = new Random().Next(0, AvaiableFish.Length-1);
                Fish.Fish fish = AvaiableFish[randomInt];
                interactor.Inventory.Add(fish, 1);
            }
        }
    }
}