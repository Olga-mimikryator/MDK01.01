using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Вариант 7
            ///Задание 1
            
            Console.Write("Введите желаемое количество элементов массива: ");
            int lengthArray = Convert.ToInt32(Console.ReadLine());

            double[] userArray = new double[lengthArray];
            for (int i = 0; i < lengthArray; i++)
            {
                Console.Write($"Введите {i + 1} элемент: ");
                userArray[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Получившийся массив: ");
            Console.WriteLine(string.Join("; ", userArray));

        }
    }
}
