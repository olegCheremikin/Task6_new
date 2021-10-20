using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку:\n");
            string str = Console.ReadLine().Replace(" ", "").ToLower();
            string temp = str;
            string reverseStr = "";
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                reverseStr += temp[i];
            }
            if (temp == reverseStr)
            {
                Console.WriteLine("Введенная строка палиндром!");
            }
            else
            {
                Console.WriteLine("Введенная строка не палиндром!");
            }
            Console.ReadKey();
        }
    }
}
