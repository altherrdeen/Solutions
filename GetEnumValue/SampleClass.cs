using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumValues
{
    internal class SampleClass
    {
        public SampleClass()
        {
            //Get Enum by index
            GetEnumByIndex(10);

            //Get index of value
            GetIndexByValue("are");
        }

        private string GetEnumByIndex(int index)
        {
            return Enum.GetName(typeof(TestEnum), index);
            //Second option
            //Enum.ToObject(typeof(TestEnum), index).ToString(); 
        }

        private int GetIndexByValue(string value)
        {
            return Array.FindIndex(System.Enum.GetNames(typeof(TestEnum)), x => x.Contains(value));
        }

        enum TestEnum
        {
            lorem,
            ipsum,
            dolor,
            and,
            other,
            words,
            are,
            used,
            to,
            test,
            the,
            current,
            project
        }
    }
}
