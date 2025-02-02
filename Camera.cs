using Godot;
using System;


public class Camera : Godot.Camera
{

    [Export]
    public NodePath player { get; set; }
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

 // Called every frame. 'delta' is the elapsed time since the previous frame.
 public override void _Process(float delta)
 {
    
    if (GetNodeOrNull(player) != null) Translation = (GetNode(player) as RigidBody).Translation - new Vector3(0, -15, -15);
 }
}
