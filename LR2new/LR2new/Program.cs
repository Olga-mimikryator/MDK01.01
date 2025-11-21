using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2new
{
    class Program
    {
        
        static void Main()
        {
            //Вариант 10
            //Требуется разработать информационную подсистему учета тестирований учащихся по дисциплинам.
            //Сведения о результатах разнесены по дисциплинам: Математика, Русский язык,
            //Базы данных и т.д.По каждому обучающемуся вносятся данные: название теста и количество
            //набранных баллов(например, Иванов Иван Иванович, тест «Интегралы», дисциплина – «Математика»,
            //баллы – 85). По запросу пользователя – «название дисциплины» -вывести на экран список тестов от
            //наиболее используемых к наименее, а также найдите самого успешного обучающегося. (средний балл
            //которого по всем тестам дисциплины самый высокий). 


            List<TestResult> testResults = InputModule.InputByTestResults();
            //Пробный вывод на консоль
            //foreach(TestResult testResult in testResults)
            //{
            //    Console.WriteLine($"Студент: {testResult.student} | Дисциплина: {testResult.discipline} |" +
            //        $" Тема теста: {testResult.name} | Оценка: {testResult.estimation} баллов\n");
            //}


            Dictionary<string, List<TestResult>> disciplineDict = 
                DataProcessingModul.BuildDisciplineDictionary(testResults);
            UserModul.ShowAvailableDisciplines(disciplineDict);
            UserModul.ProcessUserChoice(disciplineDict);


        }
    }
}
