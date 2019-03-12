using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input word:");
            String st =  Console.ReadLine().ToLower();
            int sum = 0;

            for (int i = 0; i < st.Length; i++)
            {
                if (st[i].Equals('a')) sum++; 
            }
            Console.WriteLine($"Number of 'a' = {sum} ");

            Console.ReadKey();
        }
    }
}
