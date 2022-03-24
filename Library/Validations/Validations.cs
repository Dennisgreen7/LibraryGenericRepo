using System.Text.RegularExpressions;
using LibraryEntities.Models;

namespace LibraryValidations
{
    public class Validations : IValidations
    {
        public string InputValidation(string inputValue, string pattern, string errMsg)
        {
            try
            {
                if (!Regex.Match(inputValue, pattern).Success)
                {
                    return errMsg;
                }
                return "";
            }
            catch 
            {
                return "Eror";
            }
        }
        public bool EmptyFields(params string[] list)
        {
            try
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] == "")
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return true;
            }
        }

        public string IsraeliIdValidation(string inputvalue)
        {
            try
            {
                if (InputValidation(inputvalue, @"^[a-zA-Z]+$", "Tz must be a 9 length digit") == "")
                {
                    return "Tz must be a 9 length digit";
                }
                //TZ length validation 
                else
                {
                    if (inputvalue.Length != 9)
                    {
                        return "Tz must be a 9 length";
                    }

                    //If TZ lenght is 9
                    else
                    {
                        int res = 0;
                        for (int i = 1; i < 8; i += 2)
                        {
                            res += int.Parse(inputvalue[i - 1].ToString()) + ((int.Parse(inputvalue[i].ToString()) * 2) / 10) + ((int.Parse(inputvalue[i].ToString()) * 2) % 10);
                        }

                        if ((res + int.Parse(inputvalue[8].ToString())) % 10 != 0)
                        {
                            return "Eror, Wrong TZ";
                        }
                    }
                }
                return "";
            }
            catch
            {
                return "Eror";
            }
        }

        public string YearValidation(string year)
        {
            try
            {
                var num = 0;
                var isNumeric = int.TryParse(year, out num);

                if (!isNumeric)
                {
                    return "Year should be digit";
                }
                else if (num < 1900 || num > DateTime.Now.Year)
                {
                    return "Eror, Year Range Must Be 1900 - " + DateTime.Now.Year;
                }
                return "";
            }
            catch
            {
                return "Eror";
            }
        }
        public bool IsDate(string value)
        {
            try
            {
                return DateTime.TryParse(value, out _);
            }
            catch
            {
                return false;
            }
        }
        public string DateValidation(DateTime value)
        {
            try
            {
                if (!IsDate(value.ToString()))
                {
                    return "Eror, invalid Return Date";
                }
                return "";
            }
            catch
            {
                return "Eror";
            }
        }
        public string UserTaken(string value, int id, List<User> list)    // id = 0 represent adding or registration operation , id != 0 is updating operation
        {
            try
            {
                User user = list.Where(u => u.UsersUserName == value).FirstOrDefault();
                if (id != 0 && user != null)
                {
                    if (user.UsersId == id)
                    {
                        return "";
                    }
                    return "UserName Taken";
                }
                else if (id == 0 && user != null)
                {
                    return "UserName Taken";
                }
                return "";
            }
            catch
            {
                return "Eror";
            }
        }

        public string UserLenghtVlidation(string value, string check)
        {
            try
            {
                switch (check)
                {
                    case "uname":
                        if (value.Length > 11 || value.Length < 5)
                        {
                            return "Username Length Min 5 and Maximum 11 character";
                        }
                        break;
                    case "fname":
                        if (InputValidation(value, "^[A-Z][a-z]*$", "First Name must have only string with Upper Case first char") != "")
                        {
                            return "First Name must have only string with Upper Case first char";
                        }
                        else if (value.Length > 13)
                        {
                            return "First Name Max Length is 13";
                        }
                        break;
                    case "lname":
                        if (InputValidation(value, "^[A-Z][a-z]*$", "Last Name must have only string with Upper Case first char") != "")
                        {
                            return "Last Name must have only string with Upper Case first char";
                        }

                        else if (value.Length > 13)
                        {
                            return "Last Name Max Length is 13";
                        }
                        break;
                }
                return "";
            }
            catch
            {
                return "Eror";
            }
        }
        public string UserNamesValidation(string value, int id, List<User> list, string check)//check tells the function which property we will check cause each one have diffrent validation
        {
            try
            {
                if (UserLenghtVlidation(value, check) != "")
                {
                    return UserLenghtVlidation(value, check);
                }
                else if (UserTaken(value, id, list) != "")
                {
                    return UserTaken(value, id, list);
                }
                return "";
            }
            catch
            {
                return "Eror";
            }
        }
        public string BookValidation(params string[] prop)
        {
            try
            {
                if (EmptyFields(prop))
                {
                    return "Please fill in all fields";
                }
                string text = "";
                string bookNameValid = InputValidation(prop[0], @"([a-zA-Z0-9\-]+)", "Book Name Must start with Upper Case");
                if (bookNameValid != "")
                    text += bookNameValid + "\n";
                string langaugeValid = InputValidation(prop[1], "^[A-Z][a-zA-Z]*$", "Langauge Must start with Upper Case");
                if (langaugeValid != "")
                    text += langaugeValid + "\n";
                string bookPagesValid = InputValidation(prop[2], "([1-9]+)", "Pages must be above 0");
                if (bookPagesValid != "")
                    text += bookPagesValid + "\n";
                string bookCopysValid = InputValidation(prop[3], "([1-9]+)", "Copys must be above 0");
                if (bookCopysValid != "")
                    text += bookCopysValid + "\n";
                string bookAuthorValid = InputValidation(prop[4], "([1-9]+)", "Select Author");
                if (bookAuthorValid != "")
                    text += bookAuthorValid + "\n";
                string bookGenreValid = InputValidation(prop[5], "([1-9]+)", "Select Genre");
                if (bookGenreValid != "")
                    text += bookGenreValid + "\n";
                string bookYearValid = YearValidation(prop[6]);
                if (bookYearValid != "")
                    text += bookYearValid + "\n";
                return text;
            }
            catch
            {
                return "Eror";
            }
        }
        public string GnereValidation(params string[] prop)
        {
            try
            {
                if (EmptyFields(prop))
                {
                    return "Please fill in all fields";
                }
                string text = "";
                string generelValid = InputValidation(prop[0], @"(^[A-Z][a-zA-Z\-]+)", "Genre Must start with Upper Case");
                if (generelValid != "")
                    text += generelValid;
                return text;
            }
            catch
            {
                return "Eror";
            }
        }
        public string AuthorValidation(params string[] prop)
        {
            try
            {
                if (EmptyFields(prop))
                {
                    return "Please fill in all fields";
                }
                string text = "";
                string namelValid = InputValidation(prop[0], @"^[A-Z][A-Za-z\s]*$", "Name Must start with Upper Case");
                if (namelValid != "")
                    text += namelValid + "\n";
                string countrylValid = InputValidation(prop[1], @"^[A-Z][A-Za-z\s]*$", "Country Must start with Upper Case");
                if (countrylValid != "")
                    text += countrylValid + "\n";
                return text;
            }
            catch
            {
                return "Eror";
            }
        }
        public string BorrowValidation(params string[] prop)
        {
            try
            {
                if (EmptyFields(prop))
                {
                    return "Please fill in all fields";
                }
                var returnDate = DateTime.Parse(prop[0]);
                string text = "";
                string dateValid = DateValidation(returnDate);
                if (dateValid != "")
                    text += dateValid + "\n";
                string borrowUserValid = InputValidation(prop[1], "([1-9]+)", "Select User");
                if (borrowUserValid != "")
                    text += borrowUserValid + "\n";
                string borrowBookValid = InputValidation(prop[2], "([1-9]+)", "Select Book");
                if (borrowBookValid != "")
                    text += borrowBookValid;
                return text;
            }
            catch
            {
                return "Eror";
            }
        }
        public string UserValidation(params string[] prop)
        {
            try
            {
                if (EmptyFields(prop))
                {
                    return "Please fill in all fields";
                }
                string text = "";
                //Password Validation:Password Length 8 and Maximum 16 character,Require at least one(Lower Case,Upper Case,Digit)
                string passValid = InputValidation(prop[3], "^(?=.{8,16}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$", "Password Length 8 and Maximum 16 character,Require at least one(Lower Case,Upper Case,Digit)");
                if (passValid != "")
                    text += passValid + "\n";
                string emailValid = InputValidation(prop[4], @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", "Invalid Email");
                if (emailValid != "")
                    text += emailValid + "\n";
                string fnameValid = UserLenghtVlidation(prop[0], "fname");
                if (fnameValid != "")
                {
                    text += fnameValid + "\n";
                }
                string lnameValid = UserLenghtVlidation(prop[1], "lname");
                if (lnameValid != "")
                {
                    text += lnameValid + "\n";
                }
                string phonelValid = InputValidation(prop[5], @"^\+?(972|0)(\-)?0?(([23489]{1}\d{7})|[5]{1}\d{8})$", "Invalid Phone");
                if (phonelValid != "")
                    text += phonelValid + "\n";
                string tzlValid = IsraeliIdValidation(prop[6]);
                if (tzlValid != "")
                    text += tzlValid + "\n";
                string addresslValid = InputValidation(prop[7], @"^[#.0-9a-zA-Z\s,-]+$", "Invalid Address");
                if (addresslValid != "")
                    text += addresslValid + "\n";
                return text;
            }
            catch
            {
                return "Eror";
            }
        }
        //Filters Validation
        public string BookFilterValidation(int selectedFilter, string value, string type)
        {
            try
            {
                if (value == String.Empty)
                {
                    return "Eror, Search Bar is empty";
                }
                string message = "";
                if (type == "admin")
                {
                    switch (selectedFilter)
                    {
                        case -1:
                            message = "Eror, choose Fillter";
                            break;
                        case 0:
                        case 4:
                        case 5:
                        case 6:
                            message = InputValidation(value, @"^\d+$", "String Should Be Digit");
                            break;
                        case 2:
                        case 3:
                            message = InputValidation(value, @"^[A-Z][A-Za-z\s]*$", "String must have Upper Case only in first char");
                            break;
                        case 7:
                            message = InputValidation(value, @"(^[A-Z][a-zA-Z\-]+)", "String must have Upper Case only in first char");
                            break;
                    }
                }
                else
                {
                    switch (selectedFilter)
                    {
                        case -1:
                            message = "Eror, choose Fillter";
                            break;
                        case 3:
                        case 4:
                            if (InputValidation(value, @"^\d+$", "Should Be Digit") != "")
                            {
                                if (selectedFilter == 3)
                                {
                                    message = "Year Should Be Digit";
                                }
                                message = "Pages Should Be Digit";
                            }
                            break;
                        case 1:
                        case 2:
                        case 5:
                            message = InputValidation(value, @"^[A-Z][A-Za-z\s]*$", "Enter String with Upper Case First Letter");
                            break;
                    }
                }
                return message;
            }
            catch
            {
                return "Eror";
            }
        }
        public string GenreFilterValidation(int selectedFilter, string value)
        {
            try
            {
                if (value == String.Empty)
                {
                    return "Eror, Search Bar is empty";
                }
                string message = "";
                switch (selectedFilter)
                {
                    case -1:
                        message = "Eror, choose Fillter";
                        break;
                    case 0:
                        message = InputValidation(value, @"^\d+$", "Id Should Be Digit");
                        break;
                    case 1:
                        message = InputValidation(value, @"(^[A-Z][a-zA-Z\-]+)", "Enter String with Upper Case First Letter");
                        break;
                }
                return message;
            }
            catch
            {
                return "Eror";
            }
        }
        public string AuthorFilterValidation(int selectedFilter, string value)
        {
            try
            {
                if (value == String.Empty)
                {
                    return "Eror, Search Bar is empty";
                }
                string message = "";
                switch (selectedFilter)
                {
                    case -1:
                        message = "Eror, choose Fillter";
                        break;
                    case 0:
                        message = InputValidation(value, @"^\d+$", "Id Should Be Digit");
                        break;
                    case 1:
                    case 2:
                        message = InputValidation(value, @"^[A-Z][A-Za-z\s]*$", "String must start with Upper Case");
                        break;
                }
                return message;
            }
            catch
            {
                return "Eror";
            }
        }
        public string BorrowFilterValidation(int selectedFilter, string value, string type)
        {
            try
            {
                string message = "";
                if (type == "admin")
                {
                    if (value == String.Empty && value == String.Empty && selectedFilter != 3 && selectedFilter != 4)
                    {
                        return "Eror, Search Bar is empty";
                    }
                    switch (selectedFilter)
                    {
                        case -1:
                            message = "Eror, choose Fillter";
                            break;
                        case 0:
                            message = InputValidation(value, @"^\d+$", "Id Should Be Digit");
                            break;
                        case 1:
                            message = InputValidation(value, @"^[A-Z][a-z]*(\s[A-Z][a-z]*)+$", "Enter String with Upper Case First Letter");
                            break;
                        case 2:
                            message = InputValidation(value, @"([a-zA-Z0-9\-]+)", "Eror");
                            break;
                        case 5:
                        case 6:
                            if (!IsDate(value))
                            {
                                message = "invalid Date";
                            }
                            break;
                    }
                }
                else
                {
                    if (value == String.Empty && selectedFilter != 1 && selectedFilter != 2)
                    {
                        return "Eror, Search Bar is empty";
                    }
                    switch (selectedFilter)
                    {
                        case -1:
                            message = "Eror, choose Fillter";
                            break;
                        case 0:
                            message = InputValidation(value, @"([a-zA-Z0-9\-]+)", "Eror");
                            break;
                        case 3:
                        case 4:
                            if (!IsDate(value))
                            {
                                message = "invalid Date";
                            }
                            break;
                    }
                }
                return message;
            }
            catch
            {
                return "Eror";
            }
        }
        public string UserFilterValidation(int selectedFilter, string value)
        {
            try
            {
                if (value == String.Empty)
                {
                    return "Eror, Search Bar is empty";
                }
                string message = "";
                switch (selectedFilter)
                {
                    case -1:
                        message = "Eror, choose Fillter";
                        break;
                    case 0:
                        message = InputValidation(value, @"^\d+$", "Should Be Digit");
                        break;
                    case 1:
                    case 2:
                        message = InputValidation(value, "^[A-Z][a-z]*$", "Enter String with Upper Case First Letter");
                        break;
                    case 4:
                        if (value != "Admin" && value != "Client")
                        {
                            message = "There are no such role";
                        }
                        break;
                }
                return message;
            }
            catch
            {
                return "Eror";
            }
        }

    }
}
