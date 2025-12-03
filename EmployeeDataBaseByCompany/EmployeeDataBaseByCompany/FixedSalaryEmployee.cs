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

        public void SetSalaryMonth(double SalaryMonth)
        {
            SalaryMonth_ = SalaryMonth;
        }
        public override double CalculateSalary()
        {
            return SalaryMonth_;
        }
    }
}
