using Godot;
using System;
public partial class Paddle : CharacterBody2D
{
	Vector2 direction = Vector2.Zero;

	float paddleWidth;

	[Export]
	int speed = 400;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		System.Diagnostics.Debug.WriteLine("Debug: Paddle ready");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	
		if (Input.IsActionPressed("left")){
			direction = Vector2.Left;
		}
		else if (Input.IsActionPressed("right")){
			direction = Vector2.Right;
		}
		else{
			direction = Vector2.Zero;
		}
		
		Velocity = direction * speed;
		MoveAndSlide();
	}	
	
		

}
