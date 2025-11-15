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
            Random random = new Random();
            
            TestResult test1 = new TestResult() 
            {
                student = "Букин И.И.",
                discipline = "Математика", 
                name = "Интегралы",
                estimation = random.Next(0, 6)
            };
            testResults.Add(test1);

            TestResult test2 = new TestResult()
            {
                student = "Калашников В.В.",
                discipline = "Математика",
                name = "Интегралы",
                estimation = random.Next(0, 6)
            };
            testResults.Add(test2);

            TestResult test3 = new TestResult()
            {
                student = "Медведев К.М.",
                discipline = "Русский язык",
                name = "Синонимы и антонимы",
                estimation = random.Next(0, 6)
            };
            testResults.Add(test3);

            TestResult test4 = new TestResult()
            {
                student = "",
                discipline = "Математика",
                name = "Интегралы",
                estimation = random.Next(0, 6)
            };
            testResults.Add(test4);


            return testResults;
        }
    }
}
