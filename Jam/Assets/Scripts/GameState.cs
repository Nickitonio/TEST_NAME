﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
  public class GameState
  {
    public int Turn;
    public Maze Maze;
    public List<Player> Players;
    public List<Hero> Heroes;

    public Player CurrentPlayer
    {
      get { return Players[Turn%Players.Count]; }
    }
  }

  public class MazeObject
  {
    public int? OwnerId;
    public LocationInMaze LocationInMaze;
  }

  public class Hero : MazeObject
  {
    public Race Race;
    public int HitPoints;
  }

  public abstract class Chest : MazeObject
  {
    
  }

  public class RubyChest : Chest
  {
    public int RubyAmount;
  }

  public enum Race
  {
    Elves = 1,
    Ent = 2,
    Orc = 3,
    Vampire = 4
  }

  public class Player
  {
    public int Id;
    public bool IsDead;
    public int ActionPoints;
    public List<Card> Cards;
  }

  public class Card
  {
    //todo
  }
}
