using System;

namespace BookShop.Data.Models
{
    public class BookDb
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public DateTime Created { get; set; }

        public int CreatedBy { get; set; }
    }
}