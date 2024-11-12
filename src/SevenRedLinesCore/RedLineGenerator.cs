namespace SevenRedLines.Core
{
    public class RedLineGenerator
    {
        public IReadOnlyCollection<RedLine> Generate()
        {
            //Duplication of the number 7 in the test and code will be resolved in the next step, starting by updating the test first.
            var redLinesCount = 7;
            var redLines = new RedLine[redLinesCount];
            for (var i = 0; i < redLinesCount; i++)
            {
                redLines[i] = new RedLine();
            }
            return redLines;

        }
    }
}
