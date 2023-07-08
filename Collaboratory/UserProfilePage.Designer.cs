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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            CloseBtn = new RoundButton();
            MinimizedBtn = new RoundButton();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            repoList = new DataGridView();
            idCol = new DataGridViewTextBoxColumn();
            repoName = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            useridLb = new Label();
            usernameLb = new Label();
            logoutBtn = new Button();
            userDP = new OvalPictureBox();
            accsettingsBtn = new Button();
            createRepoBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoList).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDP).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(36, 83, 130);
            panel1.Controls.Add(CloseBtn);
            panel1.Controls.Add(MinimizedBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 28);
            panel1.TabIndex = 23;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.BackColor = Color.LightCoral;
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.ForeColor = Color.LightCoral;
            CloseBtn.Location = new Point(952, 4);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(21, 22);
            CloseBtn.TabIndex = 49;
            CloseBtn.Text = "roundButton2";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // MinimizedBtn
            // 
            MinimizedBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizedBtn.BackColor = Color.LightGreen;
            MinimizedBtn.FlatAppearance.BorderSize = 0;
            MinimizedBtn.FlatStyle = FlatStyle.Flat;
            MinimizedBtn.ForeColor = Color.LightGreen;
            MinimizedBtn.Location = new Point(925, 4);
            MinimizedBtn.Name = "MinimizedBtn";
            MinimizedBtn.Size = new Size(21, 22);
            MinimizedBtn.TabIndex = 48;
            MinimizedBtn.Text = "roundButton1";
            MinimizedBtn.UseVisualStyleBackColor = false;
            MinimizedBtn.Click += MinimizedBtn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 235, 237);
            label4.Location = new Point(22, 6);
            label4.Name = "label4";
            label4.Size = new Size(105, 18);
            label4.TabIndex = 18;
            label4.Text = "ollaboratory";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // repoList
            // 
            repoList.AllowUserToAddRows = false;
            repoList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(21, 77, 133);
            repoList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            repoList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            repoList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            repoList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            repoList.BackgroundColor = Color.FromArgb(37, 32, 79);
            repoList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            repoList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(43, 93, 107);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            repoList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            repoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            repoList.ColumnHeadersVisible = false;
            repoList.Columns.AddRange(new DataGridViewColumn[] { idCol, repoName });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(43, 93, 107);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            repoList.DefaultCellStyle = dataGridViewCellStyle8;
            repoList.GridColor = Color.FromArgb(36, 83, 130);
            repoList.Location = new Point(319, 73);
            repoList.Name = "repoList";
            repoList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(43, 93, 107);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            repoList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            repoList.RowHeadersVisible = false;
            repoList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(36, 83, 130);
            dataGridViewCellStyle10.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(224, 235, 237);
            dataGridViewCellStyle10.Padding = new Padding(4, 7, 0, 7);
            repoList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            repoList.RowTemplate.Height = 25;
            repoList.Size = new Size(646, 588);
            repoList.TabIndex = 25;
            repoList.CellClick += repoList_CellClick;
            // 
            // idCol
            // 
            idCol.HeaderText = "idCol";
            idCol.Name = "idCol";
            idCol.ReadOnly = true;
            idCol.Visible = false;
            // 
            // repoName
            // 
            repoName.HeaderText = "repoName";
            repoName.Name = "repoName";
            repoName.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(36, 83, 130);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(319, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(646, 32);
            panel3.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 235, 237);
            label1.Location = new Point(32, 7);
            label1.Name = "label1";
            label1.Size = new Size(150, 18);
            label1.TabIndex = 14;
            label1.Text = "Your Repositories";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(21, 77, 133);
            panel2.Controls.Add(useridLb);
            panel2.Controls.Add(usernameLb);
            panel2.Controls.Add(logoutBtn);
            panel2.Controls.Add(userDP);
            panel2.Controls.Add(accsettingsBtn);
            panel2.Controls.Add(createRepoBtn);
            panel2.Location = new Point(12, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 620);
            panel2.TabIndex = 33;
            // 
            // useridLb
            // 
            useridLb.Anchor = AnchorStyles.Top;
            useridLb.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            useridLb.ForeColor = Color.FromArgb(224, 235, 237);
            useridLb.Location = new Point(6, 268);
            useridLb.Name = "useridLb";
            useridLb.Size = new Size(292, 21);
            useridLb.TabIndex = 38;
            useridLb.Text = "onahmarie22";
            useridLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLb
            // 
            usernameLb.Anchor = AnchorStyles.Top;
            usernameLb.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLb.ForeColor = Color.FromArgb(224, 235, 237);
            usernameLb.Location = new Point(6, 247);
            usernameLb.Name = "usernameLb";
            usernameLb.Size = new Size(292, 21);
            usernameLb.TabIndex = 37;
            usernameLb.Text = "Onah Marie A. Naputo";
            usernameLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Transparent;
            logoutBtn.BackgroundImage = (Image)resources.GetObject("logoutBtn.BackgroundImage");
            logoutBtn.BackgroundImageLayout = ImageLayout.Stretch;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Location = new Point(6, 7);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(28, 28);
            logoutBtn.TabIndex = 36;
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // userDP
            // 
            userDP.Anchor = AnchorStyles.Top;
            userDP.BackColor = Color.DarkGray;
            userDP.Image = (Image)resources.GetObject("userDP.Image");
            userDP.Location = new Point(65, 57);
            userDP.Name = "userDP";
            userDP.Size = new Size(175, 174);
            userDP.SizeMode = PictureBoxSizeMode.StretchImage;
            userDP.TabIndex = 35;
            userDP.TabStop = false;
            // 
            // accsettingsBtn
            // 
            accsettingsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            accsettingsBtn.BackColor = Color.FromArgb(36, 83, 130);
            accsettingsBtn.FlatAppearance.BorderColor = Color.FromArgb(23, 20, 51);
            accsettingsBtn.FlatAppearance.BorderSize = 2;
            accsettingsBtn.FlatStyle = FlatStyle.Flat;
            accsettingsBtn.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            accsettingsBtn.ForeColor = Color.FromArgb(224, 235, 237);
            accsettingsBtn.Location = new Point(3, 573);
            accsettingsBtn.Name = "accsettingsBtn";
            accsettingsBtn.Size = new Size(295, 44);
            accsettingsBtn.TabIndex = 34;
            accsettingsBtn.Text = "Account Settings";
            accsettingsBtn.UseVisualStyleBackColor = false;
            accsettingsBtn.Click += accsettingsBtn_Click;
            // 
            // createRepoBtn
            // 
            createRepoBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            createRepoBtn.BackColor = Color.FromArgb(36, 83, 130);
            createRepoBtn.FlatAppearance.BorderColor = Color.FromArgb(23, 20, 51);
            createRepoBtn.FlatAppearance.BorderSize = 2;
            createRepoBtn.FlatStyle = FlatStyle.Flat;
            createRepoBtn.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createRepoBtn.ForeColor = Color.FromArgb(224, 235, 237);
            createRepoBtn.Location = new Point(3, 525);
            createRepoBtn.Name = "createRepoBtn";
            createRepoBtn.Size = new Size(295, 44);
            createRepoBtn.TabIndex = 33;
            createRepoBtn.Text = "Create Repository";
            createRepoBtn.UseVisualStyleBackColor = false;
            createRepoBtn.Click += createRepoBtn_Click;
            // 
            // UserProfilePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 20, 51);
            ClientSize = new Size(977, 673);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(repoList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UserProfilePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserProfilePage";
            Load += UserProfilePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userDP).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
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
        private RoundButton CloseBtn;
        private RoundButton MinimizedBtn;
    }
}