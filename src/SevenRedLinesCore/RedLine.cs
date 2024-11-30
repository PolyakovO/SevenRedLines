namespace SevenRedLines.Core;

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
}
