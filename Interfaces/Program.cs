namespace Interfaces
{
    public interface IAnimal
    {
        public void Eat();
        public void Walk(int speed);
        public void Run(int speed);
    }

    public class Sheep : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Sheep ate grass");
        }

        public void Walk(int speed)
        {
            Console.WriteLine("Sheep walked at a speed of " + speed + "km/h");
        }

        public void Run(int speed)
        {
            Console.WriteLine("Sheep ran at a speed of " + speed + "km/h");
        }
    }

    public class Wolf : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Wolf ate meat");
        }

        public void Walk(int speed)
        {
            Console.WriteLine("Wolf walked at a speed of " + speed + "km/h");
        }

        public void Run(int speed)
        {
            Console.WriteLine("Wolf ran at a speed of " + speed + "km/h");
        }
    }

    public class Zoo
    {
        public Zoo()
        {
            Sheep sheep = new Sheep();
            sheep.Walk(3);

            Wolf wolf = new Wolf();
            wolf.Run(40);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
        }
    }
}
