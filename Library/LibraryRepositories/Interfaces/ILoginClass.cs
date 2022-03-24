using LibraryEntities.Models;

namespace LibraryDb
{
    public interface ILogin
    {
        void Dispose();
        User GetUser(string username);
        string UserLogin(string username, string password);
    }
}