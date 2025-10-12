using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class InputModule
    {
        static public (List<string>[], List<List<int>>[]) InputByEmployeeCategory()
        {
            List<string>[] employeesByEmployeeCategory = new List<string>[3] {new List<string>(), 
                                                                              new List<string>(),
                                                                              new List<string>()};
            List<List<int>>[] salariesOfEmployeesByCategory = new List<List<int>>[3] {new List<List<int>>(),
                                                                                      new List<List<int>>(),
                                                                                      new List<List<int>>()};
            ///Вносим данные о сотрудниках и их зарплатах за 6 месяцев
            ///Заполняем списки Инженеров
            employeesByEmployeeCategory[0].Add("Лисичкина Е.Н.");
            salariesOfEmployeesByCategory[0].Add(new List<int> {40000, 41500, 34000, 43000, 42550, 45000});
            employeesByEmployeeCategory[0].Add("Кириешкин В.С.");
            salariesOfEmployeesByCategory[0].Add(new List<int> {42000, 41240, 40350, 37000, 41050, 43000});
            employeesByEmployeeCategory[0].Add("Васнецов С.А.");
            salariesOfEmployeesByCategory[0].Add(new List<int> {30000, 32000, 31500, 30545, 31010, 30025});
            ///Заполняем Научный корпус
            employeesByEmployeeCategory[1].Add("Гена Букин");
            salariesOfEmployeesByCategory[1].Add(new List<int> {55555, 52450, 56750, 57000, 53000, 53500});
            employeesByEmployeeCategory[1].Add("}{отт@бь)ч");
            salariesOfEmployeesByCategory[1].Add(new List<int> {100000, 101010, 99999, 100001, 98500, 99365});
            employeesByEmployeeCategory[1].Add("Сорокина А.В.");
            salariesOfEmployeesByCategory[1].Add(new List<int> {99345, 101450, 100540, 107045, 105890, 110730});
            ///Заполняем Бухгалтерию
            employeesByEmployeeCategory[2].Add("Гугич С.П.");
            salariesOfEmployeesByCategory[2].Add(new List<int> {39000, 40050, 38180, 38500, 39300, 35009});
            employeesByEmployeeCategory[2].Add("Ктулху");
            salariesOfEmployeesByCategory[2].Add(new List<int> {45020, 48000, 47500, 48035, 48549, 50348});
            employeesByEmployeeCategory[2].Add("Криштиану Роналду");
            salariesOfEmployeesByCategory[2].Add(new List<int> {20000, 20000, 20000, 20000, 20000, 20000});

            return (employeesByEmployeeCategory, salariesOfEmployeesByCategory);
        }
    }
}
