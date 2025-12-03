using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataBaseByCompany
{
    class Program
    {
        static void Main()
        {
            ///создание объекта electrician класса Employee производного класса FixedSalaryEmployee
            ///суть которого в том, что заработная плата сотрудника данного типа имеет фиксированный характер
            FixedSalaryEmployee electrician = new FixedSalaryEmployee();
            ///заполнение полей созданного объекта
            electrician.SetId(1);
            electrician.SetFullName("Пикачукин Анатолий Степанович");
            electrician.SetEmail("pikachuchukin.as@gmail.com");
            electrician.SetSalaryMonth(43560);
            ///вывод на консоль информации и применение абстрактного метода CalculateSalary
            Console.WriteLine($"Заработная плата электрика {electrician.GetFullName()} составляет {electrician.CalculateSalary()} рублей");

            ///создание объекта tester класса Employee производного класса HourlySalaryEmployee
            ///суть которого в том, что зп сотрудника данного типа является почасовой и
            ///для него предусмотрена доплата по сверхурочным часам
            HourlySalaryEmployee tester = new HourlySalaryEmployee();
            ///заполнение полей созданного объекта
            tester.SetId(2);
            tester.SetFullName("БаговНет Анастасия Юрьевна");
            tester.SetEmail("bagov.nothave.au@mail.ru");
            tester.SetSalaryByOneHourWork(500.05);
            tester.SetHoursWork(110);
            tester.SetOvertimeHours(20);
            tester.SetOvertimeSalary(1.5);
            //вывод на консоль информации и применение абстрактного метода CalculateSalary
            Console.WriteLine($"Заработная плата тестера {tester.GetFullName()} составляет {tester.CalculateSalary()} рублей");

            ///создание объекта programmist класса Employee производного класса FreelancerEmployee
            ///суть которого в том, что зп сотрудника данного типа расчитывается с учетом ндфл
            FreelancerEmployee programmist = new FreelancerEmployee();
            ///заполнение полей созданного объекта
            programmist.SetId(3);
            programmist.SetFullName("НейронкиПриРазработкеНеИспользович Владимир Александрович");
            programmist.SetEmail("ai.slop.notfound@gmail.com");
            programmist.SetPriceProject(80000);
            programmist.SetNdfl(1.3);
            //вывод на консоль информации и применение абстрактного метода CalculateSalary
            Console.WriteLine($"Заработная плата программиста {programmist.GetFullName()} составляет {programmist.CalculateSalary()} рублей");
        }
    }
}
