using System.Collections.Generic;

namespace Library.Domain
{
    public class Genre : Entity
    { 
        public string Title { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
