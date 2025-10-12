using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class SearchingModule
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
    }
}
