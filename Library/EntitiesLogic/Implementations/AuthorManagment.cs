using LibraryEntities.Models;
using LibraryDb;
using LibraryValidations;
namespace EntitiesLogic
{
    public class AuthorManagment : IAuthorManagment
    {
         private AuthorRepository AuthorRepository;
        private Validations Validator = new Validations();

        public AuthorManagment(LibraryContext Context)
        {
            this.AuthorRepository = new AuthorRepository(Context);
        }
        public List<Author> GetAll()
        {
            try
            {
                return AuthorRepository.GetAll();
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
                string message = Validator.AuthorValidation(prop);
                if (message != "")
                {
                    return message;
                }
                Author author = new Author
                {
                    AuthorName = prop[0],
                    AuthorCountry = prop[1]
                };
                AuthorRepository.Add(author);
                return "Author Added";
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
                string message = Validator.AuthorValidation(prop);
                if (message != "")
                {
                    return message;
                }
                Author author = AuthorRepository.GetById(int.Parse(prop[2]));
                if (author == null)
                {
                    return "Author doesn't exsit";
                }
                author.AuthorName = prop[0];
                author.AuthorCountry = prop[1];
                AuthorRepository.Update(author);
                return "Author Updated";
            }
            catch
            {
                return "Eror";
            }
        }
        public string Remove(string authorId)
        {
            try
            {
                if (Validator.EmptyFields(authorId))
                {
                    return "Eror, invalid Id";
                }
                else if (!AuthorRepository.Remove(int.Parse(authorId)))
                {
                    return "this Author have Books with open Borrowings, please close them";
                }
                return "Author Deleted";
            }
            catch
            {
                return "Eror";
            }
        }

        public List<Author> Filter(int selectedFilter, string value)
        {
            try
            {
                List<Author> authors = null;
                authors = AuthorRepository.Filter(selectedFilter, value);
                return authors;
            }
            catch
            {
                return null;
            }
        }
    }
}
