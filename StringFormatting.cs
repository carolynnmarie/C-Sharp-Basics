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

        public string printPhoneNumber(double number){
            return number.ToString("(###)###-####");
        }

        public string printMoney(decimal number){
            return number.ToString("C2");
        }

        public string printInterpolatedVariables(string v1, string v2){
            return String.Format("variable 1: {0}, variable 2: {1}",v1, v2);
        }
    }
}