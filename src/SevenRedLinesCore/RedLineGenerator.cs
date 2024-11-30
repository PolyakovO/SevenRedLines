namespace SevenRedLines.Core;

public class RedLineGenerator
{
    public IReadOnlyCollection<RedLine> Generate(uint redLinesCount)
    {
        var lines = new List<RedLine>();
        if (redLinesCount == 0)
            return lines;

        const int currentX = 0;
        const int currentY = 0;

        const int length = 100;

        lines.Add(new RedLine(currentX, currentY, currentX + length, currentY));

        for (var i = 1; i < redLinesCount; i++)
        {
            var lastLine = lines.Last();
            var lastX2 = lastLine.X2;
            var lastY2 = lastLine.Y2;
            if (i % 2 == 1)
                lines.Add(new RedLine(lastX2, lastY2, lastX2, lastY2 + length));
            else
                lines.Add(new RedLine(lastX2, lastY2, lastX2 + length, lastY2));
        }

        return lines;
    }
}