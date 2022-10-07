namespace MultipleInheritanceInterfaces
{
    public interface IProduct
    {
        public void Sell();
    }

    public interface IDiscount
    {
        public void AdvertiseDiscount();
    }

    public class Chair : IDiscount, IProduct
    {
        public void Sell()
        {
            Console.WriteLine("The chair was sold");
        }

        public void AdvertiseDiscount()
        {
            Console.WriteLine("This chair is on sale");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Chair chair = new Chair();
            chair.Sell();
            chair.AdvertiseDiscount();
        }
    }
}
