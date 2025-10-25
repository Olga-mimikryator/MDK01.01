using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
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

            double min = userArray[0];
            double max = userArray[0];
            for (int i = 1; i < lengthArray; i++)
            {
                if (userArray[i] < min)
                    min = userArray[i];
                if (userArray[i] > max)
                    max = userArray[i];
            }
            double minMaxDifference = max - min;
            Console.WriteLine($"Разница между минимальным элементом {min}" +
                              $" и максимальным элементом {max}: {minMaxDifference}");

            

        }
    }
}
