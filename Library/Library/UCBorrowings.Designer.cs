namespace Library
{
    partial class UCBorrowings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBorrowings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.bookCmb = new System.Windows.Forms.ComboBox();
            this.User = new System.Windows.Forms.Label();
            this.userCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.borrowidBox = new System.Windows.Forms.TextBox();
            this.BookId = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchtBox = new System.Windows.Forms.TextBox();
            this.fillterCmb = new System.Windows.Forms.ComboBox();
            this.borrowingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datagridPanel = new System.Windows.Forms.Panel();
            this.BorrowingsdataGridView = new System.Windows.Forms.DataGridView();
            this.borrowingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingBookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingReturnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingReturnedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).BeginInit();
            this.datagridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowingsdataGridView)).BeginInit();
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
            this.panel1.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Firebrick;
            this.panel11.Controls.Add(this.bookCmb);
            this.panel11.Controls.Add(this.User);
            this.panel11.Controls.Add(this.userCmb);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.dateTimePicker2);
            this.panel11.Controls.Add(this.borrowidBox);
            this.panel11.Controls.Add(this.BookId);
            this.panel11.ForeColor = System.Drawing.Color.Snow;
            this.panel11.Location = new System.Drawing.Point(282, 42);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(595, 91);
            this.panel11.TabIndex = 6;
            // 
            // bookCmb
            // 
            this.bookCmb.FormattingEnabled = true;
            this.bookCmb.Location = new System.Drawing.Point(379, 48);
            this.bookCmb.Name = "bookCmb";
            this.bookCmb.Size = new System.Drawing.Size(195, 28);
            this.bookCmb.TabIndex = 32;
            this.bookCmb.SelectionChangeCommitted += new System.EventHandler(this.bookCmb_SelectionChangeCommitted);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(20, 51);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(38, 20);
            this.User.TabIndex = 31;
            this.User.Text = "User";
            // 
            // userCmb
            // 
            this.userCmb.FormattingEnabled = true;
            this.userCmb.Location = new System.Drawing.Point(77, 48);
            this.userCmb.Name = "userCmb";
            this.userCmb.Size = new System.Drawing.Size(189, 28);
            this.userCmb.TabIndex = 30;
            this.userCmb.SelectionChangeCommitted += new System.EventHandler(this.userCmb_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Return Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(379, 13);
            this.dateTimePicker2.MaxDate = new System.DateTime(2099, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(195, 27);
            this.dateTimePicker2.TabIndex = 26;
            this.dateTimePicker2.Value = new System.DateTime(2022, 2, 2, 0, 0, 0, 0);
            // 
            // borrowidBox
            // 
            this.borrowidBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowidBox.Location = new System.Drawing.Point(77, 8);
            this.borrowidBox.Margin = new System.Windows.Forms.Padding(2);
            this.borrowidBox.Name = "borrowidBox";
            this.borrowidBox.Size = new System.Drawing.Size(189, 32);
            this.borrowidBox.TabIndex = 23;
            // 
            // BookId
            // 
            this.BookId.AutoSize = true;
            this.BookId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BookId.Location = new System.Drawing.Point(36, 15);
            this.BookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookId.Name = "BookId";
            this.BookId.Size = new System.Drawing.Size(22, 20);
            this.BookId.TabIndex = 22;
            this.BookId.Text = "Id";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.panel9);
            this.searchPanel.Controls.Add(this.fillterCmb);
            this.searchPanel.Location = new System.Drawing.Point(262, 2);
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
            "User",
            "Book",
            "Active",
            "Returned",
            "Borrow Date",
            "Return Date"});
            this.fillterCmb.Location = new System.Drawing.Point(2, 1);
            this.fillterCmb.Margin = new System.Windows.Forms.Padding(2);
            this.fillterCmb.Name = "fillterCmb";
            this.fillterCmb.Size = new System.Drawing.Size(201, 33);
            this.fillterCmb.TabIndex = 0;
            this.fillterCmb.Text = "Fillter By";
            // 
            // borrowingBindingSource
            // 
            this.borrowingBindingSource.DataSource = typeof(LibraryEntities.Models.Borrowing);
            // 
            // datagridPanel
            // 
            this.datagridPanel.BackColor = System.Drawing.Color.Transparent;
            this.datagridPanel.Controls.Add(this.BorrowingsdataGridView);
            this.datagridPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagridPanel.Location = new System.Drawing.Point(0, 138);
            this.datagridPanel.Name = "datagridPanel";
            this.datagridPanel.Size = new System.Drawing.Size(1142, 475);
            this.datagridPanel.TabIndex = 5;
            // 
            // BorrowingsdataGridView
            // 
            this.BorrowingsdataGridView.AllowUserToDeleteRows = false;
            this.BorrowingsdataGridView.AutoGenerateColumns = false;
            this.BorrowingsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowingsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowingIdDataGridViewTextBoxColumn,
            this.borrowingBookIdDataGridViewTextBoxColumn,
            this.borrowingUserIdDataGridViewTextBoxColumn,
            this.borrowingDateDataGridViewTextBoxColumn,
            this.borrowingReturnDateDataGridViewTextBoxColumn,
            this.borrowingReturnedDateDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.borrowingBookDataGridViewTextBoxColumn,
            this.borrowingUserDataGridViewTextBoxColumn});
            this.BorrowingsdataGridView.DataSource = this.borrowingBindingSource;
            this.BorrowingsdataGridView.Location = new System.Drawing.Point(44, 0);
            this.BorrowingsdataGridView.Name = "BorrowingsdataGridView";
            this.BorrowingsdataGridView.ReadOnly = true;
            this.BorrowingsdataGridView.RowHeadersWidth = 51;
            this.BorrowingsdataGridView.RowTemplate.Height = 29;
            this.BorrowingsdataGridView.Size = new System.Drawing.Size(1052, 346);
            this.BorrowingsdataGridView.TabIndex = 0;
            this.BorrowingsdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BorrowingsdataGridView_CellClick);
            // 
            // borrowingIdDataGridViewTextBoxColumn
            // 
            this.borrowingIdDataGridViewTextBoxColumn.DataPropertyName = "BorrowingId";
            this.borrowingIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.borrowingIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingIdDataGridViewTextBoxColumn.Name = "borrowingIdDataGridViewTextBoxColumn";
            this.borrowingIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // borrowingBookIdDataGridViewTextBoxColumn
            // 
            this.borrowingBookIdDataGridViewTextBoxColumn.DataPropertyName = "BorrowingBookId";
            this.borrowingBookIdDataGridViewTextBoxColumn.HeaderText = "Book Id";
            this.borrowingBookIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingBookIdDataGridViewTextBoxColumn.Name = "borrowingBookIdDataGridViewTextBoxColumn";
            this.borrowingBookIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingBookIdDataGridViewTextBoxColumn.Visible = false;
            this.borrowingBookIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowingUserIdDataGridViewTextBoxColumn
            // 
            this.borrowingUserIdDataGridViewTextBoxColumn.DataPropertyName = "BorrowingUserId";
            this.borrowingUserIdDataGridViewTextBoxColumn.HeaderText = "User Id";
            this.borrowingUserIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingUserIdDataGridViewTextBoxColumn.Name = "borrowingUserIdDataGridViewTextBoxColumn";
            this.borrowingUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingUserIdDataGridViewTextBoxColumn.Visible = false;
            this.borrowingUserIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowingDateDataGridViewTextBoxColumn
            // 
            this.borrowingDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowingDate";
            this.borrowingDateDataGridViewTextBoxColumn.HeaderText = "Borrow Date";
            this.borrowingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingDateDataGridViewTextBoxColumn.Name = "borrowingDateDataGridViewTextBoxColumn";
            this.borrowingDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // borrowingReturnDateDataGridViewTextBoxColumn
            // 
            this.borrowingReturnDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowingReturnDate";
            this.borrowingReturnDateDataGridViewTextBoxColumn.HeaderText = "Return Date";
            this.borrowingReturnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingReturnDateDataGridViewTextBoxColumn.Name = "borrowingReturnDateDataGridViewTextBoxColumn";
            this.borrowingReturnDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingReturnDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // borrowingReturnedDateDataGridViewTextBoxColumn
            // 
            this.borrowingReturnedDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowingReturnedDate";
            this.borrowingReturnedDateDataGridViewTextBoxColumn.HeaderText = "Returned Date";
            this.borrowingReturnedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingReturnedDateDataGridViewTextBoxColumn.Name = "borrowingReturnedDateDataGridViewTextBoxColumn";
            this.borrowingReturnedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingReturnedDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book ";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // borrowingBookDataGridViewTextBoxColumn
            // 
            this.borrowingBookDataGridViewTextBoxColumn.DataPropertyName = "BorrowingBook";
            this.borrowingBookDataGridViewTextBoxColumn.HeaderText = "BorrowingBook";
            this.borrowingBookDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingBookDataGridViewTextBoxColumn.Name = "borrowingBookDataGridViewTextBoxColumn";
            this.borrowingBookDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingBookDataGridViewTextBoxColumn.Visible = false;
            this.borrowingBookDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowingUserDataGridViewTextBoxColumn
            // 
            this.borrowingUserDataGridViewTextBoxColumn.DataPropertyName = "BorrowingUser";
            this.borrowingUserDataGridViewTextBoxColumn.HeaderText = "BorrowingUser";
            this.borrowingUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingUserDataGridViewTextBoxColumn.Name = "borrowingUserDataGridViewTextBoxColumn";
            this.borrowingUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingUserDataGridViewTextBoxColumn.Visible = false;
            this.borrowingUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 502);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 74);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Returnbtn);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(67, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 64);
            this.panel3.TabIndex = 0;
            // 
            // Returnbtn
            // 
            this.Returnbtn.BackColor = System.Drawing.Color.Sienna;
            this.Returnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Returnbtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Returnbtn.Image = global::Library.Properties.Resources.icons8_ticket_purchase_50;
            this.Returnbtn.Location = new System.Drawing.Point(555, 0);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(180, 64);
            this.Returnbtn.TabIndex = 12;
            this.Returnbtn.Text = "Return";
            this.Returnbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Returnbtn.UseVisualStyleBackColor = false;
            this.Returnbtn.Click += new System.EventHandler(this.Returnbtn_Click);
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
            this.btnSave.Location = new System.Drawing.Point(814, 0);
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
            // UCBorrowings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.Adobe_Portfolio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datagridPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UCBorrowings";
            this.Size = new System.Drawing.Size(1142, 576);
            this.Load += new System.EventHandler(this.UCBorrowings_Load);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).EndInit();
            this.datagridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BorrowingsdataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel11;
        private TextBox borrowidBox;
        private Label BookId;
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
        private DataGridView BorrowingsdataGridView;
        private BindingSource borrowingBindingSource;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private ComboBox bookCmb;
        private Label User;
        private ComboBox userCmb;
        private Label label4;
        private Button Returnbtn;
        private DataGridViewTextBoxColumn borrowingIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingBookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingUserIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingReturnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingReturnedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingBookDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingUserDataGridViewTextBoxColumn;
    }
}
