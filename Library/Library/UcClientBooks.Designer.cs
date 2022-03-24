namespace Library
{
    partial class UcClientBooks
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcClientBooks));
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchtBox = new System.Windows.Forms.TextBox();
            this.fillterCmb = new System.Windows.Forms.ComboBox();
            this.datagridPanel = new System.Windows.Forms.Panel();
            this.BooksdataGridView = new System.Windows.Forms.DataGridView();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNumOfPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCopysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.datagridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.searchPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 52);
            this.panel2.TabIndex = 31;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.panel9);
            this.searchPanel.Controls.Add(this.fillterCmb);
            this.searchPanel.Location = new System.Drawing.Point(255, 5);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(2);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(632, 33);
            this.searchPanel.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnSearch);
            this.panel9.Controls.Add(this.SearchtBox);
            this.panel9.Location = new System.Drawing.Point(207, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(426, 31);
            this.panel9.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(296, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchtBox
            // 
            this.SearchtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchtBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchtBox.Location = new System.Drawing.Point(0, 0);
            this.SearchtBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchtBox.Name = "SearchtBox";
            this.SearchtBox.Size = new System.Drawing.Size(426, 32);
            this.SearchtBox.TabIndex = 1;
            // 
            // fillterCmb
            // 
            this.fillterCmb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fillterCmb.FormattingEnabled = true;
            this.fillterCmb.Items.AddRange(new object[] {
            "Name",
            "Author",
            "Langauge",
            "Year",
            "Pages",
            "Genre"});
            this.fillterCmb.Location = new System.Drawing.Point(2, 1);
            this.fillterCmb.Margin = new System.Windows.Forms.Padding(2);
            this.fillterCmb.Name = "fillterCmb";
            this.fillterCmb.Size = new System.Drawing.Size(201, 33);
            this.fillterCmb.TabIndex = 0;
            this.fillterCmb.Text = "Fillter By";
            // 
            // datagridPanel
            // 
            this.datagridPanel.BackColor = System.Drawing.Color.Transparent;
            this.datagridPanel.Controls.Add(this.BooksdataGridView);
            this.datagridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridPanel.Location = new System.Drawing.Point(0, 52);
            this.datagridPanel.Name = "datagridPanel";
            this.datagridPanel.Size = new System.Drawing.Size(1108, 588);
            this.datagridPanel.TabIndex = 32;
            // 
            // BooksdataGridView
            // 
            this.BooksdataGridView.AllowUserToDeleteRows = false;
            this.BooksdataGridView.AutoGenerateColumns = false;
            this.BooksdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.genreNameDataGridViewTextBoxColumn,
            this.bookLanguageDataGridViewTextBoxColumn,
            this.bookNumOfPagesDataGridViewTextBoxColumn,
            this.bookPublishedYearDataGridViewTextBoxColumn,
            this.Borrow,
            this.authorDataGridViewTextBoxColumn,
            this.authorIdDataGridViewTextBoxColumn,
            this.genreIdDataGridViewTextBoxColumn,
            this.bookCopysDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.borrowingsDataGridViewTextBoxColumn});
            this.BooksdataGridView.DataSource = this.bookBindingSource;
            this.BooksdataGridView.Location = new System.Drawing.Point(19, 0);
            this.BooksdataGridView.Name = "BooksdataGridView";
            this.BooksdataGridView.ReadOnly = true;
            this.BooksdataGridView.RowHeadersWidth = 51;
            this.BooksdataGridView.RowTemplate.Height = 29;
            this.BooksdataGridView.Size = new System.Drawing.Size(1055, 562);
            this.BooksdataGridView.TabIndex = 0;
            this.BooksdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksdataGridView_CellContentClick);
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            this.bookIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIdDataGridViewTextBoxColumn.Visible = false;
            this.bookIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // genreNameDataGridViewTextBoxColumn
            // 
            this.genreNameDataGridViewTextBoxColumn.DataPropertyName = "GenreName";
            this.genreNameDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreNameDataGridViewTextBoxColumn.Name = "genreNameDataGridViewTextBoxColumn";
            this.genreNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookLanguageDataGridViewTextBoxColumn
            // 
            this.bookLanguageDataGridViewTextBoxColumn.DataPropertyName = "BookLanguage";
            this.bookLanguageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.bookLanguageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookLanguageDataGridViewTextBoxColumn.Name = "bookLanguageDataGridViewTextBoxColumn";
            this.bookLanguageDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookLanguageDataGridViewTextBoxColumn.Width = 135;
            // 
            // bookNumOfPagesDataGridViewTextBoxColumn
            // 
            this.bookNumOfPagesDataGridViewTextBoxColumn.DataPropertyName = "BookNumOfPages";
            this.bookNumOfPagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.bookNumOfPagesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNumOfPagesDataGridViewTextBoxColumn.Name = "bookNumOfPagesDataGridViewTextBoxColumn";
            this.bookNumOfPagesDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookNumOfPagesDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookPublishedYearDataGridViewTextBoxColumn
            // 
            this.bookPublishedYearDataGridViewTextBoxColumn.DataPropertyName = "BookPublishedYear";
            this.bookPublishedYearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.bookPublishedYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookPublishedYearDataGridViewTextBoxColumn.Name = "bookPublishedYearDataGridViewTextBoxColumn";
            this.bookPublishedYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookPublishedYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // Borrow
            // 
            this.Borrow.HeaderText = "Borrow Book";
            this.Borrow.MinimumWidth = 6;
            this.Borrow.Name = "Borrow";
            this.Borrow.ReadOnly = true;
            this.Borrow.Text = "Borrow";
            this.Borrow.UseColumnTextForButtonValue = true;
            this.Borrow.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Visible = false;
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.HeaderText = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            this.authorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorIdDataGridViewTextBoxColumn.Visible = false;
            this.authorIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            this.genreIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreIdDataGridViewTextBoxColumn.Visible = false;
            this.genreIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookCopysDataGridViewTextBoxColumn
            // 
            this.bookCopysDataGridViewTextBoxColumn.DataPropertyName = "BookCopys";
            this.bookCopysDataGridViewTextBoxColumn.HeaderText = "BookCopys";
            this.bookCopysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookCopysDataGridViewTextBoxColumn.Name = "bookCopysDataGridViewTextBoxColumn";
            this.bookCopysDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookCopysDataGridViewTextBoxColumn.Visible = false;
            this.bookCopysDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn.Visible = false;
            this.genreDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowingsDataGridViewTextBoxColumn
            // 
            this.borrowingsDataGridViewTextBoxColumn.DataPropertyName = "Borrowings";
            this.borrowingsDataGridViewTextBoxColumn.HeaderText = "Borrowings";
            this.borrowingsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingsDataGridViewTextBoxColumn.Name = "borrowingsDataGridViewTextBoxColumn";
            this.borrowingsDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingsDataGridViewTextBoxColumn.Visible = false;
            this.borrowingsDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(LibraryEntities.Models.Book);
            // 
            // UcClientBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.Adobe_Portfolio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.datagridPanel);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "UcClientBooks";
            this.Size = new System.Drawing.Size(1108, 640);
            this.Load += new System.EventHandler(this.UcClientBooks_Load);
            this.panel2.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.datagridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Panel searchPanel;
        private Panel panel9;
        private Button btnSearch;
        private TextBox SearchtBox;
        private ComboBox fillterCmb;
        private Panel datagridPanel;
        private DataGridView BooksdataGridView;
        private BindingSource bookBindingSource;
        private DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookLanguageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookNumOfPagesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookPublishedYearDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Borrow;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookCopysDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingsDataGridViewTextBoxColumn;
    }
}
