namespace TestNoPermissions
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Approach 1
            Person underTwentyOne = new Person(19, "John Doe");
            Person overTwentyOne = new Person(22, "John Smith-Doe");

            Person[] people = new Person[]
            {
                underTwentyOne,
                overTwentyOne
            };

            if (people.GetAdults().Contains(underTwentyOne))
                Console.WriteLine("The limit is at 18");
            else
                Console.WriteLine("The limit is at 21");

            //Approach 2
            Person[] people2 = new Person[30];
            for(int i = 0; i < 30; i++)
            {
                people2[i] = new Person(i, "lorem");
            }
            Console.WriteLine("The limit is at " + (30-people2.GetAdults().Length).ToString());
        }
    }
}
