using Godot;
using System;

public partial class Camera_Output : Sprite2D
{
	// Array to hold camera textures
	public Texture2D[] cameraTextures = new Texture2D[7]; 
	public AudioStreamPlayer soundPlayer;
	
	public override void _Ready()
	{
		cameraTextures[0] = (Texture2D)ResourceLoader.Load("res://Sprites/Камеры/camera 1.jpg");
		cameraTextures[1] = (Texture2D)ResourceLoader.Load("res://Sprites/Камеры/camera 2.jpg");
		cameraTextures[2] = (Texture2D)ResourceLoader.Load("res://Sprites/Камеры/camera 3.jpg");
		cameraTextures[3] = (Texture2D)ResourceLoader.Load("res://Sprites/Камеры/camera 4.jpg");
		cameraTextures[4] = (Texture2D)ResourceLoader.Load("res://Sprites/Камеры/camera 5.jpg");
		cameraTextures[5] = (Texture2D)ResourceLoader.Load("res://Sprites/Камеры/camera_remastered_6.jpg");
		cameraTextures[6] = (Texture2D)ResourceLoader.Load("res://Sprites/Камеры/camera 7.jpg");
		soundPlayer = GetNode<AudioStreamPlayer>($"../Sounds");
	}

	// Button press handlers to change camera textures
	private void _on_first_camera_button_button_down()
	{
		ChangeCameraTexture(0);
	}

	private void _on_second_camera_button_button_down()
	{
		ChangeCameraTexture(1);
	}

	private void _on_fourth_camera_button_button_down()
	{
		ChangeCameraTexture(3);
	}

	private void _on_fifth_camera_button_button_down()
	{
		ChangeCameraTexture(4);
	}

	private void _on_sixth_camera_button_button_down()
	{
		ChangeCameraTexture(5);
	}

	private void _on_seventh_camera_button_button_down()
	{
		ChangeCameraTexture(6);
	}
	
	private void _on_three_camera_button_button_down()
	{
		ChangeCameraTexture(2);
	}
	
	private void _on_desktop_camera_button_button_down()
	{
		ChangeCameraTexture(0);
	}
	
	private void ChangeCameraTexture(int cameraIndex)
	{
		soundPlayer.Play();
		if (cameraIndex >= 0 && cameraIndex < cameraTextures.Length && cameraTextures[cameraIndex] != null)
		{
			Texture = cameraTextures[cameraIndex];
		}
	}
}
