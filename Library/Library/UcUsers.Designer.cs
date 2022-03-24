namespace Library
{
    partial class UcUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcUsers));
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.roleCmb = new System.Windows.Forms.ComboBox();
            this.unameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tzBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.enailBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.BookId = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchtBox = new System.Windows.Forms.TextBox();
            this.fillterCmb = new System.Windows.Forms.ComboBox();
            this.datagridPanel = new System.Windows.Forms.Panel();
            this.UserdataGridView = new System.Windows.Forms.DataGridView();
            this.usersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTzIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.datagridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(LibraryEntities.Models.User);
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
            this.panel1.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Firebrick;
            this.panel11.Controls.Add(this.roleCmb);
            this.panel11.Controls.Add(this.unameBox);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.tzBox);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.addressBox);
            this.panel11.Controls.Add(this.passwordbox);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.phoneBox);
            this.panel11.Controls.Add(this.Phone);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.enailBox);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.userIdBox);
            this.panel11.Controls.Add(this.BookId);
            this.panel11.Controls.Add(this.lnameBox);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.fnameBox);
            this.panel11.Controls.Add(this.label2);
            this.panel11.ForeColor = System.Drawing.Color.Snow;
            this.panel11.Location = new System.Drawing.Point(11, 42);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1109, 91);
            this.panel11.TabIndex = 6;
            // 
            // roleCmb
            // 
            this.roleCmb.FormattingEnabled = true;
            this.roleCmb.Items.AddRange(new object[] {
            "Admin",
            "Client"});
            this.roleCmb.Location = new System.Drawing.Point(46, 52);
            this.roleCmb.Name = "roleCmb";
            this.roleCmb.Size = new System.Drawing.Size(100, 28);
            this.roleCmb.TabIndex = 7;
            // 
            // unameBox
            // 
            this.unameBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unameBox.Location = new System.Drawing.Point(715, 5);
            this.unameBox.Margin = new System.Windows.Forms.Padding(2);
            this.unameBox.Name = "unameBox";
            this.unameBox.Size = new System.Drawing.Size(179, 32);
            this.unameBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(633, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "UserName";
            // 
            // tzBox
            // 
            this.tzBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tzBox.Location = new System.Drawing.Point(653, 49);
            this.tzBox.Margin = new System.Windows.Forms.Padding(2);
            this.tzBox.Name = "tzBox";
            this.tzBox.Size = new System.Drawing.Size(150, 32);
            this.tzBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(905, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Password";
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressBox.Location = new System.Drawing.Point(872, 48);
            this.addressBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(233, 32);
            this.addressBox.TabIndex = 33;
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordbox.Location = new System.Drawing.Point(978, 10);
            this.passwordbox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(127, 32);
            this.passwordbox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(807, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Adsrees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(621, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Tz";
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneBox.Location = new System.Drawing.Point(458, 52);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(148, 32);
            this.phoneBox.TabIndex = 29;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Phone.Location = new System.Drawing.Point(394, 56);
            this.Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(50, 20);
            this.Phone.TabIndex = 28;
            this.Phone.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(2, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Role";
            // 
            // enailBox
            // 
            this.enailBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enailBox.Location = new System.Drawing.Point(213, 52);
            this.enailBox.Margin = new System.Windows.Forms.Padding(2);
            this.enailBox.Name = "enailBox";
            this.enailBox.Size = new System.Drawing.Size(158, 32);
            this.enailBox.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(152, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Email";
            // 
            // userIdBox
            // 
            this.userIdBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userIdBox.Location = new System.Drawing.Point(46, 7);
            this.userIdBox.Margin = new System.Windows.Forms.Padding(2);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(75, 32);
            this.userIdBox.TabIndex = 23;
            // 
            // BookId
            // 
            this.BookId.AutoSize = true;
            this.BookId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BookId.Location = new System.Drawing.Point(8, 12);
            this.BookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookId.Name = "BookId";
            this.BookId.Size = new System.Drawing.Size(22, 20);
            this.BookId.TabIndex = 22;
            this.BookId.Text = "Id";
            // 
            // lnameBox
            // 
            this.lnameBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnameBox.Location = new System.Drawing.Point(475, 5);
            this.lnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(148, 32);
            this.lnameBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(392, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Last Name";
            // 
            // fnameBox
            // 
            this.fnameBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fnameBox.Location = new System.Drawing.Point(213, 7);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(158, 32);
            this.fnameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(125, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name ";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.panel9);
            this.searchPanel.Controls.Add(this.fillterCmb);
            this.searchPanel.Location = new System.Drawing.Point(284, 3);
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
            "First Name",
            "Last Name",
            "Username",
            "Role",
            "Tz"});
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
            this.datagridPanel.Controls.Add(this.UserdataGridView);
            this.datagridPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagridPanel.Location = new System.Drawing.Point(0, 138);
            this.datagridPanel.Name = "datagridPanel";
            this.datagridPanel.Size = new System.Drawing.Size(1142, 366);
            this.datagridPanel.TabIndex = 3;
            // 
            // UserdataGridView
            // 
            this.UserdataGridView.AllowUserToDeleteRows = false;
            this.UserdataGridView.AutoGenerateColumns = false;
            this.UserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersIdDataGridViewTextBoxColumn,
            this.usersFirstNameDataGridViewTextBoxColumn,
            this.usersLastNameDataGridViewTextBoxColumn,
            this.usersUserNameDataGridViewTextBoxColumn,
            this.usersPasswordDataGridViewTextBoxColumn,
            this.usersPhoneDataGridViewTextBoxColumn,
            this.usersEmailDataGridViewTextBoxColumn,
            this.usersRoleDataGridViewTextBoxColumn,
            this.userTzIdDataGridViewTextBoxColumn,
            this.usersAddressDataGridViewTextBoxColumn,
            this.borrowingsDataGridViewTextBoxColumn});
            this.UserdataGridView.DataSource = this.userBindingSource;
            this.UserdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.UserdataGridView.Location = new System.Drawing.Point(11, 3);
            this.UserdataGridView.Name = "UserdataGridView";
            this.UserdataGridView.ReadOnly = true;
            this.UserdataGridView.RowHeadersWidth = 51;
            this.UserdataGridView.RowTemplate.Height = 29;
            this.UserdataGridView.Size = new System.Drawing.Size(1109, 334);
            this.UserdataGridView.TabIndex = 0;
            this.UserdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserdataGridView_CellClick);
            // 
            // usersIdDataGridViewTextBoxColumn
            // 
            this.usersIdDataGridViewTextBoxColumn.DataPropertyName = "UsersId";
            this.usersIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.usersIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersIdDataGridViewTextBoxColumn.Name = "usersIdDataGridViewTextBoxColumn";
            this.usersIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // usersFirstNameDataGridViewTextBoxColumn
            // 
            this.usersFirstNameDataGridViewTextBoxColumn.DataPropertyName = "UsersFirstName";
            this.usersFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.usersFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersFirstNameDataGridViewTextBoxColumn.Name = "usersFirstNameDataGridViewTextBoxColumn";
            this.usersFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersFirstNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // usersLastNameDataGridViewTextBoxColumn
            // 
            this.usersLastNameDataGridViewTextBoxColumn.DataPropertyName = "UsersLastName";
            this.usersLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.usersLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersLastNameDataGridViewTextBoxColumn.Name = "usersLastNameDataGridViewTextBoxColumn";
            this.usersLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersLastNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // usersUserNameDataGridViewTextBoxColumn
            // 
            this.usersUserNameDataGridViewTextBoxColumn.DataPropertyName = "UsersUserName";
            this.usersUserNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.usersUserNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersUserNameDataGridViewTextBoxColumn.Name = "usersUserNameDataGridViewTextBoxColumn";
            this.usersUserNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersUserNameDataGridViewTextBoxColumn.Width = 160;
            // 
            // usersPasswordDataGridViewTextBoxColumn
            // 
            this.usersPasswordDataGridViewTextBoxColumn.DataPropertyName = "UsersPassword";
            this.usersPasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.usersPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersPasswordDataGridViewTextBoxColumn.Name = "usersPasswordDataGridViewTextBoxColumn";
            this.usersPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersPasswordDataGridViewTextBoxColumn.Width = 150;
            // 
            // usersPhoneDataGridViewTextBoxColumn
            // 
            this.usersPhoneDataGridViewTextBoxColumn.DataPropertyName = "UsersPhone";
            this.usersPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.usersPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersPhoneDataGridViewTextBoxColumn.Name = "usersPhoneDataGridViewTextBoxColumn";
            this.usersPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // usersEmailDataGridViewTextBoxColumn
            // 
            this.usersEmailDataGridViewTextBoxColumn.DataPropertyName = "UsersEmail";
            this.usersEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.usersEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersEmailDataGridViewTextBoxColumn.Name = "usersEmailDataGridViewTextBoxColumn";
            this.usersEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // usersRoleDataGridViewTextBoxColumn
            // 
            this.usersRoleDataGridViewTextBoxColumn.DataPropertyName = "UsersRole";
            this.usersRoleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.usersRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersRoleDataGridViewTextBoxColumn.Name = "usersRoleDataGridViewTextBoxColumn";
            this.usersRoleDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersRoleDataGridViewTextBoxColumn.Width = 80;
            // 
            // userTzIdDataGridViewTextBoxColumn
            // 
            this.userTzIdDataGridViewTextBoxColumn.DataPropertyName = "UserTzId";
            this.userTzIdDataGridViewTextBoxColumn.HeaderText = "Tz";
            this.userTzIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userTzIdDataGridViewTextBoxColumn.Name = "userTzIdDataGridViewTextBoxColumn";
            this.userTzIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTzIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // usersAddressDataGridViewTextBoxColumn
            // 
            this.usersAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.usersAddressDataGridViewTextBoxColumn.DataPropertyName = "UsersAddress";
            this.usersAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.usersAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersAddressDataGridViewTextBoxColumn.Name = "usersAddressDataGridViewTextBoxColumn";
            this.usersAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersAddressDataGridViewTextBoxColumn.Width = 204;
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
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(199, 0);
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
            // UcUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.Adobe_Portfolio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.datagridPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UcUsers";
            this.Size = new System.Drawing.Size(1142, 576);
            this.Load += new System.EventHandler(this.UcUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.datagridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource userBindingSource;
        private Panel panel1;
        private Panel datagridPanel;
        private DataGridView UserdataGridView;
        private Panel searchPanel;
        private Panel panel9;
        private Button btnSearch;
        private TextBox SearchtBox;
        private ComboBox fillterCmb;
        private Panel panel11;
        private TextBox unameBox;
        private Label label5;
        private TextBox tzBox;
        private TextBox addressBox;
        private Label label4;
        private Label label9;
        private TextBox passwordbox;
        private Label label3;
        private TextBox phoneBox;
        private Label Phone;
        private Label label6;
        private TextBox enailBox;
        private Label label8;
        private TextBox userIdBox;
        private Label BookId;
        private TextBox lnameBox;
        private Label label7;
        private TextBox fnameBox;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private ComboBox roleCmb;
        private DataGridViewTextBoxColumn usersIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usersFirstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usersLastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usersUserNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usersPasswordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usersPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usersEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usersRoleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userTzIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usersAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowingsDataGridViewTextBoxColumn;
    }
}
