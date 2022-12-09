using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonVSStatic
{
    public class SingletonExample : IExampleInterface //Implementing interface/class throws no exception
    {
        private string ExampleVariable = String.Empty; //Declaring non-static variable throws no exception
        
        private static readonly SingletonExample _instance = new SingletonExample();
        public bool ExampleMethod() { return true; } //Non-static method throws no exception
        private SingletonExample() { }

        public static SingletonExample GetInstance()
        {
            return _instance;
        }
    }
}
