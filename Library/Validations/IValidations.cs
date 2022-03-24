using LibraryEntities.Models;

namespace LibraryValidations
{
    public interface IValidations
    {
        string AuthorFilterValidation(int selectedFilter, string value);
        string AuthorValidation(params string[] prop);
        string BookFilterValidation(int selectedFilter, string value, string type);
        string BookValidation(params string[] prop);
        string BorrowFilterValidation(int selectedFilter, string value, string type);
        string BorrowValidation(params string[] prop);
        string DateValidation(DateTime value);
        bool EmptyFields(params string[] list);
        string GenreFilterValidation(int selectedFilter, string value);
        string GnereValidation(params string[] prop);
        string InputValidation(string inputValue, string pattern, string errMsg);
        bool IsDate(string value);
        string IsraeliIdValidation(string inputvalue);
        string UserFilterValidation(int selectedFilter, string value);
        string UserLenghtVlidation(string value, string check);
        string UserNamesValidation(string value, int id, List<User> list, string check);
        string UserTaken(string value, int id, List<User> list);
        string UserValidation(params string[] prop);
        string YearValidation(string year);
    }
}