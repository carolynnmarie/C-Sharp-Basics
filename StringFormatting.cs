using System;
using System.Text;

namespace C_Sharp_Basics{

    public class StringFormatting{
        
        public static string getMultiplicationTable(int tableSize){
            StringBuilder builder = new StringBuilder();
            for(int i = 1; i<=tableSize; i++){
                string multiply = "";
                for(int j=1; j<=tableSize; j++){
                    int y = i*j;
                    string x = y.ToString();
                    multiply += x.PadLeft(5,' ') + "|";
                }
                builder.Append(multiply).Append("\n");
            }
            return builder.ToString();
        }
    }
}