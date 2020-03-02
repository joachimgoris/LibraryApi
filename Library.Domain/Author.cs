using System;
using System.Collections.Generic;

namespace Library.Domain
{
    public class Author : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public ICollection<Book> Books { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime? DeathDate { get; set; }
    }
}
