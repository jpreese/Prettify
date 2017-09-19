using Prettify;
using Xunit;

namespace PrettifyTests
{
    public class DashifyTests
    {
        [Fact]
        public void EmptyInputReturnsEmpty()
        {
            Assert.Empty("".Dashify());
        }

        [Fact]
        public void NullInputReturnsEmpty()
        {
            string input = null;
            Assert.Empty(input.Dashify());
        }

        [Fact]
        public void SingleWorldReturnsSameWord()
        {
            Assert.Equal("word", "word".Dashify());
        }

        [Fact]
        public void TwoWordsSeparatedBySpacesReturnsDashBetweenThem()
        {
            Assert.Equal("word-word", "word word".Dashify());
        }
    }
}
