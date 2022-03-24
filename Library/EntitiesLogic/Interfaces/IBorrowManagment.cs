using LibraryEntities.Models;

namespace EntitiesLogic
{
    public interface IBorrowManagment
    {
        string Add(params string[] prop);
        List<Borrowing> Filter(int selectedFilter, string value, string type, User entity = null);
        List<Borrowing> GetAll(User entity = null);
        List<Borrowing> GetDBClientBorrowings(User obj);
        string Remove(string borrowId);
        string ReturnBook(string borrowId);
        string Update(params string[] prop);
    }
}