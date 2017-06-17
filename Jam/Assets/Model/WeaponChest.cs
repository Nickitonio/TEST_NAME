﻿using Assets.Model.Maze.MazeObjects.Chest;

namespace Assets.Model
{
  internal class WeaponChest : Chest
  {
    public Weapon Weapon;
    public override ChestOpeningResult OpenChest()
    {
      return new ChestOpeningResult
      {
        ChestOpeningResultType = ChestOpeningResultType.Weapon,
        Weapon = Weapon
      };
    }
  }
}