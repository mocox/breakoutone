using Godot;


public partial class MainGame : Node
{
	PackedScene brickScene = GD.Load<PackedScene>("res://Scenes/brick.tscn");
	int margin = 50;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		for (int col = 0; col < 13; col++)
		{
			for (int row = 0; row < 4; row++){
				var brick = brickScene.Instantiate<Brick>();
				brick.Position = new Vector2(margin + (col*40), margin +(row*10));
				AddChild(brick);
			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
