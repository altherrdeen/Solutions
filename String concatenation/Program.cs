using System.Text;

namespace ConcatStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Different ways off chaining strings together:");
            
            Console.WriteLine("Plus " + "operator");

            string interpolationString = "interpolation";
            Console.WriteLine($"String {interpolationString}");

            Console.WriteLine(String.Format("String{0}", ".Format"));

            StringBuilder sb = new StringBuilder();
            sb.Append("String");
            sb.Append("Builder");
            Console.WriteLine(sb);

            Console.WriteLine(String.Concat("String.", "Concat"));
        }
    }
}
