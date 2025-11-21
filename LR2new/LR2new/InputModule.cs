using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2new
{
    class InputModule
    {
        static public List<TestResult> InputByTestResults()
        {
            
            List<TestResult> testResults = new List<TestResult>();

            ///математика
            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Математика",
                name = "Понятия о числе",
                estimation = 91
            });

            testResults.Add(new TestResult
            {
                student = "Бродилкина Анастасия Геннадьевна",
                discipline = "Математика",
                name = "Понятия о числе",
                estimation = 79
            });

            testResults.Add(new TestResult
            {
                student = "Нетехнарьевич Сергей Сергеевич",
                discipline = "Математика",
                name = "Корни, степени и логарифмы",
                estimation = 67
            });

            testResults.Add(new TestResult
            {
                student = "Бродилкина Анастасия Геннадьевна",
                discipline = "Математика",
                name = "Корни, степени и логарифмы",
                estimation = 56
            });

            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Математика",
                name = "Корни, степени и логарифмы",
                estimation = 95
            });

            testResults.Add(new TestResult
            {
                student = "Кудаделкин Антон Павлович",
                discipline = "Математика",
                name = "Корни, степени и логарифмы",
                estimation = 40
            });

            testResults.Add(new TestResult
            {
                student = "Нетехнарьевич Сергей Сергеевич",
                discipline = "Математика",
                name = "Основы тригонометрии",
                estimation = 70
            });

            testResults.Add(new TestResult
            {
                student = "Бродилкина Анастасия Геннадьевна",
                discipline = "Математика",
                name = "Основы тригонометрии",
                estimation = 68
            });

            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Математика",
                name = "Основы тригонометрии",
                estimation = 99
            });

            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Математика",
                name = "Координаты и векторы",
                estimation = 91
            });

            ///русский язык
            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Русский язык",
                name = "Фонетика",
                estimation = 89
            });

            testResults.Add(new TestResult
            {
                student = "Нетехнарьевич Сергей Сергеевич",
                discipline = "Русский язык",
                name = "Фонетика",
                estimation = 96
            });

            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Русский язык",
                name = "Язык и речь",
                estimation = 92
            });

            testResults.Add(new TestResult
            {
                student = "Бродилкина Анастасия Геннадьевна",
                discipline = "Русский язык",
                name = "Язык и речь",
                estimation = 83
            });

            testResults.Add(new TestResult
            {
                student = "Нетехнарьевич Сергей Сергеевич",
                discipline = "Русский язык",
                name = "Язык и речь",
                estimation = 94
            });

            testResults.Add(new TestResult
            {
                student = "Кудаделкин Антон Павлович",
                discipline = "Русский язык",
                name = "Язык и речь",
                estimation = 34
            });

            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Русский язык",
                name = "Культура устной и публичной речи",
                estimation = 82
            });

            testResults.Add(new TestResult
            {
                student = "Нетехнарьевич Сергей Сергеевич",
                discipline = "Русский язык",
                name = "Культура устной и публичной речи",
                estimation = 99
            });

            testResults.Add(new TestResult
            {
                student = "Бродилкина Анастасия Геннадьевна",
                discipline = "Русский язык",
                name = "Культура устной и публичной речи",
                estimation = 67
            });

            ///Базы данных
            testResults.Add(new TestResult
            {
                student = "Нетехнарьевич Сергей Сергеевич",
                discipline = "Базы данных",
                name = "Основы баз данных",
                estimation = 78
            });

            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Базы данных",
                name = "Основы баз данных",
                estimation = 95
            });

            testResults.Add(new TestResult
            {
                student = "Бродилкина Анастасия Геннадьевна",
                discipline = "Базы данных",
                name = "Основы баз данных",
                estimation = 66
            });

            testResults.Add(new TestResult
            {
                student = "Кудаделкин Антон Павлович",
                discipline = "Базы данных",
                name = "Основы баз данных",
                estimation = 30
            });

            testResults.Add(new TestResult
            {
                student = "Нетехнарьевич Сергей Сергеевич",
                discipline = "Базы данных",
                name = "Сущности и атрибуты",
                estimation = 77
            });

            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Базы данных",
                name = "Сущности и атрибуты",
                estimation = 85
            });

            ///программирование
            testResults.Add(new TestResult
            {
                student = "Нетехнарьевич Сергей Сергеевич",
                discipline = "Программирование",
                name = "Переменные",
                estimation = 88
            });

            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Программирование",
                name = "Переменные",
                estimation = 98
            });

            testResults.Add(new TestResult
            {
                student = "Бродилкина Анастасия Геннадьевна",
                discipline = "Программирование",
                name = "Переменные",
                estimation = 78
            });

            testResults.Add(new TestResult
            {
                student = "Нетехнарьевич Сергей Сергеевич",
                discipline = "Программирование",
                name = "Ввод и вывод данных",
                estimation = 87
            });

            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Программирование",
                name = "Ввод и вывод данных",
                estimation = 100
            });

            testResults.Add(new TestResult
            {
                student = "Бродилкина Анастасия Геннадьевна",
                discipline = "Программирование",
                name = "Ввод и вывод данных",
                estimation = 56
            });

            testResults.Add(new TestResult
            {
                student = "Нетехнарьевич Сергей Сергеевич",
                discipline = "Программирование",
                name = "Массивы",
                estimation = 0
            });

            testResults.Add(new TestResult
            {
                student = "Самосудова Екатерина Валерьевна",
                discipline = "Программирование",
                name = "Массивы",
                estimation = 0
            });

            return testResults;
        }

    }
}
