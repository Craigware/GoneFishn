using Godot;

namespace UI
{
    public partial class MainMenu : Menu {
        public void Quit() {
            GetTree().Quit();
        }

        public void Play() {
            GetTree().ChangeSceneToFile("res://Scenes/Levels/Prototype.tscn");
        }

        public void Settings() {

        }

        public override void Alt() {}

        public override void Pro() {}

        public override void Decline() {
            
        }
    }
}