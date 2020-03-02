using System.Collections.Generic;

namespace Library.Domain
{
    public class Series : Entity
    {
        public string Name { get; set; }

        public int AmountOfBooks { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
