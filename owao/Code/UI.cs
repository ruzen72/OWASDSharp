using Godot;
using System;

public partial class UI : Control
{
	private CanvasItem cameraOutput;
	private CanvasItem changeCameraButton;
	private AudioStreamPlayer soundPlayer;

	public override void _Ready()
	{
		// Get nodes and assign them to variables
		cameraOutput = GetNode<CanvasItem>("Camera_Output");
		changeCameraButton = GetNode<CanvasItem>("Change_Camera_Button");
		soundPlayer = GetNode<AudioStreamPlayer>("Sounds");

		// Ensure nodes are found
		if (cameraOutput == null || changeCameraButton == null || soundPlayer == null)
		{
			GD.PrintErr("One or more nodes could not be found");
		}
	}

	// Method to toggle visibility and play sound when mouse enters the button area
	private void _on_cameras_button_mouse_entered()
	{
		if (cameraOutput != null) cameraOutput.Visible = !cameraOutput.Visible;
		if (changeCameraButton != null) changeCameraButton.Visible = !changeCameraButton.Visible;
		
		if (soundPlayer != null) soundPlayer.Play();
		else GD.PrintErr("Sound player not found");
	}
}
