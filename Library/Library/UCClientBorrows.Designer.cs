namespace Library
{
    partial class UCClientBorrows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCClientBorrows));
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchtBox = new System.Windows.Forms.TextBox();
            this.fillterCmb = new System.Windows.Forms.ComboBox();
            this.datagridPanel = new System.Windows.Forms.Panel();
            this.BorrowingsdataGridView = new System.Windows.Forms.DataGridView();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingReturnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingReturnedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borrowingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingBookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.datagridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowingsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).BeginInit();
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
            this.panel2.TabIndex = 32;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.panel9);
            this.searchPanel.Controls.Add(this.fillterCmb);
            this.searchPanel.Location = new System.Drawing.Point(250, 2);
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
            // datagridPanel
            // 
            this.datagridPanel.BackColor = System.Drawing.Color.Transparent;
            this.datagridPanel.Controls.Add(this.BorrowingsdataGridView);
            this.datagridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridPanel.Location = new System.Drawing.Point(0, 52);
            this.datagridPanel.Name = "datagridPanel";
            this.datagridPanel.Size = new System.Drawing.Size(1108, 574);
            this.datagridPanel.TabIndex = 33;
            // 
            // BorrowingsdataGridView
            // 
            this.BorrowingsdataGridView.AllowUserToDeleteRows = false;
            this.BorrowingsdataGridView.AutoGenerateColumns = false;
            this.BorrowingsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowingsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookNameDataGridViewTextBoxColumn,
            this.borrowingDateDataGridViewTextBoxColumn,
            this.borrowingReturnDateDataGridViewTextBoxColumn,
            this.borrowingReturnedDateDataGridViewTextBoxColumn,
            this.Return,
            this.borrowingIdDataGridViewTextBoxColumn,
            this.borrowingBookIdDataGridViewTextBoxColumn,
            this.borrowingUserIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.borrowingBookDataGridViewTextBoxColumn,
            this.borrowingUserDataGridViewTextBoxColumn});
            this.BorrowingsdataGridView.DataSource = this.borrowingBindingSource;
            this.BorrowingsdataGridView.Location = new System.Drawing.Point(165, 6);
            this.BorrowingsdataGridView.Name = "BorrowingsdataGridView";
            this.BorrowingsdataGridView.ReadOnly = true;
            this.BorrowingsdataGridView.RowHeadersWidth = 51;
            this.BorrowingsdataGridView.RowTemplate.Height = 29;
            this.BorrowingsdataGridView.Size = new System.Drawing.Size(806, 551);
            this.BorrowingsdataGridView.TabIndex = 0;
            this.BorrowingsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BorrowingsdataGridView_CellContentClick);
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
            // Return
            // 
            this.Return.HeaderText = "Return Book";
            this.Return.MinimumWidth = 6;
            this.Return.Name = "Return";
            this.Return.ReadOnly = true;
            this.Return.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Return.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Return.Text = "Return";
            this.Return.UseColumnTextForButtonValue = true;
            this.Return.Width = 125;
            // 
            // borrowingIdDataGridViewTextBoxColumn
            // 
            this.borrowingIdDataGridViewTextBoxColumn.DataPropertyName = "BorrowingId";
            this.borrowingIdDataGridViewTextBoxColumn.HeaderText = "BorrowingId";
            this.borrowingIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingIdDataGridViewTextBoxColumn.Name = "borrowingIdDataGridViewTextBoxColumn";
            this.borrowingIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingIdDataGridViewTextBoxColumn.Visible = false;
            this.borrowingIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowingBookIdDataGridViewTextBoxColumn
            // 
            this.borrowingBookIdDataGridViewTextBoxColumn.DataPropertyName = "BorrowingBookId";
            this.borrowingBookIdDataGridViewTextBoxColumn.HeaderText = "BorrowingBookId";
            this.borrowingBookIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingBookIdDataGridViewTextBoxColumn.Name = "borrowingBookIdDataGridViewTextBoxColumn";
            this.borrowingBookIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingBookIdDataGridViewTextBoxColumn.Visible = false;
            this.borrowingBookIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowingUserIdDataGridViewTextBoxColumn
            // 
            this.borrowingUserIdDataGridViewTextBoxColumn.DataPropertyName = "BorrowingUserId";
            this.borrowingUserIdDataGridViewTextBoxColumn.HeaderText = "BorrowingUserId";
            this.borrowingUserIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowingUserIdDataGridViewTextBoxColumn.Name = "borrowingUserIdDataGridViewTextBoxColumn";
            this.borrowingUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingUserIdDataGridViewTextBoxColumn.Visible = false;
            this.borrowingUserIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Visible = false;
            this.userNameDataGridViewTextBoxColumn.Width = 125;
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
            // borrowingBindingSource
            // 
            this.borrowingBindingSource.DataSource = typeof(LibraryEntities.Models.Borrowing);
            // 
            // UCClientBorrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.Adobe_Portfolio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.datagridPanel);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "UCClientBorrows";
            this.Size = new System.Drawing.Size(1108, 626);
            this.Load += new System.EventHandler(this.UCClientBorrows_Load);
            this.panel2.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.datagridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BorrowingsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).EndInit();
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
        private DataGridView BorrowingsdataGridView;
        private BindingSource borrowingBindingSource;
        private DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingReturnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingReturnedDateDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Return;
        private DataGridViewTextBoxColumn borrowingIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingBookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingUserIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingBookDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingUserDataGridViewTextBoxColumn;
    }
}
