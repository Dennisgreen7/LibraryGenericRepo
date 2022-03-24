using LibraryEntities.Models;
using LibraryDb;
using LibraryValidations;
namespace EntitiesLogic
{
    public class BookManagment : IBookManagment
    {
        private BookRepository BookRepository;
        private Validations Validator = new Validations();

        public BookManagment(LibraryContext Context)
        {
            this.BookRepository = new BookRepository(Context);
        }

        public List<Book> GetAll()
        {
            try
            {
                return BookRepository.GetAll();
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
                return BookRepository.GetBooksCmbDB();
            }
            catch
            {
                return null;
            }
        }
        public string Add(params string[] prop)
        {
            try
            {

                string message = Validator.BookValidation(prop);
                if (message != "")
                {
                    return message;
                }
                Book book = new Book
                {
                    BookName = prop[0],
                    BookLanguage = prop[1],
                    BookNumOfPages = int.Parse(prop[2]),
                    BookCopys = int.Parse(prop[3]),
                    AuthorId = int.Parse(prop[4]),
                    GenreId = int.Parse(prop[5]),
                    BookPublishedYear = int.Parse(prop[6])
                };
                BookRepository.Add(book);
                return ("Book Added");
            }
            catch
            {
                return "Eror";
            }
        }
        public string Update(params string[] prop)
        {
            try
            {
                string message = Validator.BookValidation(prop);
                if (message != "")
                {
                    return message;
                }
                Book book = BookRepository.GetById(int.Parse(prop[7]));
                if (book == null)
                {
                    return "Book doesn't exsit";
                }
                book.BookName = prop[0];
                book.BookLanguage = prop[1];
                book.BookNumOfPages = int.Parse(prop[2]);
                book.BookCopys = int.Parse(prop[3]);
                book.AuthorId = int.Parse(prop[4]);
                book.GenreId = int.Parse(prop[5]);
                book.BookPublishedYear = int.Parse(prop[6]);
                BookRepository.Update(book);
                return ("Book Updated");
            }
            catch
            {
                return "Eror";
            }
        }
        public string Remove(string bookId)
        {
            try
            {
                if (Validator.EmptyFields(bookId))
                {
                    return "Eror, invalid Id";
                }
                else if (!BookRepository.Remove(int.Parse(bookId)))
                {
                    return "this Book have open Borrowings, close them to delete";
                }
                return "Book Deleted";
            }
            catch
            {
                return "Eror";
            }
        }
        public List<Book> Filter(int selectedFilter, string value, string type)
        {
            try
            {
                List<Book> books = null;
                if (type == "admin")
                {
                    books = BookRepository.Filter(selectedFilter, value);
                }
                else
                {
                    books = BookRepository.ClientFilterBook(selectedFilter, value);
                }
                return books;
            }
            catch
            {
                return null;
            }
        }
    }
}
