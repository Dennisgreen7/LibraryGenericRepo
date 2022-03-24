using System.Linq.Expressions;
using LibraryEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDb
{
    public class UserRepository : GenericRepository<User>, IDisposable, IUserRepository
    {
        public LibraryContext Context { get { return _context as LibraryContext; } }
        public UserRepository(DbContext context) : base(context)
        {
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

        public List<User> Filter(int selectedFilter, string value)
        {
            try
            {
                List<User> users = null;
                switch (selectedFilter)
                {
                    case 0:
                        users = Find(u => u.UsersId == int.Parse(value));
                        break;
                    case 1:
                        users = Find(u => u.UsersFirstName == value);
                        break;
                    case 2:
                        users = Find(u => u.UsersLastName == value);
                        break;
                    case 3:
                        users = Find(u => u.UsersUserName == value);
                        break;
                    case 4:
                        users = Find(u => u.UsersRole == value);
                        break;
                    case 5:
                        users = Find(u => u.UserTzId == value);
                        break;
                }
                return users;
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
        public bool Remove(int id)
        {
            try
            {
                var openBorrowing = FindBorrow(b => b.BorrowingUserId == id && b.BorrowingReturnedDate == null);
                if (openBorrowing != null)
                {
                    return false;
                }
                var borrows = FindBorrows(b => b.BorrowingUserId == id);
                User entity = Context.Users.Find(id);
                if (borrows != null && entity != null)
                {
                    for (int i = 0; i < borrows.Count; i++)
                    {
                        Context.Borrowings.Remove(borrows[i]);
                    }
                    Context.Users.Remove(entity);
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
