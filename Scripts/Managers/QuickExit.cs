using Godot;
using System;

public partial class QuickExit : Node
{
    public override void _Input(InputEvent @event) {
        if (Input.IsActionJustPressed("QuickExit")) {
            GetTree().Quit();
        }
    }
}
