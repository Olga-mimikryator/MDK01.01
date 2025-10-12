using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class SearchingModule
    {
        static public int FindIndexCategory(string userQuery, string[] EmployeeCategory)
        {
            for (int index = 0; index < EmployeeCategory.Length; ++index)
            {
                string valueEmployeeCategory = EmployeeCategory[index].ToLower();
                if (valueEmployeeCategory == userQuery.ToLower())
                {
                    return index;
                }
            }

            return -1;
        }

        static public (List<string>, List<List<int>>) FindAllEmployeesByCategory(int indexCategory, 
                                                                                 List<string>[] allEmployees, 
                                                                                 List<List<int>>[] salaries)
        {
            List<string> employeesByCategory = new List<string>();
            List<List<int>> salariesByCategory = new List<List<int>>();

            employeesByCategory = allEmployees[indexCategory];
            salariesByCategory = salaries[indexCategory];

            return (employeesByCategory, salariesByCategory);
        }
    }
}
