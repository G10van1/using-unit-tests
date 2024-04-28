namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Calcule
    {
        private List<string> _operations = new List<string>();
        public int Sum(int x, int y) 
        {
            var result = x + y;
            _operations.Insert(0, $"{x} + {y} = {result}");
            return result;
        }
        public int Sub(int x, int y)
        {
            var result = x - y;
            _operations.Insert(0, $"{x} - {y} = {result}");
            return result;
        }
        public int Multiply(int x, int y)
        {
            var result = x * y;
            _operations.Insert(0, $"{x} * {y} = {result}");
            return result;
        }
        public int Divide(int x, int y)
        {
            var result = x / y;
            _operations.Insert(0, $"{x} / {y} = {result}");
            return result;
        }

        public List<string> GetHistory()
        {
            const int MAX_ELEMENTS_LIST = 3;
            _operations.RemoveRange(MAX_ELEMENTS_LIST, _operations.Count- MAX_ELEMENTS_LIST);
            return _operations;
        }
    }
}