namespace Collaboratory
{
    partial class AccountSettingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSettingPage));
            panel1 = new Panel();
            CloseBtn = new CustomControls.RoundButton();
            MinimizedBtn = new CustomControls.RoundButton();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            backBtn = new Button();
            changepicBtn = new Button();
            editprofileBtn = new Button();
            deleteaccBtn = new Button();
            userDP = new CustomControls.OvalPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDP).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 83, 130);
            panel1.Controls.Add(CloseBtn);
            panel1.Controls.Add(MinimizedBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 28);
            panel1.TabIndex = 10;
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
            CloseBtn.Location = new Point(680, 4);
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
            MinimizedBtn.Location = new Point(653, 4);
            MinimizedBtn.Name = "MinimizedBtn";
            MinimizedBtn.Size = new Size(21, 22);
            MinimizedBtn.TabIndex = 48;
            MinimizedBtn.Text = "roundButton1";
            MinimizedBtn.UseVisualStyleBackColor = false;
            MinimizedBtn.Click += MinimizedBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 235, 237);
            label1.Location = new Point(22, 5);
            label1.Name = "label1";
            label1.Size = new Size(105, 18);
            label1.TabIndex = 18;
            label1.Text = "ollaboratory";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 83, 130);
            panel2.Controls.Add(backBtn);
            panel2.Controls.Add(changepicBtn);
            panel2.Controls.Add(editprofileBtn);
            panel2.Controls.Add(deleteaccBtn);
            panel2.Controls.Add(userDP);
            panel2.Location = new Point(146, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(409, 419);
            panel2.TabIndex = 11;
            // 
            // backBtn
            // 
            backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.ForeColor = Color.Transparent;
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(11, 13);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(28, 26);
            backBtn.TabIndex = 40;
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // changepicBtn
            // 
            changepicBtn.BackColor = Color.FromArgb(36, 83, 130);
            changepicBtn.FlatAppearance.BorderColor = Color.FromArgb(23, 20, 51);
            changepicBtn.FlatAppearance.BorderSize = 0;
            changepicBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            changepicBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            changepicBtn.FlatStyle = FlatStyle.Flat;
            changepicBtn.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            changepicBtn.ForeColor = Color.FromArgb(224, 235, 237);
            changepicBtn.Location = new Point(104, 191);
            changepicBtn.Name = "changepicBtn";
            changepicBtn.Size = new Size(208, 44);
            changepicBtn.TabIndex = 39;
            changepicBtn.Text = "Change Photo";
            changepicBtn.UseVisualStyleBackColor = false;
            changepicBtn.Click += changepicBtn_Click;
            // 
            // editprofileBtn
            // 
            editprofileBtn.BackColor = Color.FromArgb(36, 83, 130);
            editprofileBtn.FlatAppearance.BorderColor = Color.FromArgb(23, 20, 51);
            editprofileBtn.FlatAppearance.BorderSize = 2;
            editprofileBtn.FlatStyle = FlatStyle.Flat;
            editprofileBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            editprofileBtn.ForeColor = Color.FromArgb(224, 235, 237);
            editprofileBtn.Location = new Point(99, 280);
            editprofileBtn.Name = "editprofileBtn";
            editprofileBtn.Size = new Size(213, 31);
            editprofileBtn.TabIndex = 38;
            editprofileBtn.Text = "Edit Profile";
            editprofileBtn.UseVisualStyleBackColor = false;
            editprofileBtn.Click += editprofileBtn_Click;
            // 
            // deleteaccBtn
            // 
            deleteaccBtn.BackColor = Color.FromArgb(255, 105, 97);
            deleteaccBtn.FlatAppearance.BorderColor = Color.FromArgb(23, 20, 51);
            deleteaccBtn.FlatAppearance.BorderSize = 2;
            deleteaccBtn.FlatStyle = FlatStyle.Flat;
            deleteaccBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteaccBtn.ForeColor = Color.FromArgb(224, 235, 237);
            deleteaccBtn.Location = new Point(99, 355);
            deleteaccBtn.Name = "deleteaccBtn";
            deleteaccBtn.Size = new Size(213, 31);
            deleteaccBtn.TabIndex = 37;
            deleteaccBtn.Text = "Delete My Account";
            deleteaccBtn.UseVisualStyleBackColor = false;
            deleteaccBtn.Click += deleteaccBtn_Click;
            // 
            // userDP
            // 
            userDP.BackColor = Color.DarkGray;
            userDP.Image = (Image)resources.GetObject("userDP.Image");
            userDP.Location = new Point(118, 11);
            userDP.Name = "userDP";
            userDP.Size = new Size(175, 174);
            userDP.SizeMode = PictureBoxSizeMode.StretchImage;
            userDP.TabIndex = 36;
            userDP.TabStop = false;
            userDP.Click += userDP_Click;
            // 
            // AccountSettingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 20, 51);
            ClientSize = new Size(704, 541);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccountSettingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountSettingPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userDP).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private CustomControls.OvalPictureBox userDP;
        private Button changepicBtn;
        private Button editprofileBtn;
        private Button deleteaccBtn;
        private Button backBtn;
        private Label label1;
        private PictureBox pictureBox2;
        private CustomControls.RoundButton CloseBtn;
        private CustomControls.RoundButton MinimizedBtn;
    }
}