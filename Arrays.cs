using System;
using System.Collections.Generic;

namespace C_Sharp_Basics{
    public class Arrays{

        public int[] numberArray {get;set;}
        public string[] stringArray {get;set;}

        public Arrays(int[] numberArray){
            this.numberArray = numberArray;
        }

        public Arrays(string[] stringArray){
            this.stringArray = stringArray;
        }

        public string[] mergeArrays(string[] sArray2){
            string[] mergedArray = new string[stringArray.Length + sArray2.Length];
            stringArray.CopyTo(mergedArray,0);
            sArray2.CopyTo(mergedArray,stringArray.Length-1);
            return mergedArray;
        }

        public string[] removeDuplicates(){
            string [] removedDupes = new string[stringArray.Length];
            int count = 0;
            int x = 0;
            foreach(string item in stringArray){
                if(countDups(stringArray,item)<1)
                removedDupes[x] = item;
                x++;
            }
            return removedDupes;
        }

        private int countDups(string[] array, string x){
            int count = 0;
            foreach(string item in array){
                if(item.Equals(x)) count++;
            }
            return count;
        }
    }
}