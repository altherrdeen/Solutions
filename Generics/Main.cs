using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Main<T>
    {
        public List<T> _elements = new List<T>();

        public Main(T element1, T element2)
        {
            _elements.Add(element1);
            _elements.Add(element2);
        }
        public void Show()
        {
            foreach (T element in _elements)
            {
                Console.WriteLine(element);
            }
        }

        public T RandomElement()
        {
            Random rnd = new Random();
            return _elements[rnd.Next(0, _elements.Count())];
        }

        public List<T> GetElements()
        {
            return _elements;
        }
    }
}
