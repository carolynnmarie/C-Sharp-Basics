using System;
using System.Collections.Generic;

namespace C_Sharp_Basics{

    public class Collection{

        List<String> list {get; set;}
        Dictionary<String, int> dictionary {get; set;}
        HashSet<int> hashSet {get; set;}

        public Collection(){
            this.list = new List<String>();
            this.dictionary = new Dictionary<String, int>();
            this.hashSet = new HashSet<int>();
        }


    }
}