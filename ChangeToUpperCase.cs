using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ChangeToUpperCase
    {
        public static string changeCase(this string input)
        {

            char[] charArray = new char[input.Length];
            charArray = input.ToUpper().ToCharArray();
            if (input.Length > 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Console.WriteLine(charArray[i]);
                    return new string(charArray);
                }
            }
           
            return input;
        }

    }
}
