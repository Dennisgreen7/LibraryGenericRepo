using LibraryEntities.Models;

namespace EntitiesLogic
{
    public interface IBookManagment
    {
        string Add(params string[] prop);
        List<Book> Filter(int selectedFilter, string value, string type);
        List<Book> GetAll();
        List<Book> GetBooksCmbDB();
        string Remove(string bookId);
        string Update(params string[] prop);
    }
}