using LibraryEntities.Models;

namespace EntitiesLogic
{
    public interface IAuthorManagment
    {
        string Add(params string[] prop);
        List<Author> Filter(int selectedFilter, string value);
        List<Author> GetAll();
        string Remove(string authorId);
        string Update(params string[] prop);
    }
}