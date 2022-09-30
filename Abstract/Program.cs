namespace Abstract
{
    public abstract class Schüler
    {
        public abstract void GoToSchool();

        public void DoHomework()
        {
            Console.WriteLine("Student is doing Homework");
        }
    }

    public class HSGStudent : Schüler
    {
        public override void GoToSchool()
        {
            Console.WriteLine("Student goes to HSG");
        }
    }

    public class GBSStudent : Schüler
    {
        public override void GoToSchool()
        {
            Console.WriteLine("Student goes to GBS");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            HSGStudent hsgStudent = new HSGStudent();
            hsgStudent.GoToSchool();
            hsgStudent.DoHomework();

            GBSStudent gbsStudent = new GBSStudent();
            gbsStudent.GoToSchool();
            gbsStudent.DoHomework();
        }
    }
}
