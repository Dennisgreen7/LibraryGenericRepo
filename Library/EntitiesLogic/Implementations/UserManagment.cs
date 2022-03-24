using LibraryEntities.Models;
using LibraryValidations;
using LibraryDb;
namespace EntitiesLogic
{
    public class UserManagment : IUserManagment
    {
        private UserRepository UserRepository;
        private Validations Validator = new Validations();

        public UserManagment(LibraryContext Context)
        {
            this.UserRepository = new UserRepository(Context);
        }
        public List<User> GetAll()
        {
            try
            {
                return UserRepository.GetAll();
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
                string message = Validator.UserValidation(prop);
                if (message != "Please fill in all fields")
                {
                    message += Validator.UserNamesValidation(prop[2], 0, GetAll(), "uname");
                }
                if (message != "")
                {
                    return message;
                }

                User user = new User
                {
                    UsersFirstName = prop[0],
                    UsersLastName = prop[1],
                    UsersUserName = prop[2],
                    UsersPassword = prop[3],
                    UsersEmail = prop[4],
                    UsersPhone = prop[5],
                    UserTzId = prop[6],
                    UsersAddress = prop[7],
                    UsersRole = prop[8],
                };
                UserRepository.Add(user);
                return ("User Added");
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
                string message = Validator.UserValidation(prop);
                if (message != "Please fill in all fields")
                {
                    message += Validator.UserNamesValidation(prop[2], int.Parse(prop[9]), GetAll(), "uname");
                }
                if (message != "")
                {
                    return message;
                }
                User user = UserRepository.GetById(int.Parse(prop[9]));
                if (user == null)
                {
                    return "User doesn't exsit";
                }
                user.UsersFirstName = prop[0];
                user.UsersLastName = prop[1];
                user.UsersUserName = prop[2];
                user.UsersPassword = prop[3];
                user.UsersEmail = prop[4];
                user.UsersPhone = prop[5];
                user.UserTzId = prop[6];
                user.UsersAddress = prop[7];
                user.UsersRole = prop[8];
                UserRepository.Update(user);
                return ("User Updated");
            }
            catch
            {
                return "Eror";
            }
        }
        public string Remove(string userId)
        {
            try
            {
                if (Validator.EmptyFields(userId))
                {
                    return "Eror, invalid Id";
                }
                else if (!UserRepository.Remove(int.Parse(userId)))
                {
                    return "this User has open Borrowings";
                }
                return "User Deleted";
            }
            catch
            {
                return "Eror";
            }
        }
        public List<User> Filter(int selectedFilter, string value)
        {
            try
            {

                List<User> users = null;
                users = UserRepository.Filter(selectedFilter, value);
                return users;
            }
            catch
            {
                return null;
            }
        }
    }
}
