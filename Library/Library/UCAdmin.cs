using LibraryEntities.Models;
namespace Library
{
    public partial class UCAdmin : UserControl
    {
        User activeUser = new User();
        public UCAdmin( User obj)
        {
            InitializeComponent();
            this.activeUser = obj;
        }

        private void UCAdmin_Load(object sender, EventArgs e)
        {
            contentPanel.Height = 720;
            label2.Text = activeUser.UsersUserName;
            UcBooks uc = new UcBooks();
            uc.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(uc);
            MessageBox.Show("Welcome Back " + activeUser.UsersFulltName);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try 
            {

                UcUsers uc = new UcUsers();
                contentPanel.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(uc);
            }
            catch 
            {
                return;
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            try
            {

                UcBooks uc = new UcBooks();
                contentPanel.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(uc);
            }
            catch
            {
                return;
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {

                UCBorrowings uc = new UCBorrowings();
                contentPanel.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(uc);
            }
            catch
            {
                return;
            }
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            try
            {

                UCAuthors uc = new UCAuthors();
                contentPanel.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(uc);
            }
            catch
            {
                return;
            }
        }

        private void btnGeners_Click(object sender, EventArgs e)
        {
            try
            {

                UCGenre uc = new UCGenre();
                contentPanel.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(uc);
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
    }
}
