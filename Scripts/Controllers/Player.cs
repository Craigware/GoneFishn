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
        public int Stamina = 100;
        [Export] public int Speed = 3;

        public override void _Ready()
        {
            Inventory = new();
        }

        public override void _Input(InputEvent @event) {
            if (Input.IsActionJustPressed("Interact")) {
                var collider = GetNode<RayCast3D>("./InteractCheck").GetCollider();
                if (collider is Interactable interactable) {
                    interactable.Interact(this);
                }
            }
        }

        public override void _PhysicsProcess(double delta) {
            
        }

        public override void _Process(double delta)
        {
            if (Input.GetVector("Left", "Right", "Backward", "Forward") != Vector2.Zero) {
                var vector = Input.GetVector("Left", "Right", "Forward", "Backward");
                Vector3 xDir = vector.X * Transform.Basis.X;
                Vector3 zDir = vector.Y * Transform.Basis.Z;

                Vector3 direction = (xDir + zDir).Normalized();

                var speed = (Input.IsActionPressed("Sprint")) ? Speed * 1.75 : Speed; 

                Velocity = direction * (float) speed;
                MoveAndSlide();
            }

            if (Input.GetVector("CamLeft", "CamRight", "CamUp", "CamDown") != Vector2.Zero) {
                var vector = Input.GetVector("CamLeft", "CamRight", "CamUp", "CamDown").Normalized();
                Rotation += new Vector3(0, -vector.X, 0) * (float) delta * GetNode<Settings.Settings>("/root/Settings").controlSettings.CameraSensitivity;// replace 2 with camerasense
            }
        }

        public void StartFishing() {
            
        }
    }
}