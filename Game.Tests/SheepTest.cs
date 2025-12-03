using System.Threading.Tasks;
using Chickensoft.GoDotTest;
using Chickensoft.Log;
using Game.Entities;
using Godot;
using GodotTestDriver;
using Xunit;

namespace Game.Tests;

public class SheepTest(Node testScene) : TestClass(testScene)
{
    private readonly Log _log = new(nameof(SheepTest), new TraceWriter());

    Fixture fixture;
    Sheep sheepPlayer;

    [SetupAll]
    public async Task SetupAll()
    {
        _log.Print("Setup everything");
    }

    [Setup]
    public async Task Setup()
    {
        fixture = new(TestScene.GetTree());
        sheepPlayer = await fixture.LoadAndAddScene<Sheep>("uid://b28dqpo2o8u7x");
    }

    [Test]
    public void Test()
    {
        _log.Print("Testing sheep.");
        var newLaser = sheepPlayer.SpawnNewLaser();
        Assert.IsType<Laser>(newLaser);
        Assert.Equal(newLaser.GlobalPosition, sheepPlayer.something.GlobalPosition);
    }

    [Cleanup]
    public async Task Cleanup()
    {
        _log.Print("Cleanup");
        await fixture.Cleanup();
    }

    [CleanupAll]
    public void CleanupAll() => _log.Print("Cleanup everything");

    [Failure]
    public void Failure() => _log.Print("Runs whenever any of the tests in this suite fail.");
}
