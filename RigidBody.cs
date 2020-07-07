using Godot;
using System;

public class RigidBody : Godot.RigidBody
{
    //Declare member variables here. Examples:
    private int coins = 0;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public Vector3 direction = new Vector3(0,0,0);

    public float speed = 2;

    public override void _Process(float delta)
    {
        direction.z = (Input.IsActionPressed("ui_down") ? 1 : 0) - (Input.IsActionPressed("ui_up") ? 1 : 0);
        direction.x = (Input.IsActionPressed("ui_right") ? 1 : 0) - (Input.IsActionPressed("ui_left") ? 1 : 0);
        ApplyCentralImpulse(direction * speed * delta);

    }

    public void _on_RigidBody_body_entered(Node node) {
        if ( node.IsInGroup("coin")) {
            node.QueueFree();
            Global.score++;
            GD.Print(Global.score);
        }
    }

}

