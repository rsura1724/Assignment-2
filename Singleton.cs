using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        public static int count = 0;
        private static Singleton instance = null;
        private Singleton()
        {
            count++;
            Console.WriteLine( count.ToString()+" Object created");
        }


        public static Singleton getInstance()
        {

            if (instance == null)
            {
                instance = new Singleton();
            }
                return instance;
                
            
            
        }
        public void displayDetails(string text)
        {
            //text = "hello";
            Console.WriteLine(text);
        }
    }
}
