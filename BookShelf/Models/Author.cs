using System.Collections.Generic;

namespace BookShelf.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PenName { get; set; }
        public string PreferredGenre { get; set; }
        public List<Book> NumberOfBook { get; set; } = new List<Book>();
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public object Title { get; internal set; }
        public object User { get; internal set; }
    }
}
