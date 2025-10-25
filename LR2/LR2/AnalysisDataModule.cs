using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class AnalysisDataModule
    {
        static public List<double> CalculateAverageSalaries(List<List<int>> salariesByEmployee)
        {
            List<double> averageSalaries = new List<double>();

            for (int i = 0; i < salariesByEmployee.Count; i++)
            {
                List<int> monthlySalaries = salariesByEmployee[i];
                double sum = 0;

                foreach (int salary in monthlySalaries)
                {
                    sum += salary;
                }

                double average = sum / monthlySalaries.Count;
                averageSalaries.Add(average);
            }

            return averageSalaries;
        }

        static public void SortEmployeesBySalary(List<string> employees, List<double> averageSalaries)
        {
            for (int i = 0; i < averageSalaries.Count; ++i)
            {
                for (int j = 0; j < averageSalaries.Count - 1; ++j)
                {
                    bool condition = averageSalaries[j + 1] > averageSalaries[j];
                    if (condition)
                    {
                        double temp_averageSalaries = averageSalaries[j];
                        averageSalaries[j] = averageSalaries[j + 1];
                        averageSalaries[j + 1] = temp_averageSalaries;

                        string temp_employees = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = temp_employees;
                    }
                }
            }
        }

    }
}
