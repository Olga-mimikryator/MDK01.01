using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataBaseByCompany
{
   public abstract class Employee
    {
        private int Id_;
        private string FullName_;
        private string Email_;

        public void SetId(int Id)
        {
            Id_ = Id;
        }
        public int GetId()
        {
            return Id_;
        }
        public void SetFullName(string FullName)
        {
            FullName_ = FullName;
        }
        public string GetFullName()
        {
            return FullName_;
        }
        public void SetEmail(string Email)
        {
            Email_ = Email;
        }
        public string GetEmail()
        {
            return Email_;
        }

        public abstract double CalculateSalary();
    }
}
