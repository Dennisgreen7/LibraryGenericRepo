using LibraryEntities.Models;
using LibraryLogic;

namespace Library
{
    public partial class UCAuthors : UserControl
    {
        static LibraryManagment libraryManagment = LibraryManagment.GetInstance();
        public UCAuthors()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            try
            {
                authorIdBox.Text = authorNameBox.Text = countryBox.Text = String.Empty;
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
                if (!libraryManagment.AddAuthor(authorNameBox.Text, countryBox.Text))
                {
                    return;
                }
                AuthordataGridView.DataSource = libraryManagment.GetDBAuthors();
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
                if (!libraryManagment.DeleteAuthor(authorIdBox.Text))
                {
                    return;
                }
                AuthordataGridView.DataSource = libraryManagment.GetDBAuthors();
                ClearTextBoxes();
            }
            catch
            {
                return;
            }
        }

        private void UCAuthors_Load(object sender, EventArgs e)
        {
            try
            {
                AuthordataGridView.DataSource = libraryManagment.GetDBAuthors();
                authorIdBox.Enabled = false;
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
                if (!libraryManagment.UpdateAuthor(authorNameBox.Text, countryBox.Text, authorIdBox.Text))
                {
                    return;
                }
                AuthordataGridView.DataSource = libraryManagment.GetDBAuthors();
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
                List<Author> fillterdAuthor = libraryManagment.AuthorFilter(fillterCmb.SelectedIndex, SearchtBox.Text);
                if (fillterdAuthor != null)
                {
                    AuthordataGridView.DataSource = fillterdAuthor;
                }
            }
            catch
            {
                return;
            }
        }

        private void AuthordataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AuthordataGridView.CurrentRow.Selected = true;
                authorIdBox.Text = AuthordataGridView.Rows[e.RowIndex].Cells["authorIdDataGridViewTextBoxColumn"].Value.ToString();
                authorNameBox.Text = AuthordataGridView.Rows[e.RowIndex].Cells["authorNameDataGridViewTextBoxColumn"].Value.ToString();
                countryBox.Text = AuthordataGridView.Rows[e.RowIndex].Cells["authorCountryDataGridViewTextBoxColumn"].Value.ToString();
            }
            catch
            {
                return;
            }
        }
    }
}
