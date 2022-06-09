using Collaboratory.CustomControls;

namespace Collaboratory
{
    partial class UserProfilePage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfilePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizedBtn = new System.Windows.Forms.Button();
            this.repoList = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.useridLb = new System.Windows.Forms.Label();
            this.usernameLb = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.userDP = new Collaboratory.CustomControls.OvalPictureBox();
            this.accsettingsBtn = new System.Windows.Forms.Button();
            this.createRepoBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.MinimizedBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 28);
            this.panel1.TabIndex = 23;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.label4.Location = new System.Drawing.Point(22, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "ollaboratory";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseBtn.BackColor = System.Drawing.Color.LightCoral;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.ForeColor = System.Drawing.Color.LightGreen;
            this.CloseBtn.Location = new System.Drawing.Point(950, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(21, 22);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // MinimizedBtn
            // 
            this.MinimizedBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinimizedBtn.BackColor = System.Drawing.Color.LightGreen;
            this.MinimizedBtn.FlatAppearance.BorderSize = 0;
            this.MinimizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizedBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizedBtn.ForeColor = System.Drawing.Color.LightGreen;
            this.MinimizedBtn.Location = new System.Drawing.Point(923, 4);
            this.MinimizedBtn.Name = "MinimizedBtn";
            this.MinimizedBtn.Size = new System.Drawing.Size(21, 22);
            this.MinimizedBtn.TabIndex = 10;
            this.MinimizedBtn.UseVisualStyleBackColor = false;
            // 
            // repoList
            // 
            this.repoList.AllowUserToAddRows = false;
            this.repoList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(133)))));
            this.repoList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.repoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.repoList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.repoList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(79)))));
            this.repoList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.repoList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(93)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.repoList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.repoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repoList.ColumnHeadersVisible = false;
            this.repoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.repoName});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(93)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.repoList.DefaultCellStyle = dataGridViewCellStyle8;
            this.repoList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.repoList.Location = new System.Drawing.Point(319, 73);
            this.repoList.Name = "repoList";
            this.repoList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(93)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.repoList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.repoList.RowHeadersVisible = false;
            this.repoList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(4, 7, 0, 7);
            this.repoList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.repoList.RowTemplate.Height = 25;
            this.repoList.Size = new System.Drawing.Size(646, 588);
            this.repoList.TabIndex = 25;
            this.repoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.repoList_CellClick);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "idCol";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // repoName
            // 
            this.repoName.HeaderText = "repoName";
            this.repoName.Name = "repoName";
            this.repoName.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(319, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 32);
            this.panel3.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(32, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Your Repositories";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.useridLb);
            this.panel2.Controls.Add(this.usernameLb);
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.userDP);
            this.panel2.Controls.Add(this.accsettingsBtn);
            this.panel2.Controls.Add(this.createRepoBtn);
            this.panel2.Location = new System.Drawing.Point(12, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 620);
            this.panel2.TabIndex = 33;
            // 
            // useridLb
            // 
            this.useridLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.useridLb.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.useridLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.useridLb.Location = new System.Drawing.Point(6, 268);
            this.useridLb.Name = "useridLb";
            this.useridLb.Size = new System.Drawing.Size(292, 21);
            this.useridLb.TabIndex = 38;
            this.useridLb.Text = "onahmarie22";
            this.useridLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLb
            // 
            this.usernameLb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLb.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.usernameLb.Location = new System.Drawing.Point(6, 247);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(292, 21);
            this.usernameLb.TabIndex = 37;
            this.usernameLb.Text = "Onah Marie A. Naputo";
            this.usernameLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutBtn.BackgroundImage")));
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Location = new System.Drawing.Point(6, 7);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(28, 28);
            this.logoutBtn.TabIndex = 36;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // userDP
            // 
            this.userDP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userDP.BackColor = System.Drawing.Color.DarkGray;
            this.userDP.Image = ((System.Drawing.Image)(resources.GetObject("userDP.Image")));
            this.userDP.Location = new System.Drawing.Point(65, 57);
            this.userDP.Name = "userDP";
            this.userDP.Size = new System.Drawing.Size(175, 174);
            this.userDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userDP.TabIndex = 35;
            this.userDP.TabStop = false;
            // 
            // accsettingsBtn
            // 
            this.accsettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accsettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.accsettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.accsettingsBtn.FlatAppearance.BorderSize = 2;
            this.accsettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accsettingsBtn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accsettingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.accsettingsBtn.Location = new System.Drawing.Point(3, 573);
            this.accsettingsBtn.Name = "accsettingsBtn";
            this.accsettingsBtn.Size = new System.Drawing.Size(295, 44);
            this.accsettingsBtn.TabIndex = 34;
            this.accsettingsBtn.Text = "Account Settings";
            this.accsettingsBtn.UseVisualStyleBackColor = false;
            this.accsettingsBtn.Click += new System.EventHandler(this.accsettingsBtn_Click);
            // 
            // createRepoBtn
            // 
            this.createRepoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createRepoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.createRepoBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.createRepoBtn.FlatAppearance.BorderSize = 2;
            this.createRepoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createRepoBtn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createRepoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.createRepoBtn.Location = new System.Drawing.Point(3, 525);
            this.createRepoBtn.Name = "createRepoBtn";
            this.createRepoBtn.Size = new System.Drawing.Size(295, 44);
            this.createRepoBtn.TabIndex = 33;
            this.createRepoBtn.Text = "Create Repository";
            this.createRepoBtn.UseVisualStyleBackColor = false;
            this.createRepoBtn.Click += new System.EventHandler(this.createRepoBtn_Click);
            // 
            // UserProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(977, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.repoList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserProfilePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfilePage";
            this.Load += new System.EventHandler(this.UserProfilePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button CloseBtn;
        private Button MinimizedBtn;
        private DataGridView repoList;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label useridLb;
        private Label usernameLb;
        private Button logoutBtn;
        private OvalPictureBox userDP;
        private Button accsettingsBtn;
        private Button createRepoBtn;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn repoName;
        private Label label4;
        private PictureBox pictureBox2;
    }
}