using System;
using C_Sharp_Basics;
using System.Collections.Generic;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
 //           Basics method = new Basics();

            // int[] array = {1,2,1,3,4,5,1,7};
            // Console.WriteLine(method.removeValue(array, 1));

            int[] array2 = {1,2,3,4,1,5,6,7,1};
            // Generics<int> generic = new Generics<int>(array2);

            // Console.WriteLine(generic.countDuplicatesInMerge(new int[]{2,3,4,1}, 1));

            Dictionary<String, int> dictionary2 = new Dictionary<string, int>();
            dictionary2.Add("My name", 5);
            dictionary2.Add("Carolynn", 7);
            dictionary2.Add("John", 9);
            
            List<int> list = new List<int>(array2);
            Collection collections = new Collection();
            collections.dictionary = dictionary2;
            string y = collections.listToString(collections.getValues());
            Console.WriteLine(y);
     //       Console.WriteLine(collections.getKeys());
        }
    }
}
