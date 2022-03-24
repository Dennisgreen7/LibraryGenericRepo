using System.Linq.Expressions;
using LibraryEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb
{
    public class BorrowRepository : GenericRepository<Borrowing>, IDisposable, IBorrowRepository
    {
        public LibraryContext Context { get { return _context as LibraryContext; } }
        public BorrowRepository(DbContext context) : base(context)
        {
        }

        public override void Add(Borrowing entity)
        {
            try
            {
                Context.Borrowings.Add(entity);
                var book = FindBook(b => b.BookId == entity.BorrowingBookId);
                if (book != null)
                {
                    book.BookCopys -= 1;
                }
                Save();
            }
            catch
            {
                return;
            }
        }
        public List<Borrowing> ClientFilterBorrow(int selectedFilter, string value, User entity)
        {
            try
            {
                List<Borrowing> borrowings = null;
                switch (selectedFilter)
                {
                    case 0:
                        borrowings = GetDBClientBorrowings(entity).Where(b => b.BookName == value).ToList<Borrowing>();
                        break;
                    case 1:
                        borrowings = GetDBClientBorrowings(entity).Where(b => b.BorrowingReturnedDate == null).ToList<Borrowing>();
                        break;
                    case 2:
                        borrowings = GetDBClientBorrowings(entity).Where(b => b.BorrowingReturnedDate != null).ToList<Borrowing>();
                        break;
                    case 3:
                        borrowings = GetDBClientBorrowings(entity).Where(b => b.BorrowingDate == Convert.ToDateTime(value)).ToList<Borrowing>();
                        break;
                    case 4:
                        borrowings = GetDBClientBorrowings(entity).Where(b => b.BorrowingReturnDate == Convert.ToDateTime(value)).ToList<Borrowing>();
                        break;
                }
                return borrowings;
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

        public List<Borrowing> Filter(int selectedFilter, string value)
        {
            try
            {
                List<Borrowing> borrowings = null;
                switch (selectedFilter)
                {
                    case 0:
                        borrowings = Find(b => b.BorrowingId == int.Parse(value));
                        break;
                    case 1:
                        borrowings = GetAll().Where(b => b.UserName == value).ToList<Borrowing>();
                        break;
                    case 2:
                        borrowings = GetAll().Where(b => b.BookName == value).ToList<Borrowing>();
                        break;
                    case 3:
                        borrowings = Find(b => b.BorrowingReturnedDate == null);
                        break;
                    case 4:
                        borrowings = Find(b => b.BorrowingReturnedDate != null);
                        break;
                    case 5:
                        borrowings = Find(b => b.BorrowingDate == Convert.ToDateTime(value));
                        break;
                    case 6:
                        borrowings = Find(b => b.BorrowingReturnDate == Convert.ToDateTime(value));
                        break;
                }
                return borrowings;
            }
            catch
            {
                return null;
            }
        }
        public Book FindBook(Expression<Func<Book, bool>> predicate)
        {
            try
            {
                return Context.Set<Book>().Where(predicate).SingleOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public List<Borrowing> GetAll()
        {
            try
            {
                return Context.Borrowings.Include(b => b.BorrowingUser).Include(b => b.BorrowingBook).ToList<Borrowing>();
            }
            catch
            {
                return null;
            }
        }
        public List<Borrowing> GetDBClientBorrowings(User entity)
        {
            try
            {
                return Context.Borrowings.Where(b => b.BorrowingUserId == entity.UsersId).Include(b => b.BorrowingUser).Include(b => b.BorrowingBook).ToList<Borrowing>();
            }
            catch
            {
                return null;
            }
        }
        public bool ReturnBook(string id)
        {
            try
            {
                var borrow = GetById(int.Parse(id));
                var book = FindBook(b => b.BookId == borrow.BorrowingBookId);
                if (borrow.BorrowingReturnedDate != null)
                {
                    return false;
                }
                if (borrow != null && book != null)
                {
                    borrow.BorrowingReturnedDate = DateTime.Now.Date;
                    book.BookCopys += 1;
                }
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //  במקרה שישנו את הספר בהשאלה וההשאלה פתוחה צריך להחזיר עותק לספר הישן ולהוריד לספר החדש ליפני עדכון ההשאלה
        public void bookChek(Borrowing entity, bool IsSame, string newBookId)
        {
            try
            {
                if (entity.BorrowingReturnedDate == null && !IsSame)
                {
                    Book Newook = FindBook(b => b.BookId == int.Parse(newBookId));
                    Newook.BookCopys -= 1;
                    Book oldBook = FindBook(b => b.BookId == entity.BorrowingBookId);
                    oldBook.BookCopys += 1;
                }
                Save();
            }
            catch
            {
                return;
            }
        }
    }
}
