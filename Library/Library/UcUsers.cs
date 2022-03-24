using LibraryEntities.Models;
using LibraryLogic;
namespace Library
{
    public partial class UcUsers : UserControl
    {
        static LibraryManagment libraryManagment = LibraryManagment.GetInstance();
        List<string> roles = new List<string>() { "Admin", "Client" };
        public UcUsers()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            try
            {

                userIdBox.Text = fnameBox.Text = lnameBox.Text = unameBox.Text = passwordbox.Text = phoneBox.Text = addressBox.Text = enailBox.Text = tzBox.Text = string.Empty;
            }
            catch 
            {
                return;
            }
        }
        private void UcUsers_Load(object sender, EventArgs e)
        {
            try
            {
                userIdBox.Enabled = false;
                UserdataGridView.DataSource = libraryManagment.GetDBUsers();
                roleCmb.DataSource = roles;
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
                if (!libraryManagment.AddUser(fnameBox.Text, lnameBox.Text, unameBox.Text, passwordbox.Text, enailBox.Text, phoneBox.Text, tzBox.Text, addressBox.Text, (string)roleCmb.SelectedValue))
                {
                    return;
                }
                UserdataGridView.DataSource = libraryManagment.GetDBUsers();
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
                if (!libraryManagment.UpdateUser(fnameBox.Text, lnameBox.Text, unameBox.Text, passwordbox.Text, enailBox.Text, phoneBox.Text, tzBox.Text, addressBox.Text, (string)roleCmb.SelectedValue, userIdBox.Text))
                {
                    return;
                }
                UserdataGridView.DataSource = libraryManagment.GetDBUsers();
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
                if (!libraryManagment.DeleteUser(userIdBox.Text))
                {
                    return;
                }
                UserdataGridView.DataSource = libraryManagment.GetDBUsers();
                ClearTextBoxes();
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
                List<User> fillterdUser = libraryManagment.UserFilter(fillterCmb.SelectedIndex, SearchtBox.Text);
                if (fillterdUser != null)
                {
                    UserdataGridView.DataSource = fillterdUser;
                }
            }
            catch
            {
                return;
            }
        }

        private void UserdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UserdataGridView.CurrentRow.Selected = true;
                userIdBox.Text = UserdataGridView.Rows[e.RowIndex].Cells["usersIdDataGridViewTextBoxColumn"].Value.ToString();
                fnameBox.Text = UserdataGridView.Rows[e.RowIndex].Cells["usersFirstNameDataGridViewTextBoxColumn"].Value.ToString();
                lnameBox.Text = UserdataGridView.Rows[e.RowIndex].Cells["usersLastNameDataGridViewTextBoxColumn"].Value.ToString();
                unameBox.Text = UserdataGridView.Rows[e.RowIndex].Cells["usersUserNameDataGridViewTextBoxColumn"].Value.ToString();
                passwordbox.Text = UserdataGridView.Rows[e.RowIndex].Cells["usersPasswordDataGridViewTextBoxColumn"].Value.ToString();
                enailBox.Text = UserdataGridView.Rows[e.RowIndex].Cells["usersEmailDataGridViewTextBoxColumn"].Value.ToString();
                roleCmb.Text = UserdataGridView.Rows[e.RowIndex].Cells["usersRoleDataGridViewTextBoxColumn"].Value.ToString();
                phoneBox.Text = UserdataGridView.Rows[e.RowIndex].Cells["usersPhoneDataGridViewTextBoxColumn"].Value.ToString();
                tzBox.Text = UserdataGridView.Rows[e.RowIndex].Cells["userTzIdDataGridViewTextBoxColumn"].Value.ToString();
                addressBox.Text = UserdataGridView.Rows[e.RowIndex].Cells["usersAddressDataGridViewTextBoxColumn"].Value.ToString();
            }
            catch
            {
                return;
            }
        }
    }
}
