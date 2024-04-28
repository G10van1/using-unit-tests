using Calculator;

namespace CalculatorTestXUnit
{
    public class CalculatorTest
    {
        private Calcule _calc = new Calcule();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 2, 5)]
        [InlineData(1, 1, 2)]
        public void TestCalculatorSumOperation(int x, int y, int result)
        {
            Assert.Equal(result, _calc.Sum(x, y));
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(2, 2, 0)]
        [InlineData(4, 2, 2)]
        [InlineData(5, 1, 4)]
        public void TestCalculatorSubOperation(int x, int y, int result)
        {
            Assert.Equal(result, _calc.Sub(x, y));
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(2, 2, 4)]
        [InlineData(4, 2, 8)]
        [InlineData(5, 1, 5)]
        public void TestCalculatorMultiplyOperation(int x, int y, int result)
        {
            Assert.Equal(result, _calc.Multiply(x, y));
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(8, 4, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(15, 5, 3)]
        public void TestCalculatorDivideOperation(int x, int y, int result)
        {
            Assert.Equal(result, _calc.Divide(x, y));
        }

        [Fact]
        public void TestDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Divide(5, 0));
        }

        [Fact]
        public void TestGetHistoryOfOperations()
        {
            _calc.Sum(1, 2);
            _calc.Sub(2, 1);
            _calc.Multiply(1, 2);
            var list = _calc.GetHistory();
            Assert.Equal(3, list.Count);
            Assert.Equal("1 + 2 = 3", list[2]);
            Assert.Equal("2 - 1 = 1", list[1]);
            Assert.Equal("1 * 2 = 2", list[0]);
        }
    }
}