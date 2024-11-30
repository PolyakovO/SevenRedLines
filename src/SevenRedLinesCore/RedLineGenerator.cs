namespace SevenRedLines.Core
{
    public class RedLineGenerator
    {
        public IReadOnlyCollection<RedLine> Generate(uint redLinesCount)
        {
            const int step = 50;
            var redLines = new RedLine[redLinesCount];
            for (var i = 0; i < redLinesCount; i++)
            {
                redLines[i] = new RedLine(0, 0, step + step * i, 500);
            }
            return redLines;

        }

    }
}
