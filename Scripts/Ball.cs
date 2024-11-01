using Godot;
using System;
using System.Security.Cryptography;

public partial class Ball : CharacterBody2D
{
	int Speed = 0;
	bool isActive = false;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		System.Diagnostics.Debug.WriteLine("Debug: Ball ready");
	}

    public override void _PhysicsProcess(double delta)
    {
		//System.Diagnostics.Debug.WriteLine("Debug: PhysProcess from Ball");

		if (Input.IsActionPressed("StartBall") && !isActive){
			Velocity = new Vector2(Speed,Speed*-1);
			Speed = 150;
			isActive = true;
		}

		var collision = MoveAndCollide(Velocity * (float)delta);
		
		if (collision is not null){
			Velocity = Velocity.Bounce(collision.GetNormal());
			var collider = collision.GetCollider();
			if (collider.HasMethod("Hit")){
				((Brick)collider).Hit();
			}
		}

		if (Velocity.Y > 0 && Velocity.Y < 100){
			Velocity = new Vector2(Speed, Speed*-1);
		}

		if (Velocity.X == 0){
			Velocity = new Vector2(Speed*-1,Speed);
		}

		
    }
}
