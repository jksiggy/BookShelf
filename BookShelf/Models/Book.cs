using System;

namespace BookShelf.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
      
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }



    }
}
