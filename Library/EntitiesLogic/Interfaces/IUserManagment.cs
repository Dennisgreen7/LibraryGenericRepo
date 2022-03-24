using LibraryEntities.Models;

namespace EntitiesLogic
{
    public interface IUserManagment
    {
        string Add(params string[] prop);
        List<User> Filter(int selectedFilter, string value);
        List<User> GetAll();
        string Remove(string userId);
        string Update(params string[] prop);
    }
}