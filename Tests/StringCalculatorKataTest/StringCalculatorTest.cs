using StringCalculatorKata.StringCalculator;

namespace StringCalculatorKataTest
{
    public class StringCalculatorTest
    {
        private readonly IStringCalculator _stringCalculator;

        public StringCalculatorTest()
        {
            _stringCalculator = new StringCalculator();
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("   ", 0)]
        [InlineData(null, 0)]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        [InlineData("1,2,4,5,6", 18)]
        [InlineData("1,2,4,5,6,7", 25)]
        public void Add_Success(string numbers, int expected)
        {
            var actual = _stringCalculator.Add(numbers);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", 1)]
        [InlineData("   ", 2)]
        [InlineData(null, 4)]
        [InlineData("1", 11)]
        [InlineData("1,2", 23)]
        public void Add_Failure(string numbers, int expected)
        {
            var actual = _stringCalculator.Add(numbers);

            Assert.NotEqual(expected, actual);
        }
    }
}