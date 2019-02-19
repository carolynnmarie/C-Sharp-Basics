using System;
using System.Text;
using System.Collections.Generic;

namespace C_Sharp_Basics{
    
    public class Loops{

        public static string getTriangle(int numberOfRows) {
            int x = 0;
            string aLine = "*";
            string aTri = "*\n";
            while(x<numberOfRows){
                aLine += "*";
                aTri += aLine + "\n";
                x++;
            }
            return aTri;
        }

        public static string getOddNumbers(int start, int stop){
            String x = " ";
            if(start %2 == 0) start++;
            for(int i = start; i<stop; i+=2) x += i;
            return x;
        }


        public int countDuplicates(int[] array, int value){
            int x = 0;
            foreach(int item in array){
                if(item == value) x++;
            }
            return x;
        }

        public string removeValue(int[] array, int item){
            List<int> list = new List<int>();
            for(int i = 0; i<array.Length; i++){
                if(array[i] != item) list.Add(array[i]);
            }
            return string.Join(",", list);
        }

        //you can use the keyword var in a foreach loop instead of specifying type, at least for non-custom objects
        public string varForEachLoop(List<string> array){
            StringBuilder builder = new StringBuilder();
            foreach(var item in array){
                builder.Append(item).Append(" ");
            }
            return builder.ToString();
        }
    }
}