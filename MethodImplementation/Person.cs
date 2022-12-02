using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNoPermissions
{
    public class Person
    {
        public int _age { get; set; }
        public string _name { get; set; }

        public Person(int age, string name)
        {
            _age = age;
            _name = name;
        }
    }
}
