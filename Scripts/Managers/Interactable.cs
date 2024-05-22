using Godot;

namespace World
{
    interface IInteractable
    {
        void Interact(Entity.Player interactor);
    }

    public abstract partial class Interactable : Area3D, IInteractable
    {
        public abstract void Interact(Entity.Player interactor);

        public override string ToString() {
            return "\n" + GetType() + "\n Path: " + GetPath() + "\n ";
        }
    }
}