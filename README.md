# Sheep Project
For CSC 491/519 DevOps

### Authors
- Aman Anas (unityID: mbanas)
- Andrew Bowen (unityID: akbowen)

## Project Structure 
This project is configured based on the recommended Godot structure. Game scenes are placed in the `scenes` folder, and assets (3D models, textures, etc) under `assets`. 

The `Game` folder contains all C# code related to the main game functionality. The `Game.Tests` folder contains test xases and configuration. `SheepProject.csproj` contains the library and .NET SDK project configuration.

The Ansible Playbook used for provisioning is under the `deployment/ActionsRunner` folder, as well as the Dockerfile used to run the Github Actions runner.

`.github/workflows` contains the main Github actions workflow and all the steps that get executed.
