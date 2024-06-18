using Godot;
using System;

public partial class Options_Menu : VBoxContainer
{
	private void _on_options_button_button_up()
	{
		ShowOptionsMenuButtons();
		GetNode<AudioStreamPlayer>($"../Buttons_Sound").Play();
	}
	private void _on_back_button_up()
	{
		HideOptionsMenuButtons();
		GetNode<AudioStreamPlayer>($"../Buttons_Sound").Play();
	}
	
	private void _on_check_button_button_up()
	{
		
		GetNode<AudioStreamPlayer>($"../Buttons_Sound").Play();
	}
	
	private void _on_option_button_item_selected(long index)
	{	
		GetNode<AudioStreamPlayer>($"../Buttons_Sound").Play();
		switch(index)
		{
			case 1:
				GD.Print("1920x1080 set");
				break;

			case 2:
				GD.Print("1252x648 set");
				break;
		}
	}

	//Vector2D[] resolutions = new string[7]{"1920x1080", "800x600"}; 
	private void _on_fullscreen_button_button_up()
	{
		GetNode<AudioStreamPlayer>($"../Buttons_Sound").Play();
	}

	void HideOptionsMenuButtons() { Visible = false; }
	void ShowOptionsMenuButtons() { Visible = true; }
}











