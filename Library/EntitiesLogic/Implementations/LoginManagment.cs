using LibraryEntities.Models;
using LibraryDb;
namespace EntitiesLogic
{
    public class LoginManagment : IDisposable, ILogin
    {
        private LibraryContext Context;
        private UserRepository userRepository;
        public LoginManagment( LibraryContext context)
        {
            Context = context;
        }
        public string UserLogin(string username, string password)
        {
            try
            {
                var userQuery = Context.Users.Where(u => u.UsersUserName == username).SingleOrDefault();
                if (userQuery != null)
                {
                    if (userQuery.UsersPassword == password)
                    {
                        return "";
                    }
                }
                return "Invalid, Username or Password";
            }
            catch 
            {
                return "Invalid, Username or Password";
            }
        }
        public User GetUser(string username)
        {
            try
            {
                User user = new User();
                user = Context.Users.Where(u => u.UsersUserName == username).SingleOrDefault();
                return user;
            }
            catch
            {
                return null;
            }
        }
        public void Dispose()
        {
            try
            {

                Context.Dispose();
            }
            catch
            {
                return;
            }
        }
    }
}

