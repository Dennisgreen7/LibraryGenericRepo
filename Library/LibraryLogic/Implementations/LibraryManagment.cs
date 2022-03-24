using LibraryEntities.Models;
using LibraryValidations;
using EntitiesLogic;
namespace LibraryLogic
{
    public class LibraryManagment : ILibraryManagment
    {
        private static LibraryManagment Instance;
        private static readonly object Key = new object();
        private Validations Validator = new Validations();
        private LoginManagment LoginManagment;
        private BookManagment BookManagment;
        private GenreManagment GenreManagment;
        private AuthorManagment AuthorManagment;
        private BorrowManagment BorrowManagment;
        private UserManagment UserManagment;
        public event InvalidInput InvalidInputEvent;
        // Singelton Desgin Pattern
        private LibraryManagment()
        {
            LibraryContext Context = new LibraryContext();
            this.LoginManagment = new LoginManagment(Context);
            this.BookManagment = new BookManagment(Context);
            this.GenreManagment = new GenreManagment(Context);
            this.AuthorManagment = new AuthorManagment(Context);
            this.BorrowManagment = new BorrowManagment(Context);
            this.UserManagment = new UserManagment(Context);
        }
        public static LibraryManagment GetInstance()
        {
            try
            {
                if (Instance == null)
                {
                    lock (Key)
                    {
                        if (Instance == null)
                        {
                            Instance = new LibraryManagment();
                        }
                    }
                }
                return Instance;
            }
            catch
            {
                return null;
            }
        }
        protected void OnInvalidInputEvent(string errmsg)
        {
            try
            {
                if (InvalidInputEvent != null)
                {
                    InvalidInputEvent(errmsg);
                }
            }
            catch
            {
                return;
            }
        }
        //Get Database Funcs
        public List<Book> GetDBBooks()
        {
            try
            {
                return BookManagment.GetAll();
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
                return BookManagment.GetBooksCmbDB();
            }
            catch
            {
                return null;
            }
        }
        public List<User> GetDBUsers()
        {
            try
            {
                return UserManagment.GetAll();
            }
            catch
            {
                return null;
            }
        }
        public List<Author> GetDBAuthors()
        {
            try
            {
                return AuthorManagment.GetAll();
            }
            catch
            {
                return null;
            }
        }
        public List<Genre> GetDBGenres()
        {
            try
            {
                return GenreManagment.GetAll();
            }
            catch
            {
                return null;
            }
        }
        public List<Borrowing> GetDBBorrowings(User entity = null)
        {
            try
            {
                return BorrowManagment.GetAll(entity);
            }
            catch
            {
                return null;
            }
        }

