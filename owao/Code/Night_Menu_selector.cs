using Godot;
using System;

public partial class Night_Menu_selector : VBoxContainer
{
	void _on_play_button_button_up()
	{
		ShowNightMenuButtons();
		GetNode<AudioStreamPlayer>($"../Buttons_Sound").Play();
	}
	
	void _on_back_button_button_up()
	{
		HideNightMenuButtons();
		GetNode<AudioStreamPlayer>($"../Buttons_Sound").Play();
	}

	public void HideNightMenuButtons(){Visible = false;}
	public void ShowNightMenuButtons(){Visible = true;}
}











