using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataBaseByCompany
{
    public class FreelancerEmployee : Employee
    {
        private double PriceProject_;   ///плата за проект
        private double Ndfl_;

        public void SetPriceProject(double PriceProject)
        {
            PriceProject_ = PriceProject;
        }
        public void SetNdfl(double Ndfl)
        {
            Ndfl_ = Ndfl;
        }

        public override double CalculateSalary()
        {
            double SalaryBeforeNdfl = PriceProject_ - (PriceProject_ * Ndfl_ / 100);
            return SalaryBeforeNdfl;
        }
    }
}
