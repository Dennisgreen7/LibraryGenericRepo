using LibraryEntities.Models;
using LibraryLogic;


namespace Library
{
    public partial class UcClientBooks : UserControl
    {
        static LibraryManagment LibraryManagment = LibraryManagment.GetInstance();
        User activeUser = new User();
        public UcClientBooks(User obj)
        {
            InitializeComponent();
            this.activeUser = obj;
        }

        private void UcClientBooks_Load(object sender, EventArgs e)
        {
            try
            {
                BooksdataGridView.DataSource = LibraryManagment.GetBooksCmbDB();
            }
            catch
            {
                return;
            }
        }

        private void BooksdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (BooksdataGridView.Columns[e.ColumnIndex].Name == "Borrow")
                {
                    LibraryManagment.AddBorrow(DateTime.Now.AddDays(14).Date.ToString(), activeUser.UsersId.ToString(), BooksdataGridView.Rows[e.RowIndex].Cells["bookIdDataGridViewTextBoxColumn"].Value.ToString());
                    BooksdataGridView.DataSource = LibraryManagment.GetBooksCmbDB();
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
                List<Book> fillterd = LibraryManagment.ClientBookFilter(fillterCmb.SelectedIndex, SearchtBox.Text);
                if (fillterd != null)
                {
                    BooksdataGridView.DataSource = fillterd;
                }
            }
            catch
            {
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
