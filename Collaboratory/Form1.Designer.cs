namespace Collaboratory
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            useridTb = new TextBox();
            passwordTb = new TextBox();
            loginBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            resetBtn = new Button();
            signupBtn = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            title = new Label();
            showPassBtn = new Button();
            label3 = new Label();
            MinimizedBtn = new CustomControls.RoundButton();
            CloseBtn = new CustomControls.RoundButton();
            appSettingsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // useridTb
            // 
            useridTb.BackColor = Color.FromArgb(224, 235, 237);
            useridTb.BorderStyle = BorderStyle.None;
            useridTb.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            useridTb.Location = new Point(179, 186);
            useridTb.MaxLength = 20;
            useridTb.Multiline = true;
            useridTb.Name = "useridTb";
            useridTb.Size = new Size(221, 25);
            useridTb.TabIndex = 0;
            useridTb.WordWrap = false;
            useridTb.KeyDown += useridTb_KeyDown;
            // 
            // passwordTb
            // 
            passwordTb.BackColor = Color.FromArgb(224, 235, 237);
            passwordTb.BorderStyle = BorderStyle.None;
            passwordTb.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTb.Location = new Point(179, 257);
            passwordTb.MaxLength = 15;
            passwordTb.Multiline = true;
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.Size = new Size(221, 25);
            passwordTb.TabIndex = 1;
            passwordTb.WordWrap = false;
            passwordTb.KeyDown += LoginForm_KeyDown;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(36, 83, 130);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.Location = new Point(179, 318);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(221, 33);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "LOG IN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            loginBtn.KeyDown += LoginForm_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(249, 158);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 3;
            label1.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(242, 232);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // resetBtn
            // 
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            resetBtn.Location = new Point(179, 359);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(221, 38);
            resetBtn.TabIndex = 5;
            resetBtn.Text = "Forgot Password";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // signupBtn
            // 
            signupBtn.FlatAppearance.BorderSize = 0;
            signupBtn.FlatStyle = FlatStyle.Flat;
            signupBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            signupBtn.Location = new Point(179, 411);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(221, 38);
            signupBtn.TabIndex = 6;
            signupBtn.Text = "Create New Account";
            signupBtn.UseVisualStyleBackColor = true;
            signupBtn.Click += signupBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 83, 130);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 28);
            panel1.TabIndex = 9;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.FlatStyle = FlatStyle.Flat;
            title.Font = new Font("Arial Rounded MT Bold", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(71, 65);
            title.Name = "title";
            title.Size = new Size(214, 38);
            title.TabIndex = 10;
            title.Text = "ollaboratory";
            // 
            // showPassBtn
            // 
            showPassBtn.BackColor = Color.FromArgb(224, 235, 237);
            showPassBtn.BackgroundImage = (Image)resources.GetObject("showPassBtn.BackgroundImage");
            showPassBtn.BackgroundImageLayout = ImageLayout.Stretch;
            showPassBtn.FlatAppearance.BorderSize = 0;
            showPassBtn.FlatStyle = FlatStyle.Flat;
            showPassBtn.Location = new Point(374, 257);
            showPassBtn.Name = "showPassBtn";
            showPassBtn.Size = new Size(23, 25);
            showPassBtn.TabIndex = 11;
            showPassBtn.UseVisualStyleBackColor = false;
            showPassBtn.Click += showPassBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(36, 83, 130);
            label3.Location = new Point(142, 390);
            label3.Name = "label3";
            label3.Size = new Size(304, 18);
            label3.TabIndex = 12;
            label3.Text = "_____________________________________";
            // 
            // MinimizedBtn
            // 
            MinimizedBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizedBtn.BackColor = Color.LightGreen;
            MinimizedBtn.FlatAppearance.BorderSize = 0;
            MinimizedBtn.FlatStyle = FlatStyle.Flat;
            MinimizedBtn.ForeColor = Color.LightGreen;
            MinimizedBtn.Location = new Point(529, 3);
            MinimizedBtn.Name = "MinimizedBtn";
            MinimizedBtn.Size = new Size(21, 22);
            MinimizedBtn.TabIndex = 13;
            MinimizedBtn.Text = "roundButton1";
            MinimizedBtn.UseVisualStyleBackColor = false;
            MinimizedBtn.Click += MinimizedBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.BackColor = Color.LightCoral;
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.ForeColor = Color.LightCoral;
            CloseBtn.Location = new Point(556, 3);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(21, 22);
            CloseBtn.TabIndex = 14;
            CloseBtn.Text = "roundButton2";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // appSettingsBtn
            // 
            appSettingsBtn.BackgroundImage = (Image)resources.GetObject("appSettingsBtn.BackgroundImage");
            appSettingsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            appSettingsBtn.FlatAppearance.BorderSize = 0;
            appSettingsBtn.FlatStyle = FlatStyle.Flat;
            appSettingsBtn.ForeColor = Color.Transparent;
            appSettingsBtn.Location = new Point(22, 421);
            appSettingsBtn.Name = "appSettingsBtn";
            appSettingsBtn.Size = new Size(39, 39);
            appSettingsBtn.TabIndex = 15;
            appSettingsBtn.UseVisualStyleBackColor = true;
            appSettingsBtn.Click += appSettingsBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 20, 51);
            ClientSize = new Size(583, 472);
            Controls.Add(appSettingsBtn);
            Controls.Add(CloseBtn);
            Controls.Add(MinimizedBtn);
            Controls.Add(label3);
            Controls.Add(showPassBtn);
            Controls.Add(title);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(signupBtn);
            Controls.Add(resetBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(passwordTb);
            Controls.Add(useridTb);
            ForeColor = Color.FromArgb(224, 235, 237);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            KeyDown += LoginForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox useridTb;
        private TextBox passwordTb;
        private Button loginBtn;
        private Label label1;
        private Label label2;
        private Button resetBtn;
        private Button signupBtn;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label title;
        private Button showPassBtn;
        private Label label3;
        private CustomControls.RoundButton MinimizedBtn;
        private CustomControls.RoundButton CloseBtn;
        private Button appSettingsBtn;
    }
}