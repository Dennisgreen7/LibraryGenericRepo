using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibraryEntities.Models
{
    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Borrowing> Borrowings { get; set; } = null!;
        public virtual DbSet<Genre> Genres { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.AuthorId).HasColumnName("authorId");

                entity.Property(e => e.AuthorCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("authorCountry");

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("authorName");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.AuthorId).HasColumnName("authorId");

                entity.Property(e => e.BookCopys).HasColumnName("bookCopys");

                entity.Property(e => e.BookLanguage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bookLanguage");

                entity.Property(e => e.BookName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bookName");

                entity.Property(e => e.BookNumOfPages).HasColumnName("bookNumOfPages");

                entity.Property(e => e.BookPublishedYear).HasColumnName("bookPublishedYear");

                entity.Property(e => e.GenreId).HasColumnName("genreId");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Books_Authors");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Books_Genres");
            });

            modelBuilder.Entity<Borrowing>(entity =>
            {
                entity.Property(e => e.BorrowingId).HasColumnName("borrowingId");

                entity.Property(e => e.BorrowingBookId).HasColumnName("borrowingBookId");

                entity.Property(e => e.BorrowingDate)
                    .HasColumnType("date")
                    .HasColumnName("borrowingDate");

                entity.Property(e => e.BorrowingReturnDate)
                    .HasColumnType("date")
                    .HasColumnName("borrowingReturnDate");

                entity.Property(e => e.BorrowingReturnedDate)
                    .HasColumnType("date")
                    .HasColumnName("borrowingReturnedDate");

                entity.Property(e => e.BorrowingUserId).HasColumnName("borrowingUserId");

                entity.HasOne(d => d.BorrowingBook)
                    .WithMany(p => p.Borrowings)
                    .HasForeignKey(d => d.BorrowingBookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Borrowings_Books");

                entity.HasOne(d => d.BorrowingUser)
                    .WithMany(p => p.Borrowings)
                    .HasForeignKey(d => d.BorrowingUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Borrowings_Borrowers");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(e => e.GenreId).HasColumnName("genreId");

                entity.Property(e => e.GenreName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genreName");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UsersId)
                    .HasName("PK_Borrowers");

                entity.Property(e => e.UserTzId)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.UsersAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsersEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsersFirstName)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UsersLastName)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UsersPassword)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UsersPhone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsersRole)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsersUserName)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, AuthorName = "Dennis", AuthorCountry = "Israel" },
                new Author { AuthorId = 2, AuthorName = "Mark", AuthorCountry = "Israel" }
                );
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, GenreName= "Fantasy" },
                new Genre { GenreId = 2, GenreName = "History" }
                );
            modelBuilder.Entity<Book>().HasData(
               new Book { BookId = 1, BookCopys = 10, BookLanguage="Eng", BookName= "Harry Potter", BookNumOfPages = 400, BookPublishedYear = 1999,AuthorId = 1,GenreId = 1},
               new Book { BookId = 2, BookCopys = 4, BookLanguage = "Eng", BookName = "Percy Jackson", BookNumOfPages = 200, BookPublishedYear = 1960, AuthorId = 2, GenreId = 2 }
               );
            modelBuilder.Entity<User>().HasData(
               new User { UsersId = 1, UsersFirstName = "Cristiano", UsersLastName = "Ronaldo",UsersUserName = "Cr123456", UsersEmail = "cr7@gmail.com" , UsersPassword = "Cr123456", UsersPhone = "0526552022", UserTzId = "315566288", UsersAddress = "Hertzel,7,Tel-Aviv", UsersRole = "Admin" },
               new User { UsersId = 2, UsersFirstName = "Lionel", UsersLastName = "Messi", UsersUserName = "Ms123456", UsersEmail = "ms30@gmail.com", UsersPassword = "Ms123456", UsersPhone = "0526552078", UserTzId = "315567388", UsersAddress = "Sokolov,30,Ramat-Gan", UsersRole = "Client" }
               );
            modelBuilder.Entity<Borrowing>().HasData(
               new Borrowing { BorrowingId = 1, BorrowingBookId = 1, BorrowingUserId = 1,BorrowingDate=DateTime.Now , BorrowingReturnDate= DateTime.Now.AddDays(14), BorrowingReturnedDate = null},
               new Borrowing { BorrowingId = 2, BorrowingBookId = 2, BorrowingUserId = 2, BorrowingDate = DateTime.Now, BorrowingReturnDate = DateTime.Now.AddDays(14), BorrowingReturnedDate = null }
               );
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
