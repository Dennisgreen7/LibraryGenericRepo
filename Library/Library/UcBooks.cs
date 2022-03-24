using LibraryEntities.Models;
using LibraryLogic;

namespace Library
{
    public partial class UcBooks : UserControl
    {

        static LibraryManagment libraryManagment = LibraryManagment.GetInstance();
        public UcBooks()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            try
            {

                bookIdBox.Text = booknameBox.Text = langBox.Text = copysBox.Text = pagesbox.Text = yearBox.Text = String.Empty;
            }
            catch 
            {
                return;
            }
        }
        private void UcBooks_Load(object sender, EventArgs e)
        {
            try
            {
                bookIdBox.Enabled = false;
                authorCmb.ValueMember = "AuthorId";
                authorCmb.DisplayMember = "AuthorName";
                authorCmb.DataSource = libraryManagment.GetDBAuthors();
                genreCmb.ValueMember = "GenreId";
                genreCmb.DisplayMember = "GenreName";
                genreCmb.DataSource = libraryManagment.GetDBGenres();
                BooksdataGridView.DataSource = libraryManagment.GetDBBooks();
            }
            catch
            {
                return;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!libraryManagment.AddBook(booknameBox.Text, langBox.Text, pagesbox.Text, copysBox.Text, authorCmb.SelectedValue.ToString(), genreCmb.SelectedValue.ToString(), yearBox.Text))
                {
                    return;
                }
                BooksdataGridView.DataSource = libraryManagment.GetDBBooks();
                ClearTextBoxes();
            }
            catch 
            {
                return;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!libraryManagment.DeleteBook(bookIdBox.Text))
                {
                    return;
                }
                BooksdataGridView.DataSource = libraryManagment.GetDBBooks();
                ClearTextBoxes();
            }
            catch
            {
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!libraryManagment.UpdateBook(booknameBox.Text, langBox.Text, pagesbox.Text, copysBox.Text, authorCmb.SelectedValue.ToString(), genreCmb.SelectedValue.ToString(), yearBox.Text, bookIdBox.Text))
                {
                    return;
                }
                BooksdataGridView.DataSource = libraryManagment.GetDBBooks();
            }
            catch
            {
                return;
            }
        }

        private void authorCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                Cursor.Current = Cursors.WaitCursor;
                Author obj = authorCmb.SelectedItem as Author;
                if (obj != null)
                {
                    book.AuthorId = obj.AuthorId;
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                return;
            }
        }

        private void genreCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                Cursor.Current = Cursors.WaitCursor;
                Genre obj = genreCmb.SelectedItem as Genre;
                if (obj != null)
                {
                    book.GenreId = obj.GenreId;
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<Book> filterdBook = libraryManagment.BookFilter(fillterCmb.SelectedIndex, SearchtBox.Text);
                if (filterdBook != null)
                {
                    BooksdataGridView.DataSource = filterdBook;
                }
            }
            catch
            {
                return;
            }
        }
        private void BooksdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BooksdataGridView.CurrentRow.Selected = true;
                bookIdBox.Text = BooksdataGridView.Rows[e.RowIndex].Cells["bookIdDataGridViewTextBoxColumn"].Value.ToString();
                booknameBox.Text = BooksdataGridView.Rows[e.RowIndex].Cells["bookNameDataGridViewTextBoxColumn"].Value.ToString();
                authorCmb.Text = BooksdataGridView.Rows[e.RowIndex].Cells["authorNameDataGridViewTextBoxColumn"].Value.ToString();
                pagesbox.Text = BooksdataGridView.Rows[e.RowIndex].Cells["bookNumOfPagesDataGridViewTextBoxColumn"].Value.ToString();
                copysBox.Text = BooksdataGridView.Rows[e.RowIndex].Cells["bookCopysDataGridViewTextBoxColumn"].Value.ToString();
                genreCmb.Text = BooksdataGridView.Rows[e.RowIndex].Cells["genreNameDataGridViewTextBoxColumn"].Value.ToString();
                langBox.Text = BooksdataGridView.Rows[e.RowIndex].Cells["bookLanguageDataGridViewTextBoxColumn"].Value.ToString();
                yearBox.Text = BooksdataGridView.Rows[e.RowIndex].Cells["bookPublishedYearDataGridViewTextBoxColumn"].Value.ToString();
            }
            catch
            {
                return;
            }
        }
    }
}
