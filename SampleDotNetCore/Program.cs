namespace SampleDotNetCore
{
    using Microsoft.EntityFrameworkCore;
    using SampleDotNetCore.Data;

    internal class Program
    {
        static void Main(string[] args)
        {
            AddBook();
        }

        public static void AddBook()
        {
            try
            {
                var dbcontext = new Bookcontext();
                var NewBook = new Book();
                NewBook.Title = "Shiva Trilogy : Oath of Vayuputras";
                NewBook.Author = "Amish tripathi";
                NewBook.BookPrice = 10;
                dbcontext.Books.Add(NewBook);
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void GetBooks()
        {
            try
            {
                var dbcontext = new Bookcontext();
                var Books = dbcontext.Books.ToList();
                foreach (var book in Books)
                {
                    Console.WriteLine($"Id : {book.Id}, Title : {book.Title}, Author : {book.Author}, Price : {book.BookPrice}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void UpdateBook()
        {
            try
            {
                var dbcontext = new Bookcontext();
                var book = dbcontext.Books.FirstOrDefault(b => b.Id == 1);
                if (book != null)
                {
                    book.BookPrice = 15;
                    dbcontext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DeleteBook()
        {
            try
            {
                var dbcontext = new Bookcontext();
                var book = dbcontext.Books.FirstOrDefault(b => b.Id == 1);
                if (book != null)
                {
                    dbcontext.Books.Remove(book);
                    dbcontext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

