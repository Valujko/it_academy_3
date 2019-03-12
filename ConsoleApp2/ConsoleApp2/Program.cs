using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = (Color)(new System.Random().Next(0, 3));
            Console.WriteLine(color);

            switch (color)
            {
                case Color.Red:
                    Console.WriteLine("The color is red ");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is green ");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue ");
                    break;
                default:
                    //TODO implement logging
                    break;
            }
            Console.ReadKey();
        }

    }
    public enum Color { Red, Green, Blue }
}
