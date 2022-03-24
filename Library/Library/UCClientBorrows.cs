using LibraryEntities.Models;
using LibraryLogic;

namespace Library
{
    public partial class UCClientBorrows : UserControl
    {
        static LibraryManagment LibraryManagment = LibraryManagment.GetInstance();
        User activeUser = new User();
        public UCClientBorrows(User obj)
        {
            InitializeComponent();
            this.activeUser=obj;
        }

        private void UCClientBorrows_Load(object sender, EventArgs e)
        {
            try
            {
                BorrowingsdataGridView.DataSource = LibraryManagment.GetDBBorrowings(activeUser);
            }
            catch
            {
                return;
            }
        }

        private void BorrowingsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (BorrowingsdataGridView.Columns[e.ColumnIndex].Name == "Return")
                {
                    string borrowId = BorrowingsdataGridView.Rows[e.RowIndex].Cells["borrowingIdDataGridViewTextBoxColumn"].Value.ToString();
                    LibraryManagment.ReturnBook(borrowId);
                    BorrowingsdataGridView.DataSource = LibraryManagment.GetDBBorrowings(activeUser);
                }
            }
            catch
            {
                return;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0);
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
                List<Borrowing> fillterd = LibraryManagment.BorrowFilter(fillterCmb.SelectedIndex, SearchtBox.Text, "client", activeUser);
                if (fillterd != null)
                {
                    BorrowingsdataGridView.DataSource = fillterd;
                }
            }
            catch
            {
                return;
            }
        }
    }
}
