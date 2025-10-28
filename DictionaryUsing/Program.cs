 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryUsing
{
    class Program
    {

        static void printUserWordsType(Dictionary<string, List<string>> Words)
        {
            Console.Write("Введите интересующий вас тип слов" +
                              "(существительные, глаголы, местоимения): ");
            string userText = Console.ReadLine();

            foreach (string types in Words.Keys)
            {
                string type = types.ToLower();
                if (userText.ToLower() == type)
                {
                    int userTypeWordsTypeCount = Words[types].Count;
                    Console.WriteLine($"В словаре {userTypeWordsTypeCount} слова вашего типа");
                }
                else Console.WriteLine("Нет такого типа");
                return;
            }
        }

        static void Main()
        {
            Dictionary<string, List<string>> Words =
                new Dictionary<string, List<string>>();

            string nouns = "Существительные";
            string verbs = "Глаголы";
            string pronouns = "Местоимения";
            Words.Add(nouns, new List<string>()
                                    {"Картошка", "Бульдозер", "Картина"});

            Words.Add(verbs, new List<string>()
                                    {"Копать", "Ездить", "Смотреть" });

            Words.Add(pronouns, new List<string>()
                                    {"Я", "Мы", "Они" });

            Console.WriteLine("Ключи словаря: ");
            Console.WriteLine(String.Join(", ", Words.Keys));

            List<string> NOUNS = Words[nouns];
            Console.WriteLine("Существительные в словаре: ");
            Console.WriteLine(String.Join(", ", NOUNS));

            printUserWordsType(Words);
            
        }
    }
}
