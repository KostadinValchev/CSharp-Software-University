﻿using System;

namespace Book_Shop
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(title, author, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(title, author, price);

                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
