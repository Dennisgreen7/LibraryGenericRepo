using System.Linq.Expressions;
using LibraryEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb
{
    public class BookRepository : GenericRepository<Book>, IDisposable, IBookRepository
    {
        public LibraryContext Context { get { return _context as LibraryContext; } }
        public BookRepository(DbContext context) : base(context)
        {
        }

        public List<Book> ClientFilterBook(int selectedFilter, string value)
        {
            try
            {
                List<Book> books = null;
                switch (selectedFilter)
                {
                    case 0:
                        books = Find(b => b.BookName == value);
                        break;
                    case 1:
                        books = GetAll().Where(b => b.AuthorName == value).ToList<Book>();
                        break;
                    case 2:
                        books = Find(b => b.BookLanguage == value);
                        break;
                    case 3:
                        books = Find(b => b.BookPublishedYear == int.Parse(value));

                        break;
                    case 4:
                        books = Find(b => b.BookNumOfPages == int.Parse(value));
                        break;
                    case 5:
                        books = GetAll().Where(b => b.GenreName == value).ToList<Book>();
                        break;
                }
                return books;
            }
            catch
            {
                return null;
            }
        }

        public void Dispose()
        {
            try
            {
                Context.Dispose();
            }
            catch
            {
                return;
            }
        }

        public List<Book> Filter(int selectedFilter, string value)
        {
            try
            {
                List<Book> books = null;
                switch (selectedFilter)
                {
                    case 0:
                        books = Find(b => b.BookId == int.Parse(value));
                        break;
                    case 1:
                        books = Find(b => b.BookName == value);
                        break;
                    case 2:
                        books = GetAll().Where(b => b.AuthorName == value).ToList<Book>();
                        break;
                    case 3:
                        books = Find(b => b.BookLanguage == value);
                        break;
                    case 4:
                        books = Find(b => b.BookPublishedYear == int.Parse(value));
                        break;
                    case 5:
                        books = Find(b => b.BookNumOfPages == int.Parse(value));
                        break;
                    case 6:
                        books = Find(b => b.BookCopys == int.Parse(value));
                        break;
                    case 7:
                        books = GetAll().Where(b => b.GenreName == value).ToList<Book>();
                        break;
                }
                return books;
            }
            catch
            {
                return null;
            }
        }
        public List<Book> Find(Expression<Func<Book, bool>> predicate)
        {
            try
            {
                return Context.Set<Book>().Where(predicate).ToList<Book>();
            }
            catch
            {
                return null;
            }
        }

        public Borrowing FindBorrow(Expression<Func<Borrowing, bool>> predicate)
        {
            try
            {
                return Context.Set<Borrowing>().Where(predicate).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public List<Borrowing> FindBorrows(Expression<Func<Borrowing, bool>> predicate)
        {
            try
            {
                return Context.Set<Borrowing>().Where(predicate).ToList<Borrowing>();
            }
            catch
            {
                return null;
            }
        }

        public override List<Book> GetAll()
        {
            try
            {
                return Context.Books.Include(b => b.Author).Include(b => b.Genre).ToList<Book>();
            }
            catch
            {
                return null;
            }
        }

        public List<Book> GetBooksCmbDB()
        {
            try
            {
                return Context.Books.Where(b => b.BookCopys > 0).Include(b => b.Author).Include(b => b.Genre).ToList<Book>();
            }
            catch
            {
                return null;
            }
        }
        public bool Remove(int id)
        {
            try
            {
                var openBorrow = FindBorrow(b => b.BorrowingBookId == id && b.BorrowingReturnedDate == null);
                if (openBorrow != null)
                {
                    return false;
                }
                var borrows = FindBorrows(b => b.BorrowingBookId == id);
                Book entity = Context.Books.Find(id);
                if (borrows != null && entity != null)
                {
                    for (int i = 0; i < borrows.Count; i++)
                    {
                        Context.Borrowings.Remove(borrows[i]);
                    }
                    Context.Books.Remove(entity); ;
                    Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void RemoveBorrow(Borrowing entity)
        {
            try
            {
                Context.Borrowings.Remove(entity);
            }
            catch
            {
                return;
            }
        }
    }
}
