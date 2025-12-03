using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataBaseByCompany
{
   public abstract class Employee   ///класс объекта Сотрудник
    {
        ///приватные поля данного объекта
        private int Id_;
        private string FullName_;
        private string Email_;

        ///обычные методы для работы с полями объекта
        ///метод для ввода id
        public void SetId(int Id)
        {
            Id_ = Id;
        }
        ///метод для извлечения id
        public int GetId()
        {
            return Id_;
        }
        ///метод для ввода полного фио сотрудникка
        public void SetFullName(string FullName)
        {
            FullName_ = FullName;
        }
        ///метод для извлечения подного фио сотрудника
        public string GetFullName()
        {
            return FullName_;
        }
        ///метод для ввода эл почты
        public void SetEmail(string Email)
        {
            Email_ = Email;
        }
        ///метод для извлечения эл почты
        public string GetEmail()
        {
            return Email_;
        }

        ///абстрактный метод для подсчета зп сотрудника
        ///которая будет реализована через производные классы
        public abstract double CalculateSalary();
    }
}
