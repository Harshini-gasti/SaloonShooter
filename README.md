                                         Saloon Shooter – Unity FPS Raycasting Game

A Unity first-person shooter prototype demonstrating raycasting mechanics, optimized gameplay logic, and timed object management.

      Features

Shooting system using Raycasting

Object spawning and automatic disabling every 5 seconds

Score system with data loading

Gameplay logic using Update()

Physics handling using FixedUpdate()

Clean modular C# scripts

    Gameplay Systems

FPS Player Controller

Raycast-based shooting (Pistol system)

Bullet movement system

Score Manager

Timed spawn objects that disable after a few seconds

     Technical Highlights

Built with Unity and C#

Efficient game loop using Update() and FixedUpdate()

Optimized shooting using Raycast detection

Basic game state and score loading system

    Example Raycasting Logic
Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
RaycastHit hit;

if (Physics.Raycast(ray, out hit))
{
    Debug.Log("Hit: " + hit.collider.name);
    
}

         Skills Demonstrated

Unity FPS Mechanics

Raycasting

Game Optimization

C# Scripting

Gameplay System Design
