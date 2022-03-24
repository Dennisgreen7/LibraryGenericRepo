using System.Linq.Expressions;
using LibraryEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb
{
    public class GenreRepository : GenericRepository<Genre>, IDisposable, IGenreRepository
    {
        public LibraryContext Context { get { return _context as LibraryContext; } }
        public GenreRepository(DbContext context) : base(context)
        {
        }
        public List<Genre> Filter(int selectedFilter, string value)
        {
            try
            {
                List<Genre> genres = null;
                switch (selectedFilter)
                {
                    case 0:
                        genres = Find(g => g.GenreId == int.Parse(value));
                        break;
                    case 1:
                        genres = Find(g => g.GenreName == value);
                        break;
                }
                return genres;
            }
            catch
            {
                return null;
            }
        }
        public List<Book> FindBooks(Expression<Func<Book, bool>> predicate)
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
        public bool Remove(int id)
        {
            try
            {
                var books = FindBooks(b => b.GenreId == id).ToList<Book>();
                List<Borrowing> borrows = null;
                Borrowing openBorrow;
                for (int i = 0; i < books.Count; i++)
                {
                    openBorrow = FindBorrow(b => b.BorrowingBookId == books[i].BookId && b.BorrowingReturnedDate == null);
                    if (openBorrow != null)
                    {
                        return false;
                    }
                    borrows = FindBorrows(b => b.BorrowingBookId == books[i].BookId);
                    if (borrows != null)
                    {
                        for (int j = 0; j < borrows.Count; j++)
                        {
                            RemoveBorrow(borrows[j]);
                        }
                    }
                }
                Genre entity = Context.Genres.Find(id);
                if (books != null && entity != null)
                {
                    for (int i = 0; i < books.Count; i++)
                    {
                        RemoveBook(books[i]);
                    }
                    Context.Genres.Remove(entity);
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
        public void RemoveBook(Book entity)
        {
            try
            {
                Context.Books.Remove(entity);
            }
            catch
            {
                return;
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
    }
}
