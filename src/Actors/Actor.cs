using Godot;
using System;

public class Actor : KinematicBody2D
{

    [Export]
    public float Gravity { get; set;} = 3500.0f;
    [Export]
    public Vector2 Speed { get; set; } = new Vector2(300, 1000);
    private Vector2 _velocity = Vector2.Zero;
    
    public override void _PhysicsProcess(float delta)
    {
        _velocity.y += this.Gravity * delta;
        _velocity = this.MoveAndSlide(_velocity);
    }
}
