using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Вариант 7
            ///Задание 2

            Random rnd = new Random();
            List<int> numbersEndingWith4 = new List<int>();

            for (int i = 0; i < 2500; i++)
            {
                int number = rnd.Next(-2000, 2001);

                if (number % 10 == 4 || number % 10 == -4)
                {
                    numbersEndingWith4.Add(number);
                }
            }

            if (numbersEndingWith4.Count > 0)
            {
                Console.Write("[");
                for (int i = 0; i < numbersEndingWith4.Count - 1; i++)
                {
                    Console.Write(numbersEndingWith4[i] + ",");
                }
                Console.Write(numbersEndingWith4[numbersEndingWith4.Count - 1] + "]");
            }
            else Console.WriteLine("Среди случайных чисел не было таких, " +
                                    "которые оканчивались бы на четыре!");

        }
    }
}
