using System;
using System.Collections.Generic;
using BookShop.Data.Models;

namespace BookShop.Data
{
    public static class BookStorage
    {
        private static List<BookDb> _storage = new List<BookDb>()
                                               {
                                                   new BookDb()
                                                   {
                                                       Id = 1,
                                                       Created = DateTime.Now,
                                                       Price = 123,
                                                       Title = "Book 1",
                                                       CreatedBy = 1
                                                   },                                                   new BookDb()
                                                   {
                                                       Id = 2,
                                                       Created = DateTime.Now,
                                                       Price = 222,
                                                       Title = "Book 2",
                                                       CreatedBy = 1
                                                   },                                                   new BookDb()
                                                   {
                                                       Id = 3,
                                                       Created = DateTime.Now,
                                                       Price = 333,
                                                       Title = "Book 3",
                                                       CreatedBy = 1
                                                   },
                                               };

        public static List<BookDb> Books => _storage;
    }
}