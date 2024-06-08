extends VBoxContainer

func _ready():
	pass # Replace with function body.

func _on_quit_button_button_up():
	get_tree().quit(0)

func _on_options_button_button_up():
	_change_visibilty(false)

func _change_visibilty(visib):
	if visib:
		visible = true
	else:
		visible = false
	
func _on_quit_for_options_button_up():
	_change_visibilty(true)
