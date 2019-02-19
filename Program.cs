using System;
using C_Sharp_Basics;
using System.Collections.Generic;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            // StringFormatting format = new StringFormatting();
            // Console.WriteLine(format.printInterpolatedVariables("id","peacock"));
            // decimal x = 4.5M;
            // Console.WriteLine(format.printMoney(x));
            // decimal y = 4;
            // Console.WriteLine(format.printMoney(y));
            // string[] arr = {"a","b","c","d"};
            // string[] arr2 = {"e","f","g","h"};
            // Arrays array1 = new Arrays(arr);
            
            // string[] merged = array1.mergeArrays(arr2);
            // string mString = String.Join("",merged);
            // Console.WriteLine(mString);
            // int x = 8;
            // int y = 10;
            // string a = $"variable x is {x} and variable y is {y}";
            // Console.WriteLine(a);

            Basics basic = new Basics();
            basic.changeName();
            Console.WriteLine(basic.helloName());
    
        }
    }
}
