using LibraryEntities.Models;
using LibraryLogic;

namespace Library
{
    public partial class UCGenre : UserControl
    {
        static LibraryManagment libraryManagment = LibraryManagment.GetInstance();
        public UCGenre()
        {
            InitializeComponent();
        }
        private void UCGenre_Load(object sender, EventArgs e)
        {
            try
            {
                GenredataGridView.DataSource = libraryManagment.GetDBGenres();
                genreIdBox.Enabled = false;
            }
            catch
            {
                return;
            }
        }
        private void ClearTextBoxes()
        {
            try
            {

                genreBox.Text = genreIdBox.Text = string.Empty;
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
                if (!libraryManagment.AddGenre(genreBox.Text))
                {
                    return;
                }
                GenredataGridView.DataSource = libraryManagment.GetDBGenres();
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
                if (!libraryManagment.DeleteGenre(genreIdBox.Text))
                {
                    return;
                }
                GenredataGridView.DataSource = libraryManagment.GetDBGenres();
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

                if (!libraryManagment.UpdateGenre(genreBox.Text, genreIdBox.Text))
                {
                    return;
                }
                GenredataGridView.DataSource = libraryManagment.GetDBGenres();
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
                List<Genre> filterdGenre = libraryManagment.GenreFilter(fillterCmb.SelectedIndex, SearchtBox.Text);
                if (filterdGenre != null)
                {
                    GenredataGridView.DataSource = filterdGenre;
                }
            }
            catch
            {
                return;
            }
        }

        private void GenredataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GenredataGridView.CurrentRow.Selected = true;
                genreIdBox.Text = GenredataGridView.Rows[e.RowIndex].Cells["genreIdDataGridViewTextBoxColumn"].Value.ToString();
                genreBox.Text = GenredataGridView.Rows[e.RowIndex].Cells["genreNameDataGridViewTextBoxColumn"].Value.ToString();
            }
            catch
            {
                return;
            }
            
        }
    }
}
