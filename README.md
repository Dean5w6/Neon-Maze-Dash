# Neon Maze Dash

A fast-paced, 2-player competitive maze game inspired by the addictive gameplay of *Tomb of the Mask*. This project was developed as a final activity for the **Computer Programming 2** course to demonstrate proficiency in event-driven programming, game loop management, and UI control manipulation in VB.NET.

---

## Gameplay & Features 🎮

-   **Fast-Paced Maze Navigation**: True to its inspiration, players don't just move one tile at a time. Once a direction is chosen, your character dashes until they hit a wall! This requires quick thinking and planning your route.
-   **Intense 2-Player Action**: Compete against a friend on a single screen to see who can master the mazes first.
-   **Three Unique Stages**: Race through three progressively challenging levels.
-   **Score Tracking & Win Condition**: The first player to win two stages is crowned the ultimate maze champion!

## Technical Implementation 🛠️

A core challenge in a grid-based game like this is handling wall collisions. Instead of using a physics engine, this game employs a **manual coordinate tracking system** to define the maze's paths.

Here's how it works:
-   Each possible stopping point (or "node") within the maze was manually identified and its X/Y coordinates were hard-coded.
-   When a player presses a direction key, a `Timer` is initiated to create smooth movement.
-   The game's `KeyDown` event handler checks the player's current coordinate node and allows movement only in valid, pre-defined directions.
-   The `Timer_Tick` event constantly updates the player's position until they reach the next node in their path, at which point the timer stops, effectively "hitting a wall."

This method, while labor-intensive, guarantees pixel-perfect movement and flawless collision detection within the game's logic.

## Technology Stack 💻

-   **Language**: VB.NET
-   **Framework**: Windows Forms (.NET Framework)
-   **Core Mechanics**:
    -   `System.Windows.Forms.Timer` for game loops and animations.
    -   `KeyDown` event handling for player input.
    -   Dynamic manipulation of `PictureBox` location properties for character movement.

## How to Play (Controls) 🕹️

The controls are simple, designed for two players on one keyboard:

| Player 1 | Action | Player 2 |
| :---: | :---: | :---: |
| **W** | Move Up | **Up Arrow** |
| **A** | Move Left | **Left Arrow** |
| **S** | Move Down | **Down Arrow** |
| **D** | Move Right | **Right Arrow** |

## Screenshots 🖼️

![Screenshot of a level](Neon%20Maze%20Dash/screenshots/showcase1.gif)
![Screenshot of a level](Neon%20Maze%20Dash/screenshots/showcase2.gif)
