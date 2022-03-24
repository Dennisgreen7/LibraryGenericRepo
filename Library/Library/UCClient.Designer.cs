namespace Library
{
    partial class UCClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCClient));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.activeUserPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.menuPanel.Controls.Add(this.btnBooks);
            this.menuPanel.Controls.Add(this.btnBorrow);
            this.menuPanel.Controls.Add(this.activeUserPanel);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1108, 82);
            this.menuPanel.TabIndex = 6;
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.Location = new System.Drawing.Point(285, 0);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(288, 82);
            this.btnBooks.TabIndex = 11;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Sienna;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrow.Image = global::Library.Properties.Resources.icons8_ticket_purchase_50;
            this.btnBorrow.Location = new System.Drawing.Point(573, 0);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(288, 82);
            this.btnBorrow.TabIndex = 7;
            this.btnBorrow.Text = "Return";
            this.btnBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // activeUserPanel
            // 
            this.activeUserPanel.BackColor = System.Drawing.Color.Brown;
            this.activeUserPanel.Controls.Add(this.btnLogout);
            this.activeUserPanel.Controls.Add(this.label2);
            this.activeUserPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.activeUserPanel.Location = new System.Drawing.Point(0, 0);
            this.activeUserPanel.Name = "activeUserPanel";
            this.activeUserPanel.Size = new System.Drawing.Size(286, 82);
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
            this.btnLogout.Location = new System.Drawing.Point(0, 40);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(286, 42);
            this.btnLogout.TabIndex = 8;
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
            this.label2.Location = new System.Drawing.Point(69, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Brown;
            this.logoPanel.Controls.Add(this.panel8);
            this.logoPanel.Location = new System.Drawing.Point(861, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(247, 82);
            this.logoPanel.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Location = new System.Drawing.Point(70, 2);
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
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contentPanel.Location = new System.Drawing.Point(0, 82);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1108, 640);
            this.contentPanel.TabIndex = 7;
            // 
            // UCClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "UCClient";
            this.Size = new System.Drawing.Size(1108, 722);
            this.Load += new System.EventHandler(this.UCClient_Load);
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
        private Button btnBorrow;
        private Panel activeUserPanel;
        private Button btnLogout;
        private Label label2;
        private Panel logoPanel;
        private Panel panel8;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel contentPanel;
        private Button btnBooks;
    }
}
