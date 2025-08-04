using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Hackathon_Assignment
{
    internal class Library_Author
    {
        static List<string> SortTitles(List<string> books)
        {
            var bookInfo = new List<(string author, string title)>();

            foreach (var entry in books)
            {
                var parts = entry.Split(" by ");
                string title = parts[0].Trim('"');
                string author = parts[1].Split("and")[0];

                bookInfo.Add((author, title));
            }
            return sort(bookInfo);
        }

        private static List<string> sort(List<(string author, string title)> books)
        {
            for (int i = 0; i < books.Count - 1; i++)
            {
                for (int j = 0; j < books.Count - i - 1; j++)
                {
                    bool shouldSwap = false;
                    if (string.Compare(books[j].author, books[j + 1].author) > 0)
                    {
                        shouldSwap = true;
                    }
                    else if (books[j].author == books[j + 1].author &&
                             string.Compare(books[j].title, books[j + 1].title) > 0)
                    {
                        shouldSwap = true;
                    }

                    if (shouldSwap)
                    {
                        var temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }
            List<string> sortedTitles = new List<string>();
            foreach (var book in books)
            {
                sortedTitles.Add(book.title);
            }

            return sortedTitles;
        }

        static List<string> GetBookInputFromUser()
        {
           List<string> inputList = new List<string>();
            Console.WriteLine("Enter book entries in the format: \"Title\" by Author");
            Console.WriteLine("Press Enter to finish.\n");

            while (true)
            {
                Console.Write("Enter book: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                inputList.Add(input);
            }
            return inputList;
        }
        static void Main(string[] args)
        {
            var books = GetBookInputFromUser();
            var result = SortTitles(books);
            foreach (var title in result)
            {
                Console.WriteLine(title);
            }
        }
    }
}
