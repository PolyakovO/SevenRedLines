using Xunit;

namespace SevenRedLines.Core.Tests
{
    public class SevenRedLinesTests
    {
        [Theory]
        [InlineData(7)]
        [InlineData(5)]
        [InlineData(0)]
        public void Generate_ShouldCreateSeven(uint redLinesCount)
        {
            var redLineGenerator = new RedLineGenerator();
            var redLines = redLineGenerator.Generate(redLinesCount);
            Assert.Equal(redLinesCount, redLines.Count);
        }
    }

}
