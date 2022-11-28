using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineDictionaries
{
    public class DictionaryCombiner
    {
        public Dictionary<int, string> CombineTwoDictionaries(IDictionary<int, string> dict1, IDictionary<int, string> dict2) //Only one of the duplicate keys is added
        {
            return dict1.Concat(dict2
                .Where(person => !dict1.ContainsKey(person.Key)))
                .ToDictionary(x => x.Key, x => x.Value);
        }

        public Dictionary<int, string> CombineTwoDictionariesV2(IDictionary<int, string> dict1, IDictionary<int, string> dict2) //One of the duplicate keys is changed to a different number
        {
            IDictionary<int, string> combinedDicts = new Dictionary<int, string>();
            foreach (var person in dict1)
            {
                int currentKey = person.Key;
                while (dict2.ContainsKey(currentKey) || combinedDicts.ContainsKey(currentKey))
                    currentKey++;
                combinedDicts.Add(currentKey, person.Value);
            }

            return combinedDicts.Concat(dict2
                .Where(person => !combinedDicts.ContainsKey(person.Key)))
                .ToDictionary(x => x.Key, x => x.Value);
        }

        public Tuple<Dictionary<int, string>, Dictionary<int, string>> CombineTwoDictionariesV3(IDictionary<int, string> dict1, IDictionary<int, string> dict2) //An Array with duplicate keys is made in addition
        {
            Dictionary<int, string> duplicateKeyDictionary = new Dictionary<int, string>();

            foreach(var person in dict2)
            {
                if(dict1.ContainsKey(person.Key))
                    duplicateKeyDictionary.Add(person.Key, person.Value);
            }

            return Tuple.Create(dict1.Concat(dict2
                .Where(person => !dict1.ContainsKey(person.Key)))
                .ToDictionary(x => x.Key, x => x.Value), 
                duplicateKeyDictionary);
        }

        public Dictionary<int, string> CombineTwoDictionariesV4(IDictionary<int, string> dict1, IDictionary<int, string> dict2) //Values of duplicate keys are combined
        {
            IDictionary<int, string> combinedDictionaries = new Dictionary<int, string>();

            foreach(var person in dict1)
            {
                combinedDictionaries.Add(person.Key, person.Value);
                if (dict2.ContainsKey(person.Key))
                {
                    combinedDictionaries[person.Key] += "/"+dict2[person.Key];
                }
            }

            return combinedDictionaries
               .Concat(dict2
               .Where(person => !combinedDictionaries.ContainsKey(person.Key)))
               .ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
