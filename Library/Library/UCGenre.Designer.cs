namespace Library
{
    partial class UCGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGenre));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.genreIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchtBox = new System.Windows.Forms.TextBox();
            this.fillterCmb = new System.Windows.Forms.ComboBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datagridPanel = new System.Windows.Forms.Panel();
            this.GenredataGridView = new System.Windows.Forms.DataGridView();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            this.datagridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenredataGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1142, 94);
            this.panel1.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Firebrick;
            this.panel11.Controls.Add(this.genreBox);
            this.panel11.Controls.Add(this.genreIdBox);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.label3);
            this.panel11.ForeColor = System.Drawing.Color.Snow;
            this.panel11.Location = new System.Drawing.Point(372, 43);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(419, 50);
            this.panel11.TabIndex = 6;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(258, 11);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(127, 27);
            this.genreBox.TabIndex = 34;
            // 
            // genreIdBox
            // 
            this.genreIdBox.Location = new System.Drawing.Point(69, 11);
            this.genreIdBox.Name = "genreIdBox";
            this.genreIdBox.Size = new System.Drawing.Size(98, 27);
            this.genreIdBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(37, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(191, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Genre";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.panel9);
            this.searchPanel.Controls.Add(this.fillterCmb);
            this.searchPanel.Location = new System.Drawing.Point(298, 3);
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
            "Name"});
            this.fillterCmb.Location = new System.Drawing.Point(2, 1);
            this.fillterCmb.Margin = new System.Windows.Forms.Padding(2);
            this.fillterCmb.Name = "fillterCmb";
            this.fillterCmb.Size = new System.Drawing.Size(201, 33);
            this.fillterCmb.TabIndex = 0;
            this.fillterCmb.Text = "Fillter By";
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(LibraryEntities.Models.Genre);
            // 
            // datagridPanel
            // 
            this.datagridPanel.BackColor = System.Drawing.Color.Transparent;
            this.datagridPanel.Controls.Add(this.GenredataGridView);
            this.datagridPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagridPanel.Location = new System.Drawing.Point(0, 94);
            this.datagridPanel.Name = "datagridPanel";
            this.datagridPanel.Size = new System.Drawing.Size(1142, 405);
            this.datagridPanel.TabIndex = 5;
            // 
            // GenredataGridView
            // 
            this.GenredataGridView.AllowUserToDeleteRows = false;
            this.GenredataGridView.AutoGenerateColumns = false;
            this.GenredataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GenredataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreIdDataGridViewTextBoxColumn,
            this.genreNameDataGridViewTextBoxColumn,
            this.booksDataGridViewTextBoxColumn});
            this.GenredataGridView.DataSource = this.genreBindingSource;
            this.GenredataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GenredataGridView.Location = new System.Drawing.Point(409, 0);
            this.GenredataGridView.Name = "GenredataGridView";
            this.GenredataGridView.ReadOnly = true;
            this.GenredataGridView.RowHeadersWidth = 51;
            this.GenredataGridView.RowTemplate.Height = 29;
            this.GenredataGridView.Size = new System.Drawing.Size(347, 392);
            this.GenredataGridView.TabIndex = 0;
            this.GenredataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GenredataGridView_CellClick);
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.genreIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            this.genreIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreNameDataGridViewTextBoxColumn
            // 
            this.genreNameDataGridViewTextBoxColumn.DataPropertyName = "GenreName";
            this.genreNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.genreNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreNameDataGridViewTextBoxColumn.Name = "genreNameDataGridViewTextBoxColumn";
            this.genreNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // booksDataGridViewTextBoxColumn
            // 
            this.booksDataGridViewTextBoxColumn.DataPropertyName = "Books";
            this.booksDataGridViewTextBoxColumn.HeaderText = "Books";
            this.booksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.booksDataGridViewTextBoxColumn.Name = "booksDataGridViewTextBoxColumn";
            this.booksDataGridViewTextBoxColumn.ReadOnly = true;
            this.booksDataGridViewTextBoxColumn.Visible = false;
            this.booksDataGridViewTextBoxColumn.Width = 125;
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
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(198, 3);
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
            // UCGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.Adobe_Portfolio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datagridPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UCGenre";
            this.Size = new System.Drawing.Size(1142, 576);
            this.Load += new System.EventHandler(this.UCGenre_Load);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.datagridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GenredataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel11;
        private Label label3;
        private Panel searchPanel;
        private Panel panel9;
        private Button btnSearch;
        private TextBox SearchtBox;
        private ComboBox fillterCmb;
        private Panel datagridPanel;
        private DataGridView GenredataGridView;
        private Panel panel2;
        private Panel panel3;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private BindingSource genreBindingSource;
        private Label label2;
        private TextBox genreBox;
        private TextBox genreIdBox;
        private DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn booksDataGridViewTextBoxColumn;
    }
}
