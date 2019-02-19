using System;
using System.Collections.Generic;

namespace C_Sharp_Basics{

    public class Collection{

        public List<String> list {get; set;}
        public Dictionary<String, int> dictionary {get; set;}
        public HashSet<int> hashSet {get; set;}

        public Collection(){
            this.list = new List<String>();
            this.dictionary = new Dictionary<String, int>();
            this.hashSet = new HashSet<int>();
        }

        public Collection(Dictionary<String, int> dictionary){
            this.list = new List<String>();
            this.dictionary = dictionary;
            this.hashSet = new HashSet<int>();
        }

        public List<int> getDictionaryValues(){
            List<int> list2 = new List<int>(dictionary.Values);
            return list2;
        }

        public string listToString(List<int> list){
            return string.Join(", ", list);
        }
        
        public string getDictionaryKeys(){
            Dictionary<String,int>.KeyCollection keys = dictionary.Keys;
            return string.Join(",", keys);
        }

        public List<string> sortList(){
            var myList = new List<string>{"Carolynn","Luis","Elizabeth","Andrea"};
            myList.Sort();
            return myList;
        }
    }
}