using Xunit;

namespace SevenRedLines.Core.Tests
{
    public class SevenRedLinesTests
    {
        [Fact]
        public void DraftTest()
        {
            var redLineGenerator = new RedLineGenerator();
            var redLines = redLineGenerator.Generate();
            Assert.Equal(7, redLines.Count);
        }
    }
}
