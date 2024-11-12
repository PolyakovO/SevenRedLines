namespace SevenRedLines.Core
{
    public class RedLineGenerator
    {
        public IReadOnlyCollection<RedLine> Generate(uint redLinesCount)
        {
            var redLines = new RedLine[redLinesCount];
            for (var i = 0; i < redLinesCount; i++)
            {
                redLines[i] = new RedLine();
            }
            return redLines;

        }
    }
}
