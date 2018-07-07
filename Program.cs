using System;
using C_Sharp_Basics;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Basics method = new Basics();

            // int[] array = {1,2,1,3,4,5,1,7};
            // Console.WriteLine(method.removeValue(array, 1));

            int[] array2 = {1,2,3,4,1,5,6,7,1};
            Generics<int> generic = new Generics<int>(array2);

            Console.WriteLine(generic.countDuplicatesInMerge(new int[]{2,3,4,1}, 1));
        }
    }
}
