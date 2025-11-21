using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2new
{
    internal class DataProcessingModul
    {
        static public Dictionary<string, List<TestResult>> BuildDisciplineDictionary 
                                                            (List<TestResult> allResults)
        {
            Dictionary<string, List<TestResult>> disciplineDict = 
                                new Dictionary<string, List<TestResult>>();

            //проход по всему списку результатов тестов
            //и распределение по дисциплинам
            foreach (TestResult result in allResults)
            {
                string discipline = result.discipline;

                //если дисциплины еще нет в словаре,
                //создается новый список для новой дисциплины
                if (!disciplineDict.ContainsKey(discipline))
                {
                    disciplineDict[discipline] = new List<TestResult>();
                }

                //добавление результата в список соответствующей дисциплины в словаре
                disciplineDict[discipline].Add(result);
            }

            return disciplineDict;
        }
    }
}
