﻿using System;
using Logic;

namespace Manual_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            test_storage();
            test_media();
        }

        private static void test_storage() {
            Storage media = new Storage();

            media.storage_add("Item 1");

            Console.WriteLine(media.ToString());
        }

        private static void test_media() {
            Book book = new Book("The Ranger's Apprentice", 200);
            Console.WriteLine(book.Title.ToString());
            book.Title = "The Ranger's Apprentice 2";
            Console.WriteLine(book.Title.ToString());
            Console.WriteLine(book.Pages.ToString());
        }
    }
}
