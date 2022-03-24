using LibraryEntities.Models;
using LibraryLogic;

namespace Library
{
    public partial class UCBorrowings : UserControl
    {
        static LibraryManagment libraryManagment = LibraryManagment.GetInstance();
        public UCBorrowings()
        {
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                libraryManagment.DeleteBorrow(borrowidBox.Text);
                BorrowingsdataGridView.DataSource = libraryManagment.GetDBBorrowings();
                borrowidBox.Text = string.Empty;
            }
            catch 
            {
                return;
            }
        }

        private void UCBorrowings_Load(object sender, EventArgs e)
        {
            try
            {
                borrowidBox.Enabled = false;
                BorrowingsdataGridView.DataSource = libraryManagment.GetDBBorrowings();
                userCmb.ValueMember = "UsersId";
                userCmb.DisplayMember = "UsersFulltName";
                userCmb.DataSource = libraryManagment.GetDBUsers();

                bookCmb.ValueMember = "BookId";
                bookCmb.DisplayMember = "BookName";
                bookCmb.DataSource = libraryManagment.GetBooksCmbDB();
                dateTimePicker2.Value = DateTime.Now;
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
                if (!libraryManagment.AddBorrow(dateTimePicker2.Value.Date.ToString(), userCmb.SelectedValue.ToString(), bookCmb.SelectedValue.ToString()))
                {
                    return;
                }
                BorrowingsdataGridView.DataSource = libraryManagment.GetDBBorrowings();
                bookCmb.DataSource = libraryManagment.GetBooksCmbDB();
            }
            catch
            {
                return;
            }
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            try
            {
                BorrowingsdataGridView.DataSource = libraryManagment.GetDBBorrowings();
                bookCmb.DataSource = libraryManagment.GetBooksCmbDB();
            }
            catch
            {
                return;
            }
            if (!libraryManagment.ReturnBook(borrowidBox.Text))
            {
                return;
            }
        }

        private void userCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Borrowing borrowing = new Borrowing();
                Cursor.Current = Cursors.WaitCursor;
                User obj = userCmb.SelectedItem as User;
                if (obj != null)
                {
                    borrowing.BorrowingUserId = obj.UsersId;
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                return;
            }
        }

        private void bookCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Borrowing borrowing = new Borrowing();
                Cursor.Current = Cursors.WaitCursor;
                Book obj = bookCmb.SelectedItem as Book;
                if (obj != null)
                {
                    borrowing.BorrowingBookId = obj.BookId;
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
                List<Borrowing> filterdBorrows = libraryManagment.BorrowFilter(fillterCmb.SelectedIndex, SearchtBox.Text, "admin");
                if (filterdBorrows != null)
                {
                    BorrowingsdataGridView.DataSource = filterdBorrows;
                }
            }
            catch
            {
                return;
            }
        }

        private void BorrowingsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BorrowingsdataGridView.CurrentRow.Selected = true;
                borrowidBox.Text = BorrowingsdataGridView.Rows[e.RowIndex].Cells["borrowingIdDataGridViewTextBoxColumn"].Value.ToString();
                dateTimePicker2.Text = BorrowingsdataGridView.Rows[e.RowIndex].Cells["borrowingReturnDateDataGridViewTextBoxColumn"].Value.ToString();
                userCmb.Text = BorrowingsdataGridView.Rows[e.RowIndex].Cells["userNameDataGridViewTextBoxColumn"].Value.ToString();
                bookCmb.Text = BorrowingsdataGridView.Rows[e.RowIndex].Cells["bookNameDataGridViewTextBoxColumn"].Value.ToString();
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
                if (!libraryManagment.UpdateBorrow(dateTimePicker2.Value.Date, userCmb.SelectedValue.ToString(), bookCmb.SelectedValue.ToString(), borrowidBox.Text))
                {
                    return;
                }
                BorrowingsdataGridView.DataSource = libraryManagment.GetDBBorrowings();
            }
            catch 
            {
                return;
            }
        }
    }
}