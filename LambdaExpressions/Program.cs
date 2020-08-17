﻿
using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 6 && b.Price > 4);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}
