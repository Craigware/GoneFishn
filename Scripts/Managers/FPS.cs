using Godot;
using System;

public partial class FPS : RichTextLabel
{
	public override void _Process(double delta)
	{
        Text = Engine.GetFramesPerSecond().ToString() + " FPS";
	}
}
