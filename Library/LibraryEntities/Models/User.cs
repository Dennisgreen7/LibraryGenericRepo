using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryEntities.Models
{
    public partial class User
    {
        public User()
        {
            Borrowings = new HashSet<Borrowing>();
        }

        public int UsersId { get; set; }
        public string UsersFirstName { get; set; } = null!;
        public string UsersLastName { get; set; } = null!;
        public string UsersUserName { get; set; } = null!;
        public string UsersPassword { get; set; } = null!;
        public string UsersPhone { get; set; } = null!;
        public string UsersEmail { get; set; } = null!;
        public string UsersRole { get; set; } = null!;
        public string UsersAddress { get; set; } = null!;
        public string UserTzId { get; set; } = null!;
       
        [NotMapped]
        public string UsersFulltName { get=> UsersFirstName +" "+UsersLastName;  }

        public virtual ICollection<Borrowing> Borrowings { get; set; }
    }
}
