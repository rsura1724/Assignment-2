using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the first number:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = int.Parse(Console.ReadLine());
            int result;
            result = num1 + num2;
           // string path = Path.GetFullPath(output.txt);
            Console.WriteLine("The output is sent to the output.txt file");
            Console.ReadKey();
            using (StreamWriter st = new StreamWriter(@"c:\users\rohith\source\repos\DisposableDemo\DisposableDemo\output.txt"))
            {
                st.WriteLine("The sum of the two numbers  is :" + result);
                st.Dispose();
            }
        }
    }
}
