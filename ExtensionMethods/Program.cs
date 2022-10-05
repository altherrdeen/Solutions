namespace ExtensionMethods
{
    public static class Extensions
    {
        public static void Log(this string msg)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("t") + ": " + msg);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string exampleMessage = "Loading...";
            exampleMessage.Log();
        }
    }
}
