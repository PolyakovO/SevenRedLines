namespace SevenRedLines.Core;

public class PointND
{
    public int[] Coordinates { get; }

    public PointND(params int[] coordinates)
    {
        if (coordinates == null || coordinates.Length == 0)
            throw new ArgumentException("A point must have at least one dimension.");

        Coordinates = coordinates;
    }

    public int Dimensions => Coordinates.Length;

    public override string ToString() =>
         $"({string.Join(", ", Coordinates)})";


    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
            return true;

        if (obj is not PointND other || other.Dimensions != Dimensions)
            return false;

        for (var i = 0; i < Dimensions; i++)
        {
            if (Coordinates[i] != other.Coordinates[i])
                return false;
        }

        return true;
    }

    public override int GetHashCode()
    {
        var hash = new HashCode();
        foreach (var coordinate in Coordinates)
        {
            hash.Add(coordinate);
        }
        return hash.ToHashCode();
    }
}