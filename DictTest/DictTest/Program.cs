using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictTest
{

    enum Genre
    {
        Drama,
        Tragic,
        Comedy,
        Unknown
    }

    internal class Program
    {

        static public void RemoveBook(Dictionary<Genre, List<string>> allBooks,
                                   string bookName)
        {
            foreach (List<string> books in allBooks.Values)
            {
                for (int index = 0; index < books.Count; ++index)
                {
                    if (books[index] == bookName)
                    {
                        books.RemoveAt(index);
                        --index;
                    }
                }
            }
        }

        static void PrintBooksByGenre(Genre genre, Dictionary<Genre, List<string>> allBooks)
        {
            if (allBooks.ContainsKey(genre))
            {
                List<string> books = allBooks[genre];
                Console.WriteLine(String.Join("\n", books));
            }
            else
            {
                Console.WriteLine("Книг данного жанра мы еще не завезли");
            }
        }

        static private Genre MakeGenreByText(string text)
        {
            if (text == "драма")
            {
                return Genre.Drama;
            }

            if (text == "комедия")
            {
                return Genre.Comedy;
            }

            if (text == "трагедия")
            {
                return Genre.Tragic;
            }

            return Genre.Unknown;
        }


        static void Main(string[] args)
        {

           Dictionary<Genre, List<string>> catalogBooks =
                new Dictionary<Genre, List<string>>();

            /// заполнение книг жанра комедии
            catalogBooks.Add(Genre.Comedy,
                             new List<string>() { "Горе от ума",
                                                  "Вечера на хуторе близ Диканьки",
                                                  "Ревизор",
                                                  "Ум от горя",
                                                  "Ёлки 213"});

            /// заполнение книг жанра трагедии
            catalogBooks.Add(Genre.Tragic,
                 new List<string>() { "Сегодня суббота",
                                      "Трагедия понедельника"});

            catalogBooks.Add(Genre.Drama,
                new List<string>() {"Вечер восресенья",
                                    "Наша Таня громко плачет: уронила в речку мячик.Приквел",
                                    "Наша Таня громко плачет: уронила в речку мячик.Сиквел"});

            Console.Write("Какой жанр литературы Вам интересен? ");
            string text = Console.ReadLine();
            Genre genre = MakeGenreByText(text);

            if (genre == Genre.Unknown)
            {
                Console.WriteLine("Ну и бредик, выбирай между комедией, трагедией и драмой, " +
                                    "если у тебя не хроническое безвкусие");
                return;
            }

            PrintBooksByGenre(genre, catalogBooks);

            Console.Write("Какую книгу хотите удалить?");
            string book = Console.ReadLine();
            RemoveBook(catalogBooks, book);
            Console.WriteLine("Набор книг после удаления");
            PrintBooksByGenre(genre, catalogBooks);

        }
    }
}
