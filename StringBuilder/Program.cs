using System.Text;

namespace StringBuilderExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Insert
            StringBuilder stringBuilderInsert = new StringBuilder();
            stringBuilderInsert.Insert(0, "baum", 50);
            Console.WriteLine(stringBuilderInsert.ToString());

            //Append and Remove
            StringBuilder stringBuilderRemove = new StringBuilder();
            stringBuilderRemove.Append("abcdefg");
            stringBuilderRemove.Remove(2, 3); //An 2ter Stelle 3 characters removen
            Console.WriteLine(stringBuilderRemove.ToString());

            //Replace
            StringBuilder stringBuilderReplace = new StringBuilder();
            stringBuilderReplace.Append("John Smith");
            stringBuilderReplace.Replace("John", "James");
            Console.WriteLine(stringBuilderReplace.ToString());



            //Mutable VS Immutable
            string exampleString = "a value";
            Console.WriteLine(exampleString.GetHashCode());
            exampleString = "a different value";
            Console.WriteLine(exampleString.GetHashCode()); //Different Hash because strings are mutable

            StringBuilder stringBuilderImmutable = new StringBuilder();
            Console.WriteLine(stringBuilderImmutable.GetHashCode());
            stringBuilderImmutable.Append("abcdefg");
            Console.WriteLine(stringBuilderImmutable.GetHashCode()); //Same Hash because StringBuilders are immutable
        }
    }
}
