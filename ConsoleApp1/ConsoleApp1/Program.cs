using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            void SayHelloRu()
            {
                Console.WriteLine("Вечер в хату");
            }
            void SayHelloEn()
            {
                Console.WriteLine("Часик в радость, чифирок в сладость");
            }
            void SayHelloFr()
            {
                Console.WriteLine("сосо");
            }


            string language = "en";

            switch (language)
            {
                case "en":
                    SayHelloEn();
                    break;
                case "ru":
                    SayHelloRu();
                    break;
                case "fr":
                    SayHelloFr();
                    break;

            }



        }
    }
}
