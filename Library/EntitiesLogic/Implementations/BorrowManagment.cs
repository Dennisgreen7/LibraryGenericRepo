using LibraryEntities.Models;
using LibraryDb;
using LibraryValidations;
namespace EntitiesLogic
{
    public class BorrowManagment : IBorrowManagment
    {
        private BorrowRepository BorrowRepository;
        private Validations Validator = new Validations();

        public BorrowManagment(LibraryContext Context)
        {
            this.BorrowRepository = new BorrowRepository(Context);
        }
        public List<Borrowing> GetAll(User entity = null)
        {
            try
            {
                if (entity == null)
                {
                    return BorrowRepository.GetAll();
                }
                return BorrowRepository.GetDBClientBorrowings(entity);
            }
            catch
            {
                return null;
            }
        }
        public List<Borrowing> GetDBClientBorrowings(User obj)
        {
            try
            {
                return BorrowRepository.GetDBClientBorrowings(obj);
            }
            catch
            {
                return null;
            };
        }
        public string Add(params string[] prop)
        {
            try
            {
                string message = Validator.BorrowValidation(prop);
                if (message != "")
                {
                    return message;
                }
                Borrowing borrowing = new Borrowing
                {
                    BorrowingDate = DateTime.Now.Date,
                    BorrowingReturnDate = DateTime.Parse(prop[0]),
                    BorrowingUserId = int.Parse(prop[1]),
                    BorrowingBookId = int.Parse(prop[2])
                };
                BorrowRepository.Add(borrowing);
                return "Borrow Added";
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
                string message = Validator.BorrowValidation(prop);
                bool sameBook = false;
                if (message != "")
                {
                    return message;
                }
                Borrowing borrowing = BorrowRepository.GetById(int.Parse(prop[3]));
                if (borrowing == null)
                {
                    return "Borrow doesn't exsit";
                }
                else if (borrowing.BorrowingBookId == int.Parse(prop[2]))
                {
                    sameBook = true;
                }
                BorrowRepository.bookChek(borrowing, sameBook, prop[2]);
                borrowing.BorrowingReturnDate = DateTime.Parse(prop[0]);
                borrowing.BorrowingUserId = int.Parse(prop[1]);
                borrowing.BorrowingBookId = int.Parse(prop[2]);
                BorrowRepository.Update(borrowing);
                return "Borrow Updated";
            }
            catch
            {
                return "Eror";
            }
        }
        public string Remove(string borrowId)
        {
            try
            {
                if (Validator.EmptyFields(borrowId))
                {
                    return "Eror, invalid Id";
                }
                BorrowRepository.Remove(int.Parse(borrowId));
                return "Borrow Deleted";
            }
            catch
            {
                return "Eror";
            }
        }
        public string ReturnBook(string borrowId)
        {
            try
            {
                string message = "";
                if (Validator.EmptyFields(borrowId))
                {
                    message = "Eror, invalid Id";
                }
                else if (!BorrowRepository.ReturnBook(borrowId))
                {
                    message = "Eror, cannot return book that alreeady been returned";
                }
                else
                {
                    message = "Book Returned";

                }
                return message;
            }
            catch
            {
                return "Eror";
            }
        }
        public List<Borrowing> Filter(int selectedFilter, string value, string type, User entity = null)
        {
            try
            {
                List<Borrowing> borrows = null;
                if (type == "admin")
                {
                    borrows = BorrowRepository.Filter(selectedFilter, value);
                }
                else
                {
                    if (entity != null)
                    {
                        borrows = BorrowRepository.ClientFilterBorrow(selectedFilter, value, entity);
                    }
                }
                return borrows;
            }
            catch
            {
                return null;
            }
        }

    }
}
