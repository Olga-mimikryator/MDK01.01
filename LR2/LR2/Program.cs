using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Program
    {
        static void Print(List<string> employees)
        {
            Console.WriteLine(String.Join(", ", employees));
        }

        static void Main()
        {
            string[] employeeCategory = new string[] { "Инженеры", "Научный корпус", "Бухгалтерия" };
            var (employees, salaries) = InputModule.InputByEmployeeCategory();

            string userQuery = InputModule.InputUserQuery();

            int indexCategory = SearchingModule.FindIndexCategory(userQuery, employeeCategory);
            if (indexCategory < 0)
            {
                Console.WriteLine($"Какое еще {userQuery}? Не выделывайся и выбирай существующую категорию!");
                return;
            }

            var (employeesUserCategory, salariesUserCategory) = SearchingModule.FindAllEmployeesByCategory(indexCategory, employees, salaries);

            List <double> averageSalariesUserCategory = AnalysisDataModule.CalculateAverageSalaries(salariesUserCategory);
            AnalysisDataModule.SortEmployeesBySalary(employeesUserCategory, averageSalariesUserCategory);
            Print (employeesUserCategory);
        }
    }
}
