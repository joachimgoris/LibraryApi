using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Dto.Book
{
    public class BookCreateDto
    {
        public Guid SeriesId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int PageCount { get; set; }

        public Guid GenreId { get; set; }

        public bool Loaned { get; set; } = false;

        public double Price { get; set; }

        public bool EBook { get; set; }

        public bool Fiction { get; set; }

        public int Size { get; set; }
    }
}