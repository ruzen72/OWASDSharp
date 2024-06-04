using Godot;
using System;

public partial class Options_Menu : VBoxContainer
{
	#region
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
		switch(index)
		{
			case 1:
				GD.Print("1920x1080 set");
                GetNode<AudioStreamPlayer>($"../Buttons_Sound").Play();
                break;

			case 2:
				GD.Print("1252x648 set");
                GetNode<AudioStreamPlayer>($"../Buttons_Sound").Play();
                break;
        }
	}

	private void _on_fullscreen_button_button_up()
	{
        GetNode<AudioStreamPlayer>($"../Buttons_Sound").Play();
    }

    void HideOptionsMenuButtons() { Visible = false; }
	void ShowOptionsMenuButtons() { Visible = true; }
}
#endregion











