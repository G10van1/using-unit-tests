using Calculator;

namespace CalculatorTestNUnit
{
    public class CalculatorTests
    {
        private Calcule _calc = new Calcule();

        [SetUp]        
        public void Setup()
        {
        }
                
        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 2, 5)]
        [TestCase(1, 1, 2)]
        public void TestCalculatorSumOperation(int x, int y, int result)
        {
            Assert.AreEqual(result, _calc.Sum(x, y));
        }

        [TestCase(3, 2, 1)]
        [TestCase(2, 2, 0)]
        [TestCase(4, 2, 2)]
        [TestCase(5, 1, 4)]
        public void TestCalculatorSubOperation(int x, int y, int result)
        {
            Assert.AreEqual(result, _calc.Sub(x, y));
        }

        [TestCase(3, 2, 6)]
        [TestCase(2, 2, 4)]
        [TestCase(4, 2, 8)]
        [TestCase(5, 1, 5)]
        public void TestCalculatorMultiplyOperation(int x, int y, int result)
        {
            Assert.AreEqual(result, _calc.Multiply(x, y));
        }

        [TestCase(6, 2, 3)]
        [TestCase(8, 4, 2)]
        [TestCase(4, 2, 2)]
        [TestCase(15, 5, 3)]
        public void TestCalculatorDivideOperation(int x, int y, int result)
        {
            Assert.AreEqual(result, _calc.Divide(x, y));
        }

        [Test]
        public void TestDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Divide(5, 0));
        }

        [Test]
        public void TestGetHistoryOfOperations()
        {
            _calc.Sum(1, 2);
            _calc.Sub(2, 1);
            _calc.Multiply(1, 2);
            var list = _calc.GetHistory();
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual("1 + 2 = 3", list[2]);
            Assert.AreEqual("2 - 1 = 1", list[1]);
            Assert.AreEqual("1 * 2 = 2", list[0]);
        }
    }
}