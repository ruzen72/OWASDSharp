using Godot;
using System;

public partial class Game_rules : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("exit"))
		{
			GetTree().Quit();
		}
	
	}
	
	private void _on_timer_timeout()
	{
		
		ChangeScene("res://Scenes/main_menu.tscn");
	}
	
	private void ChangeScene(string scenePath)
	{
		var sceneTree = GetTree();
		var newScene = GD.Load<PackedScene>(scenePath);
		
		if (newScene != null)
		{
			sceneTree.ChangeSceneToPacked(newScene);
		}
		else
		{
			GD.PrintErr("Failed to load scene: " + scenePath);
		}
	}
}






