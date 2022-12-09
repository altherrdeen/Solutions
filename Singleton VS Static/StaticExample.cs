using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonVSStatic
{
    public static class StaticExample : IExampleInterface //Implementing interface/class throws exception
    {
        private string ExampleVariable = String.Empty; //Declaring non-static variable throws exception
    }
}
