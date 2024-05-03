 using Godot;

namespace Items {
    interface ITool
    {
        public void Repair();
        public void Break();
        public void Use();
    }

    public partial class Tool : ITool
    {
        private ToolResource Resource { get; }
        private bool Broken;
        public int CurrentDurability {
            get { return currentDurability; }
            set {
                currentDurability = value;
                if (currentDurability <= 0) {
                    Break();
                }
            }
        }
 
        private int currentDurability;

        public Tool(ToolResource resource) {
            Resource = resource;
            Broken = false;
            CurrentDurability = Resource.Durrability;
        }

        public virtual void Use() {}

        public void Break() {
            CurrentDurability = 0;
            Broken = true;
        }

        public void Repair() {
            CurrentDurability = Resource.Durrability;
            Broken = false;
        }
    }
}