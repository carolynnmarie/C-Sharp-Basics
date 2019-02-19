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
        //string.Join("deliniator", string[] array) will take a string array and turn it into a string w/
        //the deliniator in between the string objects of the array
        public string printArray(string[] stringArray){
            return string.Join(" ", stringArray);
        }

        public void changeName(){
            firstName = "Luis";
            lastName = "Romero";
        }

        public string singleCommandIfElse(int x, int y){
            string answer = "";
            if(x>y)
                answer = "variable x is greater than variable y";
            else
                answer = "variable x is not greater than y";
            return answer;
        }

        public string multiCommandIfElse(int x, int y){
            string answer = "";
            int difference = 0;
            if(x>y){
                difference = x-y;
                answer = $"x is greater than y by {difference}";
            }
            else {
                difference = y-x;
                answer = $"y is greater than x by {difference}";
            }
            return answer;
        }

    }

    public class Basics2{
        public string FirstName{get;set;}
        public Basics2(string firstName) => FirstName = firstName;
        public Basics2() => FirstName = "Carolynn";

    }
}