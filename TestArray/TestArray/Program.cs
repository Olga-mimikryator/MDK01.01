using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3];
            array[0] = "Я помню чудное мгновение";
            array[1] = "Передо мной явилась ты";
            array[2] = "Как мимолетное видение, как гений чистой красоты";

            array[1] = "Передо мной преобразовалась в кинетическую энергию ты";
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            
           
            string[] twoArray = new string[3];
            twoArray[0] = array[2];
            twoArray[1] = array[1];
            twoArray[2] = array[0];

            Console.WriteLine(twoArray[0]);
            Console.WriteLine(twoArray[1]);
            Console.WriteLine(twoArray[2]);
        }
    }
}
