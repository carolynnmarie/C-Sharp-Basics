using System;
using System.Collections.Generic;

namespace C_Sharp_Basics{

    public class Generics<T>{

        private T[] array {get; set;}
        private T[] secondArray {get;set;}

        public Generics(T[] array){
            this.array = array;
            this.secondArray = new T[]{};
        }

        public int countDuplicates(T[] array, T value){
            int x = 0;
            foreach(T item in array){
                if(item.Equals(value)) x++;
            }
            return x;
        }

        public int countDuplicatesInMerge(T[] arrayToMerge, T value){
            List<T> list = new List<T>(array);
            list.AddRange(arrayToMerge);
            return countDuplicates(list.ToArray(), value);
        }
    }
}