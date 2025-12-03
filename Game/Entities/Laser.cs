using System;
using Godot;

namespace Game.Entities;

[GlobalClass]
public partial class Laser : Node3D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready() { }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        var pos = Position;
        pos.Z -= (float)(2 * delta);
        Position = pos;
    }
}
