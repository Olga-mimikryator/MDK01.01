using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumUsing
{
    internal class Program
    {

        public enum EvenOrNotEven
        {
            четное,
            нечетное
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            EvenOrNotEven result = (number % 2 == 0) ? EvenOrNotEven.четное :
                                                       EvenOrNotEven.нечетное;

            Console.WriteLine($"Ваше число {result}");
        }
    }
}
