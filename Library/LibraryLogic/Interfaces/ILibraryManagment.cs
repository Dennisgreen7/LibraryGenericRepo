using LibraryEntities.Models;

namespace LibraryLogic
{
    public interface ILibraryManagment
    {
        event InvalidInput InvalidInputEvent;

        bool AddAuthor(params string[] prop);
        bool AddBook(params string[] prop);
        bool AddBorrow(params string[] prop);
        bool AddGenre(params string[] prop);
        bool AddUser(params string[] prop);
        List<Author> AuthorFilter(int selectedFilter, string value);
        List<Book> BookFilter(int selectedFilter, string value);
        List<Borrowing> BorrowFilter(int selectedFilter, string value, string type, User entity = null);
        List<Book> ClientBookFilter(int selectedFilter, string value);
        bool DeleteAuthor(string authorId);
        bool DeleteBook(string bookId);
        bool DeleteBorrow(string borrowId);
        bool DeleteGenre(string genreId);
        bool DeleteUser(string userId);
        List<Genre> GenreFilter(int selectedFilter, string value);
        List<Book> GetBooksCmbDB();
        List<Author> GetDBAuthors();
        List<Book> GetDBBooks();
        List<Borrowing> GetDBBorrowings(User entity = null);
        List<Genre> GetDBGenres();
        List<User> GetDBUsers();
        User GetUserLogin(string uname);
        bool Login(string username, string password);
        bool Registration(params string[] prop);
        bool ReturnBook(string borrowId);
        bool UpdateAuthor(params string[] prop);
        bool UpdateBook(params string[] prop);
        bool UpdateBorrow(DateTime returnDate, string userId, string bookId, string id);
        bool UpdateGenre(params string[] prop);
        bool UpdateUser(params string[] prop);
        List<User> UserFilter(int selectedFilter, string value);
    }
}