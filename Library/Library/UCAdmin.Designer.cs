namespace Library
{
    partial class UCAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAdmin));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.activeUserPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnGeners = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.activeUserPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.activeUserPanel);
            this.menuPanel.Controls.Add(this.btnBooks);
            this.menuPanel.Controls.Add(this.btnUsers);
            this.menuPanel.Controls.Add(this.btnBorrow);
            this.menuPanel.Controls.Add(this.btnAuthors);
            this.menuPanel.Controls.Add(this.btnGeners);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1142, 80);
            this.menuPanel.TabIndex = 2;
            // 
            // activeUserPanel
            // 
            this.activeUserPanel.BackColor = System.Drawing.Color.Brown;
            this.activeUserPanel.Controls.Add(this.btnLogout);
            this.activeUserPanel.Controls.Add(this.label2);
            this.activeUserPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.activeUserPanel.Location = new System.Drawing.Point(0, 0);
            this.activeUserPanel.Name = "activeUserPanel";
            this.activeUserPanel.Size = new System.Drawing.Size(223, 80);
            this.activeUserPanel.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Brown;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(0, 38);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(223, 42);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.Location = new System.Drawing.Point(223, 0);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(160, 80);
            this.btnBooks.TabIndex = 10;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.Location = new System.Drawing.Point(383, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(160, 80);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Sienna;
            this.btnBorrow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrow.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.Image")));
            this.btnBorrow.Location = new System.Drawing.Point(543, 0);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(160, 80);
            this.btnBorrow.TabIndex = 7;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAuthors.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthors.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAuthors.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthors.Image")));
            this.btnAuthors.Location = new System.Drawing.Point(703, 0);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(160, 80);
            this.btnAuthors.TabIndex = 6;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuthors.UseVisualStyleBackColor = false;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnGeners
            // 
            this.btnGeners.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGeners.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGeners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeners.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGeners.Image = ((System.Drawing.Image)(resources.GetObject("btnGeners.Image")));
            this.btnGeners.Location = new System.Drawing.Point(863, 0);
            this.btnGeners.Name = "btnGeners";
            this.btnGeners.Size = new System.Drawing.Size(160, 80);
            this.btnGeners.TabIndex = 5;
            this.btnGeners.Text = "Genres";
            this.btnGeners.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeners.UseVisualStyleBackColor = false;
            this.btnGeners.Click += new System.EventHandler(this.btnGeners_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Brown;
            this.logoPanel.Controls.Add(this.panel8);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoPanel.Location = new System.Drawing.Point(1023, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(119, 80);
            this.logoPanel.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 6);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(119, 74);
            this.panel8.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(2, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dennis\'s Library";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Library.Properties.Resources.icons8_library_60;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentPanel.Location = new System.Drawing.Point(0, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1142, 578);
            this.contentPanel.TabIndex = 3;
            // 
            // UCAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "UCAdmin";
            this.Size = new System.Drawing.Size(1142, 658);
            this.Load += new System.EventHandler(this.UCAdmin_Load);
            this.menuPanel.ResumeLayout(false);
            this.activeUserPanel.ResumeLayout(false);
            this.activeUserPanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Panel activeUserPanel;
        private Button btnBooks;
        private Button btnUsers;
        private Button btnBorrow;
        private Button btnAuthors;
        private Button btnGeners;
        private Panel logoPanel;
        private Panel panel8;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel contentPanel;
        private Button btnLogout;
        private Label label2;
    }
}
