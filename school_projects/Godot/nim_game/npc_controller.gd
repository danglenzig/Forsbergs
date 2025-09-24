class_name NpcController
extends Node

@export_enum("RANDOM", "STRATEGIC") var play_style = 0

signal cpu_turn_complete

var game_manager: NimGameManager = null

const THINK_DURATION := 2.0

func _ready() -> void:
	while not game_manager:
		await get_tree().process_frame
	print_debug("NimGameManager ready")
	
	game_manager.turn_changed.connect(_on_turn_changed)
	

func _on_turn_changed(current_turn: int):
	if current_turn != NimGameManager.EnumTurn.CPU: return
	
	match play_style:
		0:
			_take_turn_random()
		1:
			_take_turn_strategic()
		

func _take_turn_strategic():
	pass

func _take_turn_random():
	await  get_tree().create_timer(THINK_DURATION).timeout
	
	var nim_grid: NimGrid = game_manager.nim_game_ui.nim_grid
	var playable_heaps = nim_grid._get_heaps()
	
	var selected_heap = null
	while not selected_heap:
		await get_tree().process_frame
		var random_row: Array = playable_heaps.pick_random()
		if not (random_row as Array).is_empty():
			var random_heap: Array = (random_row as Array).pick_random()
			selected_heap = random_heap
			
	var selected_rects := []
	var max_selections := (selected_heap as Array).size()
	var random_number = randi_range(1,max_selections)
	
	var indexes := []
	
	for i in range(random_number):
		indexes.append(i)
		
	indexes.shuffle()
	
	for index: int in indexes:
		var selected_rect = (selected_heap as Array)[index]
		selected_rects.append(selected_rect)
		
	for rect in selected_rects:
		(rect as NimRect).in_play = false
		await get_tree().create_timer(THINK_DURATION / 4.0).timeout
		
	await get_tree().create_timer(THINK_DURATION).timeout
	cpu_turn_complete.emit()
	
# TODO handle taking all the remaining matches (should not be allowed)
		
		
		
	
	
		
