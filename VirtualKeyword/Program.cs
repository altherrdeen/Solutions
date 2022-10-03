namespace VirtualKeyword
{
    public class Product
    {
        public virtual void PrintPrice()
        {
            Console.WriteLine("The price is 1$");
        }
    }

    public class Hat : Product { }

    public class Catalog : Product
    {
        public override void PrintPrice()
        {
            Console.WriteLine("The product is free");
        }
    }

    public class OneDollarStore 
    {
        public OneDollarStore()
        {
            Hat nikeHat = new Hat();
            nikeHat.PrintPrice();

            Catalog catalog = new Catalog();
            catalog.PrintPrice();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            OneDollarStore exampleStore = new OneDollarStore();
        }
    }
}
