﻿using System;

public struct Point : IEquatable<Point>
{
  public int X;
  public int Y;

  public Point(int x, int y)
  {
    X = x;
    Y = y;
  }

  public bool Equals(Point other)
  {
    return X == other.X && Y == other.Y;
  }

  public override bool Equals(object obj)
  {
    if (ReferenceEquals(null, obj)) return false;
    return obj is Point && Equals((Point) obj);
  }

  public override int GetHashCode()
  {
    unchecked
    {
      return (X*397) ^ Y;
    }
  }
}