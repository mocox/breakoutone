using Godot;
using System;

public partial class OutOfBounds : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnOutOfBounds(CharacterBody2D body){
		
		// Get the ball
		if (body is Ball){
			System.Diagnostics.Debug.WriteLine("Debug: Out of bounds");
			
		}
		
	}


}
