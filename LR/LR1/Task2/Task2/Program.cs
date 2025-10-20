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

        }
    }
}
