using Godot;
using Items;
using World;

namespace Entity 
{ 
    public partial class Player : CharacterBody3D
    {
        public Inventory Inventory;

        public string PlayerName {
            get { return playerName; }
            set { 
                playerName = value;
            }
        }
        private string playerName;

        public long PlayerID = 1;
        [Export] public int Speed = 5;


        public override void _Input(InputEvent @event) {
            if (Input.IsActionJustPressed("Interact")) {
                var collider = GetNode<RayCast3D>("./InteractCheck").GetCollider();
                if (collider is Interactable interactable) {
                    interactable.Interact();
                }
            }
        }

        public override void _PhysicsProcess(double delta) {
            if (Input.GetVector("Left", "Right", "Backward", "Forward") != Vector2.Zero) {
                var vector = Input.GetVector("Left", "Right", "Forward", "Backward").Normalized();
                float xDir = vector.X;
                float zDir = vector.Y;

                Vector3 direction = new(xDir, 0, zDir);
                Velocity = direction * Speed;
                MoveAndSlide();
            }
        }

        public void StartFishing() {
            
        }
    }
}