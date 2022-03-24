using LibraryEntities.Models;

namespace EntitiesLogic
{
    public interface IGenreManagment
    {
        string Add(params string[] prop);
        List<Genre> Filter(int selectedFilter, string value);
        List<Genre> GetAll();
        string Remove(string genreId);
        string Update(params string[] prop);
    }
}