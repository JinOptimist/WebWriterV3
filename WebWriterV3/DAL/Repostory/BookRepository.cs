using WebWriterV3.DAL.DbModel;
using WebWriterV3.DAL.IRepository;

namespace WebWriterV3.DAL.Repostory
{
    public class BookRepository : BaseRepository<BookModel>, IBookRepository
    {
        public BookRepository(WebWriterContext db) : base(db) { }
    }
}
