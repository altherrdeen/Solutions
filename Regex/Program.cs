using System.Text.RegularExpressions;
namespace RegexExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Regex.IsMatch("50", "[10-30]")); //Output: true
            //-----------------IsMatch-----------------
            Console.WriteLine(Regex.IsMatch("John Smith", "John")); //Check if there is a "John" in "John Smith", returns true
            Console.WriteLine(Regex.IsMatch("SmithJohnson@gmail.com", "John")); //Returns true
            Console.WriteLine(Regex.IsMatch("john Smith", "John")); //Returns false, because IsMatch is case sensitive

            //-----------------Extracharacters-----------------
            Console.WriteLine(Regex.IsMatch("J.Smith", "[^J.Smith]")); //Check if the character IS NOT "J.Smith", returnes false
            Console.WriteLine(Regex.IsMatch("J.Cena", "[^J.Smith]"));  //Returns true

            Console.WriteLine(Regex.IsMatch("452", "^[0-9]+$"));  //Checks if the characters are numbers, returns true
            Console.WriteLine(Regex.IsMatch("45d2", "^[0-9]+$")); //Returns false
            Console.WriteLine(Regex.IsMatch("ad", "^[a-z]+$"));  //Checks if the characters are digits, returns true
            Console.WriteLine(Regex.IsMatch("ai", "^[a,e,i,o,u]+$"));  //Checks if all characters are a,e,i,o or u, returns true
            Console.WriteLine(Regex.IsMatch("aib", "^[a,e,i,o,u]+$"));  //Returns false

            //-----------------Gmail Address example-----------------
            Console.WriteLine(ContainsGmailAddress("johnsmith1990@gmail.com")); //Returns true
            Console.WriteLine(ContainsGmailAddress("This is my email address: johnsmith1990@gmail.com")); //Returns true
            Console.WriteLine(ContainsGmailAddress("johnsmith1990@icloud.com")); //Returns false
            Console.WriteLine(ContainsGmailAddress("%&@gmail.com")); //Returns false

            //-----------------Grouping example-----------------
            List<string> emails = new List<string>
            {
                "deen.altherr@gmail.com",
                "john.smith@icloud.com",
                "john.cena@yahoo.com",
                "cristiano.ronaldo@hotmail.com"
            };
            foreach(string email in emails) //Returns "The email <email> belongs to: <surname> <name>"
            {
                Console.WriteLine("The email " + email + " belongs to:");

                foreach(var x in Regex.Split(email, @"(.+)\.(.+)@.+"))
                    Console.WriteLine(x);
            }
        }
        
        private static bool ContainsGmailAddress(string input)
        {
            return Regex.IsMatch(input, @"[a-z, A-Z, 0-9]@gmail\.com");
        }
    }
}
