using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNoPermissions
{
    public static class ExampleLibrary
    {
        public static Person[] GetAdults(this Person[] people)
        {
            List<Person> adults = new List<Person>();
            foreach(Person person in people)
            {
                if(person._age >= 21)
                    adults.Add(person);
            }
            return adults.ToArray();
        }
    }
}
