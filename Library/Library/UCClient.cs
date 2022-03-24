using LibraryEntities.Models;

namespace Library
{
    public partial class UCClient : UserControl
    {
        User activeUser = new User();
        public UCClient(User obj)
        {
            InitializeComponent();
            this.activeUser = obj;
        }

        private void UCClient_Load(object sender, EventArgs e)
        {
            try
            {
                label2.Text = activeUser.UsersUserName;
                UcClientBooks uc = new UcClientBooks(activeUser);
                uc.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(uc);
                MessageBox.Show("Welcome Back " + activeUser.UsersFulltName);
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

        private void btnBooks_Click(object sender, EventArgs e)
        {
            try
            {
                UcClientBooks uc = new UcClientBooks(activeUser);
                uc.Dock = DockStyle.Fill;
                contentPanel.Controls.Clear();
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
                UCClientBorrows uc = new UCClientBorrows(activeUser);
                uc.Dock = DockStyle.Fill;
                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(uc);
            }
            catch
            {
                return;
            }
        }
    }
}
