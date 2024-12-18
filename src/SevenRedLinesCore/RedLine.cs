﻿namespace SevenRedLines.Core;

public class RedLine
{
    public int X1 { get; }
    public int Y1 { get; }
    public int X2 { get; }
    public int Y2 { get; }

    public RedLine(int x1, int y1, int x2, int y2)
    {
        if (x1 == x2 && y1 == y2)
        {
            throw new ArgumentException("All coordinates are the same.");
        }
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not RedLine other)
        {
            return false;
        }

        return (X1 == other.X1 && Y1 == other.Y1 && X2 == other.X2 && Y2 == other.Y2) ||
               (X1 == other.X2 && Y1 == other.Y2 && X2 == other.X1 && Y2 == other.Y1);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X1, Y1, X2, Y2) ^ HashCode.Combine(X2, Y2, X1, Y1);
    }

    public bool IsPerpendicularTo(RedLine other)
    {
        var dx1 = X2 - X1;
        var dy1 = Y2 - Y1;

        var dx2 = other.X2 - other.X1;
        var dy2 = other.Y2 - other.Y1;

        return dx1 * dx2 + dy1 * dy2 == 0;
    }
}
