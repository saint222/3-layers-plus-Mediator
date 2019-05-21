using System.Net.NetworkInformation;

namespace BookShop.Logic.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }
    }
}