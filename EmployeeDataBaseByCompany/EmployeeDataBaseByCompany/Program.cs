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
            FixedSalaryEmployee electrician = new FixedSalaryEmployee();
            electrician.SetId(1);
            electrician.SetFullName("Пикачукин Анатолий Степанович");
            electrician.SetEmail("pikachuchukin.as@gmail.com");
            electrician.SetSalaryMonth(43560);
            Console.WriteLine($"Заработная плата электрика {electrician.GetFullName()} составляет {electrician.CalculateSalary()} рублей");

            HourlySalaryEmployee tester = new HourlySalaryEmployee();
            tester.SetId(2);
            tester.SetFullName("БаговНет Анастасия Юрьевна");
            tester.SetEmail("bagov.nothave.au@mail.ru");
            tester.SetSalaryByOneHourWork(500.05);
            tester.SetHoursWork(110);
            tester.SetOvertimeHours(20);
            tester.SetOvertimeSalary(1.5);
            Console.WriteLine($"Заработная плата тестера {tester.GetFullName()} составляет {tester.CalculateSalary()} рублей");

            FreelancerEmployee programmist = new FreelancerEmployee();
            programmist.SetId(3);
            programmist.SetFullName("НейронкиПриРазработкеНеИспользович Владимир Александрович");
            programmist.SetEmail("ai.slop.notfound@gmail.com");
            programmist.SetPriceProject(80000);
            programmist.SetNdfl(1.3);
            Console.WriteLine($"Заработная плата программиста {programmist.GetFullName()} составляет {programmist.CalculateSalary()} рублей");
        }
    }
}
