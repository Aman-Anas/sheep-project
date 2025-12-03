using System;
using Game;
using Godot;

namespace Game.Entities;

[GlobalClass]
public partial class Sheep : RigidBody3D
{
    [Export]
    float forceMult = 1.0f;

    [Export]
    public Node3D something { get; set; } = null!;

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

        state.ApplyCentralForce(
            GlobalBasis * (forceMult * new Vector3(inputVec.X, 0f, inputVec.Y))
        );
        state.AngularVelocity = Vector3.Zero;

        if (Input.IsActionJustPressed(GameActions.PlayerJump))
        {
            state.ApplyCentralImpulse(new(0, 200f, 0));
        }
    }

    public Laser SpawnNewLaser()
    {
        var laserScene = GD.Load<PackedScene>("uid://b2y7y7abuxj35");
        var newLaser = laserScene.Instantiate<Laser>();
        GetTree().Root.AddChild(newLaser);
        newLaser.GlobalPosition = something.GlobalPosition;
        return newLaser;
    }
}
