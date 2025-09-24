class_name NimGameUi
extends Control

signal end_turn_button_pressed

var game_manager: NimGameManager = null

@onready var nim_grid: NimGrid = $NimGrid
@onready var turn_label: Label = %TurnLabel
@onready var end_turn_button: Button = %EndTurnButton
@onready var bg_rect: ColorRect = %BGRect


const PLAYER_COLOR = Color.BLACK
const CPU_COLOR = Color.DARK_OLIVE_GREEN

func _ready() -> void:
	end_turn_button.disabled = true
	visible = false
	while not game_manager:
		await get_tree().process_frame
	print_debug("NimGameManager ready")
	visible = true
	
	end_turn_button.pressed.connect(
		func()->void:
			end_turn_button_pressed.emit()
	)
	game_manager.turn_changed.connect(_on_game_manager_turn_changed)
	
func _on_game_manager_turn_changed(current_turn: int):
	match current_turn:
		NimGameManager.EnumTurn.PLAYER:
			turn_label.text = "Turn: PLAYER"
			bg_rect.color = PLAYER_COLOR
			#nim_grid.make_all_in_play_rects_player_selectable(true)
		NimGameManager.EnumTurn.CPU:
			turn_label.text = "Turn: CPU"
			bg_rect.color = CPU_COLOR
			#nim_grid.make_all_in_play_rects_player_selectable(false)
	
	
