using Godot;
using System;

public partial class Door : ColorRect
{
	public bool DoorIsClosed = false; 
	private void _on_door_button_button_down()
	{
		DoorIsClosed = !DoorIsClosed;
		Visible = !Visible;
	}
}