        // Add Funcs
        public bool AddBook(params string[] prop)
        {
            try
            {
                string message = BookManagment.Add(prop);
                if (message != "Book Added")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddUser(params string[] prop)
        {
            try
            {
                string message = UserManagment.Add(prop);
                if (message != "User Added")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddAuthor(params string[] prop)
        {
            try
            {
                string message = AuthorManagment.Add(prop);
                if (message != "Author Added")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddGenre(params string[] prop)
        {
            try
            {
                string message = GenreManagment.Add(prop);
                if (message != "Genre Added")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddBorrow(params string[] prop)
        {
            try
            {
                string message = BorrowManagment.Add(prop);
                if (message != "Borrow Added")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Update Funcs
        public bool UpdateBook(params string[] prop)
        {
            try
            {
                string message = BookManagment.Update(prop);
                if (message != "Book Updated")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateUser(params string[] prop)
        {
            try
            {
                string message = UserManagment.Update(prop);
                if (message != "User Updated")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateAuthor(params string[] prop)
        {
            try
            {
                string message = AuthorManagment.Update(prop);
                if (message != "Author Updated")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateGenre(params string[] prop)
        {
            try
            {
                string message = GenreManagment.Update(prop);
                if (message != "Genre Updated")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateBorrow(DateTime returnDate, string userId, string bookId, string id)
        {
            try
            {
                string message = BorrowManagment.Update(returnDate.ToString(), userId, bookId, id);
                if (message != "Borrow Updated")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Delete Funcs
        public bool DeleteBook(string bookId)
        {
            try
            {
                string message = BookManagment.Remove(bookId);
                if (message != "Book Deleted")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteUser(string userId)
        {
            try
            {
                string message = UserManagment.Remove(userId);
                if (message != "User Deleted")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteAuthor(string authorId)
        {
            try
            {
                string message = AuthorManagment.Remove(authorId);
                if (message != "Author Deleted")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteGenre(string genreId)
        {
            try
            {
                string message = GenreManagment.Remove(genreId);
                if (message != "Genre Deleted")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteBorrow(string borrowId)
        {
            try
            {
                string message = BorrowManagment.Remove(borrowId);
                if (message != "Borrow Deleted")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ReturnBook(string borrowId)
        {
            try
            {
                string message = BorrowManagment.ReturnBook(borrowId);
                if (message != "Book Returned")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Filters
        public List<Author> AuthorFilter(int selectedFilter, string value)
        {
            try
            {
                List<Author> authors = null;
                string message = "";
                message = Validator.AuthorFilterValidation(selectedFilter, value);
                if (message != "")
                {
                    OnInvalidInputEvent(message);
                    return null;
                }
                authors = AuthorManagment.Filter(selectedFilter, value);

                if (authors.Count == 0)
                {
                    authors = null;
                    OnInvalidInputEvent("There are no author/s with such info");
                }
                return authors;
            }
            catch
            {
                return null;
            }
        }

        public List<Genre> GenreFilter(int selectedFilter, string value)
        {
            try
            {
                List<Genre> genres = null;
                string message = "";
                message = Validator.GenreFilterValidation(selectedFilter, value);
                if (message != "")
                {
                    OnInvalidInputEvent(message);
                    return null;
                }
                genres = GenreManagment.Filter(selectedFilter, value);

                if (genres.Count == 0)
                {
                    genres = null;
                    OnInvalidInputEvent("There are no genre/s with such info");
                }
                return genres;
            }
            catch
            {
                return null;
            }
        }

        public List<Book> BookFilter(int selectedFilter, string value)
        {
            try
            {
                List<Book> books = null;
                string message = "";
                message = Validator.BookFilterValidation(selectedFilter, value, "admin");
                if (message != "")
                {
                    OnInvalidInputEvent(message);
                    return null;
                }
                books = BookManagment.Filter(selectedFilter, value, "admin");

                if (books.Count == 0)
                {
                    books = null;
                    OnInvalidInputEvent("There are no book/s with such info");
                }
                return books;
            }
            catch
            {
                return null;
            }
        }
        public List<Book> ClientBookFilter(int selectedFilter, string value)
        {
            try
            {
                List<Book> books = null;
                string message = "";
                message = Validator.BookFilterValidation(selectedFilter, value, "client");
                if (message != "")
                {
                    OnInvalidInputEvent(message);
                    return null;
                }
                books = BookManagment.Filter(selectedFilter, value, "client");
                if (books.Count == 0)
                {
                    books = null;
                    OnInvalidInputEvent("There are no book/s with such info");
                }
                return books;
            }
            catch
            {
                return null;
            }
        }

        public List<User> UserFilter(int selectedFilter, string value)
        {
            try
            {
                List<User> users = null;
                string message = "";
                message = Validator.UserFilterValidation(selectedFilter, value);
                if (message != "")
                {
                    OnInvalidInputEvent(message);
                    return null;
                }
                users = UserManagment.Filter(selectedFilter, value);

                if (users.Count == 0)
                {
                    users = null;
                    OnInvalidInputEvent("There are no user/s with such info");
                }
                return users;
            }
            catch
            {
                return null;
            }
        }

        public List<Borrowing> BorrowFilter(int selectedFilter, string value, string type, User entity = null)
        {
            try
            {
                List<Borrowing> borrows = null;
                string message = "";
                if (type == "admin")
                {
                    message = Validator.BorrowFilterValidation(selectedFilter, value, "admin");
                }
                else
                {
                    message = Validator.BorrowFilterValidation(selectedFilter, value, "client");
                }
                if (message != "")
                {
                    OnInvalidInputEvent(message);
                    return null;
                }
                if (type == "admin")
                {
                    borrows = BorrowManagment.Filter(selectedFilter, value, "admin");
                }
                else
                {
                    borrows = BorrowManagment.Filter(selectedFilter, value, "client", entity);
                }
                if (borrows.Count == 0)
                {
                    borrows = null;
                    OnInvalidInputEvent("There are no book/s with such info");
                }
                return borrows;
            }
            catch
            {
                return null;
            }
        }

        //Login and Registration
        public User GetUserLogin(string uname)
        {
            try
            {
                return LoginManagment.GetUser(uname);
            }
            catch
            {
                return null;
            }
        }

        public bool Login(string username, string password)
        {
            try
            {
                if (Validator.EmptyFields(username, password))
                {
                    OnInvalidInputEvent("Please fill in all fields");
                    return false;
                }
                else if (LoginManagment.UserLogin(username, password) != "")
                {
                    OnInvalidInputEvent("Invalid, Username or Password");
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Registration(params string[] prop)
        {
            try
            {
                string message = UserManagment.Add(prop);
                if (message != "User Added")
                {
                    OnInvalidInputEvent(message);
                    return false;
                }
                OnInvalidInputEvent("Registration succeeded");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}