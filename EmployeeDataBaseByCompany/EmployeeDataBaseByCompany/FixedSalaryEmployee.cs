using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataBaseByCompany
{
   public class FixedSalaryEmployee : Employee
    {
        private double SalaryMonth_; ///фиксированная месячная плата

        ///обычный метод для ввода фиксированной месячной зп
        public void SetSalaryMonth(double SalaryMonth)
        {
            SalaryMonth_ = SalaryMonth;
        }
        ///реализация метода подсчета зп для сотрудников с фиксированной зп
        public override double CalculateSalary()
        {
            return SalaryMonth_;
        }
    }
}
