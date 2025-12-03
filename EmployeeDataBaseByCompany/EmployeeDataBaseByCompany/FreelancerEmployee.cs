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

        ///обычные методы для ввода данных в поля
        public void SetPriceProject(double PriceProject)
        {
            PriceProject_ = PriceProject;
        }
        public void SetNdfl(double Ndfl)
        {
            Ndfl_ = Ndfl;
        }

        ///реализация метода подсчета зп для сотрудников на удаленке с учетом ндфл
        public override double CalculateSalary()
        {
            double SalaryBeforeNdfl = PriceProject_ - (PriceProject_ * Ndfl_ / 100);
            return SalaryBeforeNdfl;
        }
    }
}
