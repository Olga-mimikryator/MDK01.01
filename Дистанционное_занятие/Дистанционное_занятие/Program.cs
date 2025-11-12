using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дистанционное_занятие
{
    internal class Program
    {
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
        }
    }
}
