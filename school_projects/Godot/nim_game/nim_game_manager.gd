class_name NimGameManager
extends Node2D

enum EnumTurn {PLAYER, CPU, NONE}

signal turn_changed(int)
signal game_finished(int)

var _current_turn := EnumTurn.NONE
var current_turn := EnumTurn.NONE:
	set(new_value):
		if new_value == _current_turn: return
		_current_turn = new_value
		number_of_rects_selected_this_turn = 0
		turn_changed.emit(_current_turn)
	get: return _current_turn
	

var _number_of_rects_selected_this_turn = 0
var number_of_rects_selected_this_turn = 0:
	set(new_value):
		if new_value == _number_of_rects_selected_this_turn: return
		_number_of_rects_selected_this_turn = new_value
		if _number_of_rects_selected_this_turn <= 0:
			nim_game_ui.end_turn_button.disabled = true
		elif current_turn == EnumTurn.PLAYER:
			nim_game_ui.end_turn_button.disabled = false
	get: return _number_of_rects_selected_this_turn

@onready var nim_game_ui: NimGameUi = $CanvasLayer/NimGameUi
@onready var npc_controller: NpcController = $NpcController


func _ready() -> void:
	
	nim_game_ui.game_manager = self
	npc_controller.game_manager = self
	await get_tree().process_frame
	current_turn = EnumTurn.PLAYER
	
	#######################
	## EVENT CONNECTIONS ##
	#######################
	nim_game_ui.end_turn_button_pressed.connect(_on_end_turn_pressed)
	npc_controller.cpu_turn_complete.connect(_on_cpu_turn_complete)
	turn_changed.connect(_on_turn_changed)
	
	var nim_grid: NimGrid = nim_game_ui.nim_grid
	for row_number in range(nim_grid.grid_matrix.size()):
		var this_row: Array = nim_grid.grid_matrix[row_number]
		for column_number in range(this_row.size()):
			var this_rect: NimRect = nim_grid.grid_matrix[row_number][column_number]
			if this_rect:
				this_rect.rect_selected.connect(_on_rect_selected.bind(this_rect))
	
func _on_rect_selected(nim_rect: NimRect):
	
	if number_of_rects_selected_this_turn <= 0:
		var heap_that_selected_rect_is_in = []
		var in_play_heaps = nim_game_ui.nim_grid._get_heaps()
		
		for row_of_heaps: Array in in_play_heaps:
			for heap in row_of_heaps:
				if nim_rect in heap:
					heap_that_selected_rect_is_in = heap
		nim_game_ui.nim_grid._make_only_this_heap_unselectable(heap_that_selected_rect_is_in)
		
	nim_rect.in_play = false
	number_of_rects_selected_this_turn += 1
	
	# TODO handle taking all the remaining matches (should not be allowed)
	
	
func _on_end_turn_pressed(): # the player has selected >= 1 rects and has finished their turn
	
	if _is_win():
		print("WIN!")
		game_finished.emit(EnumTurn.PLAYER)
		return
	nim_game_ui.end_turn_button.disabled = true
	current_turn = EnumTurn.CPU # CPU reacts to turn_changed signal
	
	
	
func _on_cpu_turn_complete(): # the cpu has selected >= 1 rects and has finished their turn
	if _is_win():
		print("LOSE!")
		game_finished.emit(EnumTurn.CPU)
		return
	current_turn = EnumTurn.PLAYER
	
func _on_turn_changed(_turn):
	
	var nim_grid := nim_game_ui.nim_grid
	
	match current_turn:
		
		EnumTurn.PLAYER:
			nim_game_ui.end_turn_button.visible = true
			nim_grid.make_all_in_play_rects_player_selectable(true)
			
		EnumTurn.CPU:
			nim_game_ui.end_turn_button.visible = false
			nim_grid.make_all_in_play_rects_player_selectable(false)
			
func _is_win()->bool:
	
	var matches_left = 0
	for row: Array in nim_game_ui.nim_grid.grid_matrix:
		for rect: NimRect in row:
			if rect:
				if rect.in_play:
					matches_left += 1
					if matches_left > 1: return false
	assert(matches_left >= 1)
	return true
	
	
	
