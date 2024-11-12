using Xunit;

namespace SevenRedLines.Core.Tests
{
    public class SevenRedLinesTests
    {
        [Fact]
        public void Generate_ShouldCreateSeven()
        {
            const int redLinesCount = 7;
            var redLineGenerator = new RedLineGenerator();
            var redLines = redLineGenerator.Generate();
            Assert.Equal(redLinesCount, redLines.Count);
        }
    }

}
