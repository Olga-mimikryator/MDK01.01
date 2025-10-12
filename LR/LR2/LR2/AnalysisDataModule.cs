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
    }
}
