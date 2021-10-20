using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: \n");
            string a = Console.ReadLine();
            string[] str = a.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int index = 0;
            int max = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > index)
                {
                    index = str[i].Length;
                    max = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", str[max]);
            Console.ReadLine();
        }
    }
}
