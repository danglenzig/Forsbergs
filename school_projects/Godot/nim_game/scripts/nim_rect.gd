class_name NimRect
extends ColorRect

signal rect_selected



var _in_play := false
var in_play := false: 				# false -> a rect where the stick has been removed
	set(new_value):
		if new_value == _in_play: return
		_in_play = new_value
		if has_node("Sprite2D"):
			(get_node("Sprite2D") as Sprite2D).visible = _in_play
	get: return _in_play

var _player_selectable := true
var player_selectable := true:
	set(new_value):
		if new_value == _player_selectable: return
		_player_selectable = new_value
		if not _player_selectable:
			mouse_inside = false
			mouse_filter = Control.MOUSE_FILTER_IGNORE
		else:
			mouse_filter = Control.MOUSE_FILTER_STOP
	get: return _player_selectable


var _neighbor_above: NimRect = null
var neighbor_above: NimRect = null:
	set(new_value):
		if new_value == _neighbor_above: return
		_neighbor_above = new_value
	get: return _neighbor_above

var _neighbor_below: NimRect = null
var neighbor_below: NimRect = null:
	set(new_value):
		if new_value == _neighbor_below: return
		_neighbor_below = new_value
	get: return _neighbor_below

var _neighbor_left: NimRect = null
var neighbor_left: NimRect = null:
	set(new_value):
		if new_value == _neighbor_left: return
		_neighbor_left = new_value
	get: return _neighbor_left

var _neighbor_right: NimRect = null
var neighbor_right: NimRect = null:
	set(new_value):
		if new_value == _neighbor_right: return
		_neighbor_right = new_value
	get: return _neighbor_right


	
	
var mouse_inside := false
var match_sprite: Sprite2D = null
var is_in_game := false 			# false -> a rect that never had a stick

func _ready() -> void:
	if has_node("Sprite2D"):
		is_in_game = true
		in_play = true
	if not is_in_game:
		mouse_filter = Control.MOUSE_FILTER_IGNORE
		return
	match_sprite = get_node("Sprite2D")
		
	mouse_entered.connect(_on_mouse_entered)
	mouse_exited.connect(_on_mouse_exited)
	
func _on_mouse_entered():
	mouse_inside = true
	
func _on_mouse_exited():
	mouse_inside = false
	
func _input(event: InputEvent) -> void:
	if not mouse_inside: return
	if not player_selectable: return
	if not in_play: return
	if event is InputEventMouseButton:
		if event.button_index == MOUSE_BUTTON_LEFT:
			if event.is_pressed():
				rect_selected.emit()
				
	
