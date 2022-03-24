namespace Library
{
    partial class UcBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.copysBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.authorCmb = new System.Windows.Forms.ComboBox();
            this.genreCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pagesbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bookIdBox = new System.Windows.Forms.TextBox();
            this.BookId = new System.Windows.Forms.Label();
            this.langBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.booknameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchtBox = new System.Windows.Forms.TextBox();
            this.fillterCmb = new System.Windows.Forms.ComboBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datagridPanel = new System.Windows.Forms.Panel();
            this.BooksdataGridView = new System.Windows.Forms.DataGridView();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNumOfPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCopysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            this.datagridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.searchPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 138);
            this.panel1.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Firebrick;
            this.panel11.Controls.Add(this.yearBox);
            this.panel11.Controls.Add(this.copysBox);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.authorCmb);
            this.panel11.Controls.Add(this.genreCmb);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.pagesbox);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.bookIdBox);
            this.panel11.Controls.Add(this.BookId);
            this.panel11.Controls.Add(this.langBox);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.booknameBox);
            this.panel11.Controls.Add(this.label2);
            this.panel11.ForeColor = System.Drawing.Color.Snow;
            this.panel11.Location = new System.Drawing.Point(118, 42);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(899, 91);
            this.panel11.TabIndex = 6;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(742, 54);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(117, 27);
            this.yearBox.TabIndex = 7;
            // 
            // copysBox
            // 
            this.copysBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copysBox.Location = new System.Drawing.Point(91, 50);
            this.copysBox.Margin = new System.Windows.Forms.Padding(2);
            this.copysBox.Name = "copysBox";
            this.copysBox.Size = new System.Drawing.Size(92, 32);
            this.copysBox.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(32, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Copys";
            // 
            // authorCmb
            // 
            this.authorCmb.FormattingEnabled = true;
            this.authorCmb.Location = new System.Drawing.Point(287, 52);
            this.authorCmb.Margin = new System.Windows.Forms.Padding(2);
            this.authorCmb.Name = "authorCmb";
            this.authorCmb.Size = new System.Drawing.Size(160, 28);
            this.authorCmb.TabIndex = 39;
            this.authorCmb.SelectionChangeCommitted += new System.EventHandler(this.authorCmb_SelectionChangeCommitted);
            // 
            // genreCmb
            // 
            this.genreCmb.FormattingEnabled = true;
            this.genreCmb.Location = new System.Drawing.Point(547, 52);
            this.genreCmb.Margin = new System.Windows.Forms.Padding(2);
            this.genreCmb.Name = "genreCmb";
            this.genreCmb.Size = new System.Drawing.Size(117, 28);
            this.genreCmb.TabIndex = 38;
            this.genreCmb.SelectionChangeCommitted += new System.EventHandler(this.genreCmb_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(685, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(685, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Pages";
            // 
            // pagesbox
            // 
            this.pagesbox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pagesbox.Location = new System.Drawing.Point(742, 10);
            this.pagesbox.Margin = new System.Windows.Forms.Padding(2);
            this.pagesbox.Name = "pagesbox";
            this.pagesbox.Size = new System.Drawing.Size(117, 32);
            this.pagesbox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(226, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(483, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Genre";
            // 
            // bookIdBox
            // 
            this.bookIdBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookIdBox.Location = new System.Drawing.Point(91, 10);
            this.bookIdBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookIdBox.Name = "bookIdBox";
            this.bookIdBox.Size = new System.Drawing.Size(92, 32);
            this.bookIdBox.TabIndex = 23;
            // 
            // BookId
            // 
            this.BookId.AutoSize = true;
            this.BookId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BookId.Location = new System.Drawing.Point(59, 10);
            this.BookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookId.Name = "BookId";
            this.BookId.Size = new System.Drawing.Size(22, 20);
            this.BookId.TabIndex = 22;
            this.BookId.Text = "Id";
            // 
            // langBox
            // 
            this.langBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.langBox.Location = new System.Drawing.Point(547, 7);
            this.langBox.Margin = new System.Windows.Forms.Padding(2);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(117, 32);
            this.langBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(458, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Langauge";
            // 
            // booknameBox
            // 
            this.booknameBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.booknameBox.Location = new System.Drawing.Point(287, 10);
            this.booknameBox.Margin = new System.Windows.Forms.Padding(2);
            this.booknameBox.Name = "booknameBox";
            this.booknameBox.Size = new System.Drawing.Size(160, 32);
            this.booknameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(191, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name ";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.panel9);
            this.searchPanel.Controls.Add(this.fillterCmb);
            this.searchPanel.Location = new System.Drawing.Point(246, 2);
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
            "Id",
            "Name",
            "Author",
            "Langauge",
            "Year",
            "Pages",
            "Copys",
            "Genre"});
            this.fillterCmb.Location = new System.Drawing.Point(2, 1);
            this.fillterCmb.Margin = new System.Windows.Forms.Padding(2);
            this.fillterCmb.Name = "fillterCmb";
            this.fillterCmb.Size = new System.Drawing.Size(201, 33);
            this.fillterCmb.TabIndex = 0;
            this.fillterCmb.Text = "Fillter By";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(LibraryEntities.Models.Book);
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(LibraryEntities.Models.Author);
            // 
            // datagridPanel
            // 
            this.datagridPanel.BackColor = System.Drawing.Color.Transparent;
            this.datagridPanel.Controls.Add(this.BooksdataGridView);
            this.datagridPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagridPanel.Location = new System.Drawing.Point(0, 138);
            this.datagridPanel.Name = "datagridPanel";
            this.datagridPanel.Size = new System.Drawing.Size(1142, 361);
            this.datagridPanel.TabIndex = 4;
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
            this.authorIdDataGridViewTextBoxColumn,
            this.genreIdDataGridViewTextBoxColumn,
            this.bookNumOfPagesDataGridViewTextBoxColumn,
            this.bookCopysDataGridViewTextBoxColumn,
            this.bookLanguageDataGridViewTextBoxColumn,
            this.bookPublishedYearDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.borrowingsDataGridViewTextBoxColumn});
            this.BooksdataGridView.DataSource = this.bookBindingSource;
            this.BooksdataGridView.Location = new System.Drawing.Point(12, 0);
            this.BooksdataGridView.Name = "BooksdataGridView";
            this.BooksdataGridView.ReadOnly = true;
            this.BooksdataGridView.RowHeadersWidth = 51;
            this.BooksdataGridView.RowTemplate.Height = 29;
            this.BooksdataGridView.Size = new System.Drawing.Size(1094, 352);
            this.BooksdataGridView.TabIndex = 0;
            this.BooksdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksdataGridView_CellClick);
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.bookIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookNameDataGridViewTextBoxColumn.Width = 125;
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
            // bookNumOfPagesDataGridViewTextBoxColumn
            // 
            this.bookNumOfPagesDataGridViewTextBoxColumn.DataPropertyName = "BookNumOfPages";
            this.bookNumOfPagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.bookNumOfPagesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNumOfPagesDataGridViewTextBoxColumn.Name = "bookNumOfPagesDataGridViewTextBoxColumn";
            this.bookNumOfPagesDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookNumOfPagesDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookCopysDataGridViewTextBoxColumn
            // 
            this.bookCopysDataGridViewTextBoxColumn.DataPropertyName = "BookCopys";
            this.bookCopysDataGridViewTextBoxColumn.HeaderText = "Copys";
            this.bookCopysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookCopysDataGridViewTextBoxColumn.Name = "bookCopysDataGridViewTextBoxColumn";
            this.bookCopysDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookCopysDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookLanguageDataGridViewTextBoxColumn
            // 
            this.bookLanguageDataGridViewTextBoxColumn.DataPropertyName = "BookLanguage";
            this.bookLanguageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.bookLanguageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookLanguageDataGridViewTextBoxColumn.Name = "bookLanguageDataGridViewTextBoxColumn";
            this.bookLanguageDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookLanguageDataGridViewTextBoxColumn.Width = 125;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 502);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 74);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(194, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 64);
            this.panel3.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Sienna;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Image = global::Library.Properties.Resources.icons8_delete_50;
            this.btnDelete.Location = new System.Drawing.Point(285, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 61);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Sienna;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Image = global::Library.Properties.Resources.icons8_save_50;
            this.btnSave.Location = new System.Drawing.Point(570, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 64);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Image = global::Library.Properties.Resources.icons8_plus_math_48;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 64);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UcBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.Adobe_Portfolio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datagridPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcBooks";
            this.Size = new System.Drawing.Size(1142, 576);
            this.Load += new System.EventHandler(this.UcBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            this.datagridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel11;
        private Label label5;
        private Label label3;
        private TextBox pagesbox;
        private Label label6;
        private Label label8;
        private TextBox bookIdBox;
        private Label BookId;
        private TextBox langBox;
        private Label label7;
        private TextBox booknameBox;
        private Label label2;
        private Panel searchPanel;
        private Panel panel9;
        private Button btnSearch;
        private TextBox SearchtBox;
        private ComboBox fillterCmb;
        private Panel datagridPanel;
        private Panel panel2;
        private Panel panel3;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private BindingSource bookBindingSource;
        private TextBox copysBox;
        private Label label4;
        private ComboBox authorCmb;
        private ComboBox genreCmb;
        private BindingSource authorBindingSource;
        private TextBox yearBox;
        private DataGridView BooksdataGridView;
        private DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookNumOfPagesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookCopysDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookLanguageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookPublishedYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingsDataGridViewTextBoxColumn;
    }
}
