using System;
using System.Collections.Generic;

namespace C_Sharp_Basics{

    public class Basics{
        private string firstName {get; set;}
        private string lastName {get; set;}
        private string fullName{get{return this.firstName + " " + this.lastName;}}

        public Basics(){
            this.firstName = "Carolynn";
            this.lastName = "Vansant";
        }

        public Basics(string firstName, string lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int add(int a, int b){
            return a + b;
        }
        public string helloName(){
            return "Hello " + this.fullName;
        }
        public string printArray(string[] stringArray){
            return string.Join(" ", stringArray);
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

        

    }
}