using Godot;
using System;

public partial class Sprite : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	public override void _Input(InputEvent @event)
	{
		float AMOUNT = 15;
		if (@event is InputEventKey keyEvent && keyEvent.Pressed)
		{
			switch (keyEvent.Keycode)
			{
				case Key.W:
					this.Position += new Vector2(0, -AMOUNT);
					break;
				case Key.S:
					this.Position += new Vector2(0, AMOUNT);
					break;
				case Key.A:
					this.Position += new Vector2(-AMOUNT, 0);
					break;
				case Key.D:
					this.Position += new Vector2(AMOUNT, 0);
					break;
				case Key.Space:
					this.Position = new Vector2(-10, 0);
					break;
			}
		}

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// fill in later
	}
}

// Damien Foo
