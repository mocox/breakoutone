using Godot;
using System;

public partial class Ball : CharacterBody2D
{
	int Speed = 100;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		System.Diagnostics.Debug.WriteLine("Debug: Ball ready");

		Velocity = new Vector2(Speed,Speed*-1);
		
	}

    public override void _PhysicsProcess(double delta)
    {
		//System.Diagnostics.Debug.WriteLine("Debug: PhysProcess from Ball");

		var collision = MoveAndCollide(Velocity * (float)delta);
		if (collision is not null){
			Velocity = Velocity.Bounce(collision.GetNormal());
		}

		if (Velocity.Y > 0 && Velocity.Y < 100){
			Velocity = new Vector2(Speed, Speed*-1);
		}

		if (Velocity.X == 0){
			Velocity = new Vector2(Speed*-1,Speed);
		}
    }
}
