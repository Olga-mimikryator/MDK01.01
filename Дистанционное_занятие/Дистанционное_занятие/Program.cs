using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дистанционное_занятие
{
    internal class Program
    {
        /// Функция для поиска десяти объектов из списка 
        /// с наибольшим значением параметра liters
        static List<FuelRefill> GetTop10ByLiters(List<FuelRefill> list)
        {
            List<FuelRefill> sortedList = new List<FuelRefill>(list);

            // Сортируем по убыванию литров
            for (int i = 0; i < sortedList.Count - 1; i++)
            {
                for (int j = 0; j < sortedList.Count - i - 1; j++)
                {
                    if (sortedList[j].liters < sortedList[j + 1].liters)
                    {
                        FuelRefill temp = sortedList[j];
                        sortedList[j] = sortedList[j + 1];
                        sortedList[j + 1] = temp;
                    }
                }
            }

            // Возвращаем первые 10
            List<FuelRefill> top10 = new List<FuelRefill>();
            for (int i = 0; i < 10 && i < sortedList.Count; i++)
            {
                top10.Add(sortedList[i]);
            }
            return top10;
        }

        static void Main()
        {
            /// Список из структур FuelRefill
            List<FuelRefill> refills = new List<FuelRefill>();
            
            Random random = new Random();       
            for (int i = 0; i < 101;  i++)      ///цикл для заполнения списка данными о
            {                                   ///сотне структур FuelRefill
                FuelRefill newrefill = new FuelRefill("A" + (100 + i).ToString(),   ///заполнение от А100 до А200
                                                      random.Next(10, 71),          ///случайные числа от 10 до 70
                                                      random.Next(900, 3001),       ///случайные числа от 900 до 3000
                                                      random.Next(4, 21)            ///случайные числа от 4 до 20
                );

                refills.Add(newrefill);
                ///refills[i].Show();
            }

            List<FuelRefill> topLiters = GetTop10ByLiters(refills);
            Console.WriteLine("Топ-10 по количеству литров:");
            for (int i = 0; i < topLiters.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                topLiters[i].Show();
            }
        }
    }
}
