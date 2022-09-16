namespace MultipleReturnTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            var returnValues = test.TestMethod();
            Console.WriteLine("Element 1: " + returnValues.Item1 + " Element 2: " + returnValues.Item2.ToString());
        }
    }

    public class Test
    {
        public (int, string) TestMethod()
        {
            return (1, "beispiel");
        }
    }
}
