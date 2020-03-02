using Library.Data;
using Library.Domain;
using Library.Services.Abstractions;

namespace Library.Services
{
    public class SeriesService : BaseService<Series, LibraryContext>, ISeriesService<Series, LibraryContext>
    {
        public SeriesService(LibraryContext context) : base(context) { }
    }
}
