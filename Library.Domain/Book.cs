using System;

namespace Library.Domain
{
    public class Book : Entity
    {
        public string ISBN { get; set; }

        public string Title { get; set; }

        public Language Language { get; set; }

        public string LanguageId { get; set; }

        public Author Author { get; set; }

        public string AuthorId { get; set; }

        public Series Series { get; set; }

        public string SeriesId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int PageCount { get; set; }

        public Genre Genre { get; set; }

        public string GenreId { get; set; }

        public bool Loaned { get; set; } = false;

        public double Price { get; set; }

        public bool EBook { get; set; }

        public bool Fiction { get; set; }

        public Size Size { get; set; }
    }
}
