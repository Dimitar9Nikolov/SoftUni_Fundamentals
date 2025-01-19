using System;
using System.Text;

namespace _05_DataAndTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = startNumber; i <= endNumber; i++)
            {
                char ASCII = (char)i;
                Console.Write($"{ASCII} ");
            }


            char asciiValue = (char)startNumber;
        }
    }
}
