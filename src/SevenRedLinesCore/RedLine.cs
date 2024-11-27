namespace SevenRedLines.Core;

public class RedLine(int x1, int y1, int x2, int y2)
{
    public int X1 { get; } = x1;
    public int Y1 { get; } = y1;
    public int X2 { get; } = x2;
    public int Y2 { get; } = y2;
}
