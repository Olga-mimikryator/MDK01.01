using System;
using System.Collections.Generic;
using StudentTestingSystem;

namespace LR2new
{
    internal class UserModul
    {
        public static void ShowAvailableDisciplines(Dictionary<string, List<TestResult>> disciplineDictionary)
        {
            Console.WriteLine("Доступные дисциплины:");
            int number = 1;
            foreach (string discipline in disciplineDictionary.Keys)
            {
                Console.WriteLine(number + ". " + discipline);
                number++;
            }
        }

        public static void ProcessUserChoice(Dictionary<string, List<TestResult>> disciplineDictionary)
        {
            Console.Write("\nВведите номер дисциплины: ");
            string input = Console.ReadLine();

            if (IsValidNumber(input))
            {
                int choice = Convert.ToInt32(input);
                int disciplineCount = GetDisciplineCount(disciplineDictionary);

                if (choice >= 1 && choice <= disciplineCount)
                {
                    string selectedDiscipline = GetDisciplineByNumber(disciplineDictionary, choice);
                    ShowDisciplineStatistics(selectedDiscipline, disciplineDictionary);
                }
                else
                {
                    Console.WriteLine("Ошибка: нет дисциплины с таким номером!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите число!");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        private static bool IsValidNumber(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            foreach (char c in input)
            {
                if (c < '0' || c > '9') return false;
            }
            return true;
        }

        private static int GetDisciplineCount(Dictionary<string, List<TestResult>> disciplineDictionary)
        {
            int count = 0;
            foreach (string discipline in disciplineDictionary.Keys)
            {
                count++;
            }
            return count;
        }

        private static string GetDisciplineByNumber(Dictionary<string, List<TestResult>> disciplineDictionary, int number)
        {
            int current = 1;
            foreach (string discipline in disciplineDictionary.Keys)
            {
                if (current == number) return discipline;
                current++;
            }
            return "";
        }

        private static void ShowDisciplineStatistics(string discipline, Dictionary<string, List<TestResult>> disciplineDictionary)
        {
            if (disciplineDictionary.ContainsKey(discipline))
            {
                List<TestResult> disciplineResults = disciplineDictionary[discipline];

                //список тестов от наиболее используемых к наименее используемым
                Console.WriteLine("\nТесты:");
                Dictionary<string, int> testUsage = StatisticsCalculator.GetTestUsageStatistics(disciplineResults);
                StatisticsCalculator.SortTestsByPopularity(testUsage);

                //поиск самого успешного студента
                Console.WriteLine("\nСамый успешный студент:");
                StatisticsCalculator.FindBestStudent(disciplineResults);
            }
            else
            {
                Console.WriteLine("Дисциплина не найдена!");
            }
        }
    }
}
