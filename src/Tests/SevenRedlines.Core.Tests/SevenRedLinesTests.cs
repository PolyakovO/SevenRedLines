using Xunit;

namespace SevenRedLines.Core.Tests
{
    public class SevenRedLinesTests
    {
        [Theory]
        [InlineData(7)]
        [InlineData(5)]
        //We can disallow passing zero and add an exception. For simplicity, we'll leave the collection empty.
        [InlineData(0)]
        public void Generate_ShouldCreateCount(uint redLinesCount)
        {
            var redLineGenerator = new RedLineGenerator();
            var redLines = redLineGenerator.Generate(redLinesCount);
            Assert.Equal(redLinesCount, (uint)redLines.Count);
        }
    }

}
