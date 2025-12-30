# Bowling Game Project

A simple bowling game implementation in C# with scoring logic, using extension methods for clean calculation and NUnit for unit testing.

---

## Features

- Roll pins and calculate total score.
- Handles strikes, spares, and open frames.
- Extension methods for strike, spare, and open frame calculations.
- Fully covered with unit tests using **NUnit**.
- Supports perfect game scoring (max 300 points).

---

## Classes Overview

### `Game`
- Responsible for rolling pins and calculating total score.
- Methods:
  - `void rolle(int pins)` – Roll a ball and record pins.
  - `int GetScore()` – Calculate total score using bowling rules.
- Internally uses `int[] roller` to track rolls.

### `RollerExtensions`
- Contains extension methods for scoring:
  - `StrikeSummition` – Adds strike bonus.
  - `SPareSummition` – Adds spare bonus.
  - `OpenFrameSummition` – Sums pins for an open frame.

---

## Example Usage

```csharp
var game = new Game();
game.rolle(10); // strike
game.rolle(3);
game.rolle(5);
int score = game.GetScore();
Console.WriteLine($"Score: {score}"); // Output: 26
