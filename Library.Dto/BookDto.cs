using System;

namespace Library.Dto
{
    public class BookDto
    {
        public string Id { get; set; }

        public string ISBN { get; set; }

        public string Title { get; set; }

        public string Language { get; set; }

        public string AuthorId { get; set; }

        public string SeriesId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int PageCount { get; set; }

        public string GenreId { get; set; }

        public bool Loaned { get; set; }
    }
}
