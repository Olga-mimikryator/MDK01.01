using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassAplication
{
    internal class Program
    {
        static void Main()
        {
            Warehouse TorzhokWarehouse = new Warehouse();
            TorzhokWarehouse.SetId(1);
            TorzhokWarehouse.SetLocation("Торжок, ул. Студенческая 3");

            Goods car1 = new Goods();
            car1.SetName("МерседесБендс");
            car1.SetPrice(1200000);
            Goods car2 = new Goods();
            car2.SetName("Уазик");
            car2.SetPrice(10000000);

            TorzhokWarehouse.SetGoodsCount(car1, 2);
            TorzhokWarehouse.SetGoodsCount(car2, 5);

            Console.WriteLine($"Уникальный код склада: {TorzhokWarehouse.GetId()} | Адрес склада: {TorzhokWarehouse.GetLocation()}");
            
        }
    }
}
