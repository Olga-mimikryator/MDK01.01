using System;
using System.Collections.Generic;
using LR2new;

namespace StudentTestingSystem
{
    public static class StatisticsCalculator
    {
        //получение статистики использования тестов
        public static Dictionary<string, int> GetTestUsageStatistics(List<TestResult> disciplineResults)
        {
            Dictionary<string, int> testUsage = new Dictionary<string, int>();

            foreach (TestResult result in disciplineResults)
            {
                if (testUsage.ContainsKey(result.name))
                {
                    testUsage[result.name]++;
                }
                else
                {
                    testUsage[result.name] = 1;
                }
            }

            return testUsage;
        }

        //поиск лучшего студента
        public static void FindBestStudent(List<TestResult> disciplineResults)
        {
            Dictionary<string, int> studentTotalScores = new Dictionary<string, int>();
            Dictionary<string, int> studentTestCounts = new Dictionary<string, int>();

            foreach (TestResult result in disciplineResults)
            {
                if (studentTotalScores.ContainsKey(result.student))
                {
                    studentTotalScores[result.student] += result.estimation;
                    studentTestCounts[result.student]++;
                }
                else
                {
                    studentTotalScores[result.student] = result.estimation;
                    studentTestCounts[result.student] = 1;
                }
            }

            string bestStudent = "";
            double bestAverage = 0;
            int bestTestCount = 0;

            foreach (string student in studentTotalScores.Keys)
            {
                double average = (double)studentTotalScores[student] / studentTestCounts[student];
                if (bestStudent == "" || average > bestAverage)
                {
                    bestStudent = student;
                    bestAverage = average;
                    bestTestCount = studentTestCounts[student];
                }
            }

            if (bestStudent != "")
            {
                Console.WriteLine("  " + bestStudent);
                Console.WriteLine("  Средний балл: " + bestAverage.ToString("0.00"));
                Console.WriteLine("  Количество тестов: " + bestTestCount);
            }
        }

        //сортировка тестов по популярности
        public static void SortTestsByPopularity(Dictionary<string, int> testUsage)
        {
            List<string> testNames = new List<string>();
            List<int> testCounts = new List<int>();

            foreach (var pair in testUsage)
            {
                testNames.Add(pair.Key);
                testCounts.Add(pair.Value);
            }

            for (int i = 0; i < testCounts.Count - 1; i++)
            {
                for (int j = i + 1; j < testCounts.Count; j++)
                {
                    if (testCounts[i] < testCounts[j] ||
                       (testCounts[i] == testCounts[j] && string.Compare(testNames[i], testNames[j]) > 0))
                    {
                        int tempCount = testCounts[i];
                        testCounts[i] = testCounts[j];
                        testCounts[j] = tempCount;

                        string tempName = testNames[i];
                        testNames[i] = testNames[j];
                        testNames[j] = tempName;
                    }
                }
            }

            //вывод отсортированных тестов
            for (int i = 0; i < testNames.Count; i++)
            {
                Console.WriteLine("  " + testNames[i] + " - использован " + testCounts[i] + " раза");
            }
        }
    }
}
