extends Node




func _ready() -> void:
	while true:
		await get_tree().create_timer(0.1).timeout
		print(randi_range(0,4))
