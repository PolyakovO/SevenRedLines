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

        //For clarity, all tests are in a single class for now.
        //This test may seem trivial, but it helps us define how the object will be created.
        [Fact]
        public void Constructor_ShouldInitializePointsCorrectly()
        {
            var x1 = 10;
            var y1 = 20;
            var x2 = 30;
            var y2 = 40;

            var redLine = new RedLine(x1, y1, x2, y2);
            Assert.Equal(x1, redLine.X1);
            Assert.Equal(y1, redLine.Y1);
            Assert.Equal(x2, redLine.X2);
            Assert.Equal(y2, redLine.Y2);
        }

        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(1, 2, 1, 2)]
        public void Constructor_AllCoordinatesTheSame_ShouldTrowsArgumentException(int x1, int y1, int x2, int y2)
        {
            Assert.Throws<ArgumentException>(() => new RedLine(x1, y1, x2, y2));
        }
    }
}


