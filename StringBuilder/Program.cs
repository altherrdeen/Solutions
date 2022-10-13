using System.Text;

namespace StringBuilderExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Insert
            StringBuilder stringBuilderInsert = new StringBuilder();
            stringBuilderInsert.Insert(0, "baum", 50); //Insert "baum" 50 times at position 0
            Console.WriteLine(stringBuilderInsert.ToString());

            //Append and Remove
            StringBuilder stringBuilderRemove = new StringBuilder();
            stringBuilderRemove.Append("abcdefg");
            stringBuilderRemove.Remove(2, 3); //Remove 3 characters at position 2
            Console.WriteLine(stringBuilderRemove.ToString());

            //Replace
            StringBuilder stringBuilderReplace = new StringBuilder();
            stringBuilderReplace.Append("John Smith");
            stringBuilderReplace.Replace("John", "James"); //Replace "John" with "James"
            Console.WriteLine(stringBuilderReplace.ToString());



            //Mutable VS Immutable
            string exampleString = "a value";
            Console.WriteLine("Hash 1 of a string: " + exampleString.GetHashCode());
            exampleString = "a different value";
            Console.WriteLine("Hash 2 of a string: " + exampleString.GetHashCode());

            StringBuilder stringBuilderImmutable = new StringBuilder();
            Console.WriteLine("Hash 1 of a stringbuilder: " + stringBuilderImmutable.GetHashCode());
            stringBuilderImmutable.Append("abcdefg");
            Console.WriteLine("Hash 2 of a stringbuilder: " + stringBuilderImmutable.GetHashCode());
            
        }
    }
}
