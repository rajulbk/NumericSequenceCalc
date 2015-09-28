using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace NumericSequenceCalc.Domain
{
    public class SequenceCalculator
    {

        public string S311(int number)
        {
            string temp = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                temp += i + ",";
            }
            if(temp != "")
            {
                temp = temp.Substring(0, temp.Length - 1);
            }
            return temp;
        }

        public string S312(int number)
        {
            string temp = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 1)
                {
                    temp += i + ",";
                }
            }
            if (temp != "")
            {
                temp = temp.Substring(0, temp.Length - 1);
            }
            return temp;
        }

        public string S313(int number)
        {
            string temp = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    temp += i + ",";
                }
            }
            if (temp != "")
            {
                temp = temp.Substring(0, temp.Length - 1);
            }
            return temp;
        }

        public string S314(int number)
        {
            string temp = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    temp += "Z,";
                }
                else if (i % 3 == 0)
                {
                    temp += "C,";
                }
                else if (i % 5 == 0)
                {
                    temp += "E,";
                }
                else
                {
                    temp += i + ",";
                }             
            }
            if (temp != "")
            {
                temp = temp.Substring(0, temp.Length - 1);
            }
            return temp;
        }

        public string S315(int number)
        {
            string temp = string.Empty;
            int a = 0;
            int b = 1;
            int c = a+b;
            temp = a +"," +b+",";
            while(c <= number)
            {
                temp += c + ",";
                a = b;
                b = c;
                c = a + b;            
            }
            if (temp != "")
            {
                temp = temp.Substring(0, temp.Length - 1);
            }
            return temp;
        }

    }
}