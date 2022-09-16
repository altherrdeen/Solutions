using Inconclusive;

namespace InconclusiveTests
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public bool TestMethod()
        {
            return true;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_ReturnsTrue()
        {
            //Arrange
            Program program = new Program();

            //act
            bool result = program.TestMethod();

            //Assert
            Assert.Inconclusive("Not sure if the test succeds");
        }
    }
}
