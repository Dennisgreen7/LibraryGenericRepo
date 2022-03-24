using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryEntities.Models
{
    public partial class Book
    {
        public Book()
        {
            Borrowings = new HashSet<Borrowing>();
        }

        public int BookId { get; set; }
        public string BookName { get; set; } = null!;
        public int AuthorId { get; set; }
        public int BookPublishedYear { get; set; }
        public int GenreId { get; set; }
        public string BookLanguage { get; set; } = null!;
        public int BookNumOfPages { get; set; }
        public int BookCopys { get; set; }
        // [NotMapped] מסמן לא להוסיף את המאפיין כעמודה בטבלה 
        [NotMapped] 
        public string AuthorName { get => Author.AuthorName; }
        [NotMapped]
        public string GenreName { get => Genre.GenreName; }
        public virtual Author Author { get; set; } = null!;
        public virtual Genre Genre { get; set; } = null!;
        public virtual ICollection<Borrowing> Borrowings { get; set; }
    }
}
