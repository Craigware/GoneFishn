using Godot;

namespace World
{
    public enum InteractionType
    {
        FishingLocation,
        Shop,
        Player,
        Boat
    }

    interface IInteractable
    {
        void Interact(Entity.Player interactor);
    }

    public abstract partial class Interactable : Area3D, IInteractable
    {
        [Export] public InteractionType InteractionType;

        public abstract void Interact(Entity.Player interactor);
    }
}