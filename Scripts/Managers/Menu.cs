using Godot;


namespace UI 
{
    public interface IMenu
    {
        public void Accept();
        public void Decline();
        public void Alt();
        public void Pro();
    }

    public enum MenuType 
    {
        VERT,
        GRID
    }

    public abstract partial class Menu : Control, IMenu
    {
        [Export] private Godot.Collections.Array<Control> Options;
        public Control SelectedOption;
        private int SelectedIndex;
        public MenuType MenuType;
        
        private Menu previousMenu;
        public bool Active = true;

        public override void _Ready() {
            SelectedIndex = 0;
            SelectedOption = Options[SelectedIndex];
            Options[0].GrabFocus();
        }

        public override void _Input(InputEvent @event) {
            if (!Active) return;
            if (Input.IsActionJustPressed("Backward")) {
                SelectedIndex++;
                if (SelectedIndex > Options.Count-1) {
                    SelectedIndex = 0;
                }
                
                SelectedOption = Options[SelectedIndex];
                SelectedOption.GrabFocus();
            } 

            if (Input.IsActionJustPressed("Forward")) {
                SelectedIndex--;
                if (SelectedIndex < 0) {
                    SelectedIndex = Options.Count - 1;
                }

                SelectedOption = Options[SelectedIndex];
                SelectedOption.GrabFocus();
            }

            if (Input.IsActionJustPressed("Interact")) Accept();
            if (Input.IsActionJustPressed("Roll")) Decline();
            if (Input.IsActionJustPressed("Inventory")) Alt();
            if (Input.IsActionJustPressed("Attack")) Pro();
        }

        public virtual void Accept() {
            if (SelectedOption is Button but) {
                but.EmitSignal("button_down");
            }
        }

        public abstract void Decline();
        public abstract void Alt();
        public abstract void Pro();
    }
}

