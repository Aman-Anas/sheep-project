using System;
using Game;
using Godot;

namespace Game.Entities;

public partial class Sheep : RigidBody3D
{
    [Export]
    float forceMult = 1.0f;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready() { }

    public override void _IntegrateForces(PhysicsDirectBodyState3D state)
    {
        var inputVec = Input
            .GetVector(
                GameActions.PlayerStrafeLeft,
                GameActions.PlayerStrafeRight,
                GameActions.PlayerBackward,
                GameActions.PlayerForward
            )
            .Normalized();

        state.ApplyCentralForce((forceMult * new Vector3(inputVec.X, 0f, inputVec.Y)));

        if (Input.IsActionJustPressed(GameActions.PlayerJump))
        {
            state.ApplyCentralImpulse(new(0, 200f, 0));
        }
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    // public override void _Process(double delta)
    // {
    // }
}
