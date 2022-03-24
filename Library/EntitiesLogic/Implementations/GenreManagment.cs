using LibraryEntities.Models;
using LibraryDb;
using LibraryValidations;
namespace EntitiesLogic
{
    public class GenreManagment : IGenreManagment
    {
        private GenreRepository GenreRepository;
        private Validations Validator = new Validations();

        public GenreManagment(LibraryContext Context)
        {
            this.GenreRepository = new GenreRepository(Context);
        }
        public List<Genre> GetAll()
        {
            try
            {
                return GenreRepository.GetAll();
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
                string message = Validator.GnereValidation(prop);
                if (message != "")
                {
                    return message;
                }
                Genre genre = new Genre
                {
                    GenreName = prop[0]
                };
                GenreRepository.Add(genre);
                return "Genre Added";
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
                string message = Validator.GnereValidation(prop);
                if (message != "")
                {
                    return message;
                }
                Genre genre = GenreRepository.GetById(int.Parse(prop[1]));
                if (genre == null)
                {
                    return "Genre doesn't exsit";
                }
                genre.GenreName = prop[0];
                GenreRepository.Update(genre);
                return "Genre Updated";
            }
            catch
            {
                return "Eror";
            }
        }
        public string Remove(string genreId)
        {
            try
            {
                if (Validator.EmptyFields(genreId))
                {
                    return "Eror, invalid Id";
                }
                else if (!GenreRepository.Remove(int.Parse(genreId)))
                {
                    return "this Genre has Books with open Borrowings";
                }
                return "Genre Deleted";
            }
            catch
            {
                return "Eror";
            }
        }

        public List<Genre> Filter(int selectedFilter, string value)
        {
            try
            {
                List<Genre> genres = null;
                genres = GenreRepository.Filter(selectedFilter, value);
                return genres;
            }
            catch
            {
                return null;
            }
        }
    }
}
