using LibraryEntities.Models;
using LibraryLogic;

namespace Library
{
    public partial class Form1 : Form
    {
        static LibraryManagment libraryManagment = LibraryManagment.GetInstance();
        static User actUser = new User();
        public Form1()
        {
            InitializeComponent();
            libraryManagment.InvalidInputEvent += TextboxValidation;
        }
        private void TextboxValidation(string message)
        {
            try
            {
                MessageBox.Show(message);
            }
            catch 
            {
                return;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            regiPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (libraryManagment.Login(unameBox.Text, passBox.Text))
                {
                    actUser = libraryManagment.GetUserLogin(unameBox.Text);
                    this.Hide();
                    Form2 form2 = new Form2(actUser);
                    form2.ShowDialog();
                }
            }
            catch
            {
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LightGray;
            btnRegi.BackColor = Color.DarkGray;
            regiPanel.Visible = false;
            panel1.Visible = true;
        }

        private void btnRegi_Click(object sender, EventArgs e)
        {
            btnRegi.BackColor = Color.LightGray;
            btnLogin.BackColor = Color.DarkGray;
            regiPanel.Visible = true;
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!libraryManagment.Registration(regiFnameBox.Text, regiLnameBox.Text, regiUnameBox.Text, regiPassBox.Text, regiEmailBox.Text, regiPhoneBox.Text, regiTzBox.Text, regiAdressBox.Text, "Client"))
                {
                    return;
                }
                btnLogin.BackColor = Color.LightGray;
                btnRegi.BackColor = Color.DarkGray;
                regiPanel.Visible = false;
                panel1.Visible = true;
            }
            catch
            {
                return;
            }
        }
    }
}
