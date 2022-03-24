using LibraryEntities.Models;

namespace Library
{
    public partial class Form2 : Form
    {
        User activeUser = new User();
        public Form2(User obj)
        {
            InitializeComponent();
            this.activeUser = obj;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            try
            {
                if (activeUser.UsersRole == "Admin")
                {
                    UCAdmin uc = new UCAdmin(activeUser);
                    this.Width = uc.Width;
                    this.Height = uc.Height + 53;
                    uc.Dock = DockStyle.Fill;
                    contentPanel.Controls.Add(uc);
                }
                else
                {
                    UCClient uc = new UCClient(activeUser);
                    this.Width = uc.Width;
                    this.Height = uc.Height + 46;
                    uc.Dock = DockStyle.Fill;
                    contentPanel.Controls.Add(uc);
                }
            }
            catch 
            {
                return;
            }
        }
    }
}
