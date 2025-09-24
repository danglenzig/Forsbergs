class_name NimGrid
extends GridContainer

var grid_matrix: Array[Array] = [
	[],
	[],
	[],
	[],
]

@onready var nim_rect_03: NimRect = $NimRect_03

@onready var nim_rect_09: NimRect = $NimRect_09
@onready var nim_rect_10: NimRect = $NimRect_10
@onready var nim_rect_11: NimRect = $NimRect_11

@onready var nim_rect_15: NimRect = $NimRect_15
@onready var nim_rect_16: NimRect = $NimRect_16
@onready var nim_rect_17: NimRect = $NimRect_17
@onready var nim_rect_18: NimRect = $NimRect_18
@onready var nim_rect_19: NimRect = $NimRect_19

@onready var nim_rect_21: NimRect = $NimRect_21
@onready var nim_rect_22: NimRect = $NimRect_22
@onready var nim_rect_23: NimRect = $NimRect_23
@onready var nim_rect_24: NimRect = $NimRect_24
@onready var nim_rect_25: NimRect = $NimRect_25
@onready var nim_rect_26: NimRect = $NimRect_26
@onready var nim_rect_27: NimRect = $NimRect_27

func _ready() -> void:
	grid_matrix[0] = [
		null,null,null,
		nim_rect_03,
		null,null,null,
	]
	grid_matrix[1] = [
		null,null,
		nim_rect_09,
		nim_rect_10,
		nim_rect_11,
		null,null,
	]
	grid_matrix[2] = [
		null,
		nim_rect_15,
		nim_rect_16,
		nim_rect_17,
		nim_rect_18,
		nim_rect_19,
		null,
	]
	grid_matrix[3] = [
		nim_rect_21,
		nim_rect_22,
		nim_rect_23,
		nim_rect_24,
		nim_rect_25,
		nim_rect_26,
		nim_rect_27,
	]

func make_all_in_play_rects_player_selectable(value: bool):
	for row_number in range(grid_matrix.size()):
		var this_row: Array = grid_matrix[row_number]
		for column_number in range(this_row.size()):
			
			var this_rect: NimRect = grid_matrix[row_number][column_number]
			
			if this_rect:
				if this_rect.in_play:
					this_rect.player_selectable = value

func _make_only_this_heap_unselectable(selectable_heap):
	for row in grid_matrix:
		for rect: NimRect in row:
			if rect:
				if rect not in selectable_heap:
					rect.player_selectable = false

	
func _get_heaps()->Array:
	var in_play_heaps := [
		[], # row 0
		[], # row 1
		[], # row 2
		[], # row 3
	]
	
	for row_number in range(grid_matrix.size()):
		
		var this_row = grid_matrix[row_number]
		
		var heaps: Array = []
		var current_heap: Array = []
		
		for rect: NimRect in this_row:
			
			var is_gap_rect = false
			if not rect:
				is_gap_rect = true
			elif not rect.in_play:
				is_gap_rect = true
			
			if is_gap_rect:
				# if we hit a non-in-play-rect, push the current heap (if non-empty) and reset
				if not current_heap.is_empty():
					heaps.append(current_heap)
					current_heap = []
			else:
				current_heap.append(rect)
				
		# push the last heap if it is non-empty
		if not current_heap.is_empty():
			heaps.append(current_heap)
		
		in_play_heaps[row_number] = heaps
		#(in_play_heaps[row_number] as Array).append(heaps)
		
	return in_play_heaps
