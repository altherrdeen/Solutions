namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Main<int> ints = new Main<int>(2, 6);
            Main<string> strings = new Main<string>("abc", "xyz");
            Main<double> doubles = new Main<double>(2.4, 4.9);

            Console.WriteLine("--- All Elements ---");
            ints.Show();
            strings.Show();
            doubles.Show();

            //Random elements
            Console.WriteLine("--- 1 Random element per category ---");
            Console.WriteLine("Random int: " + ints.RandomElement() + " Random string: " + strings.RandomElement() + " Random double: " + doubles.RandomElement());
        }
    }
}
