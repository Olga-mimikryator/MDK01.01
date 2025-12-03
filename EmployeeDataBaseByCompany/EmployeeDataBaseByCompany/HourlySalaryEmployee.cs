using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataBaseByCompany
{
    public class HourlySalaryEmployee : Employee
    {
        private double SalaryByOneHourWork_;    ///почасовая плата
        private double HoursWork_;              ///часы работы
        private double OvertimeSalary_;         ///плата по сверхурочным часам
        private double OvertimeHours_;          ///количесвто свезхурочных часов

        ///методы для ввода ифнормации в поля объекта
        public void SetSalaryByOneHourWork(double SalaryByOneHourWork)
        {
            SalaryByOneHourWork_ = SalaryByOneHourWork;
        }
        public void SetHoursWork(double HoursWork)
        {
            HoursWork_ = HoursWork;
        }
        public void SetOvertimeSalary(double OvertimeSalary)
        {
            OvertimeSalary_ = OvertimeSalary;
        }
        public void SetOvertimeHours(double OvertimeHours)
        {
            OvertimeHours_ = OvertimeHours;
        }

        ///реализация метода для подсчета зп сотрудников с почасовой зп
        public override double CalculateSalary()
        {
            double SalaryWork = SalaryByOneHourWork_ * HoursWork_;
            double SalaryOvertime = OvertimeSalary_ * OvertimeHours_;
            return SalaryWork + SalaryOvertime;
        }
    }
}
