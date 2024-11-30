using Xunit;

namespace SevenRedLines.Core.Tests
{
    public class SevenRedLinesTests
    {
        private const uint RedLinesDefaultCount = 7;
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



        [Fact]
        public void Generate_ShouldNotContainDuplicateLines()
        {
            var redLineGenerator = new RedLineGenerator();
            var redLines = redLineGenerator.Generate(RedLinesDefaultCount);
            var hasDuplicates = redLines.Distinct().Count() != redLines.Count;
            Assert.False(hasDuplicates);
        }

        [Theory]
        [InlineData(1, 2, 3, 4, true)]
        [InlineData(2, 2, 3, 4, false)]
        [InlineData(3, 4, 1, 2, true)]

        public void EqualsAndHashCode_ShouldConsiderDirection(int x1, int y1, int x2, int y2, bool result)
        {
            var redLine1 = new RedLine(x1, y1, x2, y2);
            var redLine2 = new RedLine(1, 2, 3, 4);
            Assert.Equal(result, redLine1.Equals(redLine2));
            Assert.Equal(result, redLine1.GetHashCode() == redLine2.GetHashCode());
        }
    }
}


