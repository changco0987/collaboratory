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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.changepicBtn = new System.Windows.Forms.Button();
            this.editprofileBtn = new System.Windows.Forms.Button();
            this.deleteaccBtn = new System.Windows.Forms.Button();
            this.userDP = new Collaboratory.CustomControls.OvalPictureBox();
            this.CloseBtn = new Collaboratory.CustomControls.RoundButton();
            this.MinimizedBtn = new Collaboratory.CustomControls.RoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.MinimizedBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 28);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "ollaboratory";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.changepicBtn);
            this.panel2.Controls.Add(this.editprofileBtn);
            this.panel2.Controls.Add(this.deleteaccBtn);
            this.panel2.Controls.Add(this.userDP);
            this.panel2.Location = new System.Drawing.Point(146, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 419);
            this.panel2.TabIndex = 11;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(11, 13);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 26);
            this.backBtn.TabIndex = 40;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // changepicBtn
            // 
            this.changepicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.changepicBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.changepicBtn.FlatAppearance.BorderSize = 0;
            this.changepicBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changepicBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changepicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changepicBtn.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changepicBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.changepicBtn.Location = new System.Drawing.Point(104, 191);
            this.changepicBtn.Name = "changepicBtn";
            this.changepicBtn.Size = new System.Drawing.Size(208, 44);
            this.changepicBtn.TabIndex = 39;
            this.changepicBtn.Text = "Change Photo";
            this.changepicBtn.UseVisualStyleBackColor = false;
            this.changepicBtn.Click += new System.EventHandler(this.changepicBtn_Click);
            // 
            // editprofileBtn
            // 
            this.editprofileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.editprofileBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.editprofileBtn.FlatAppearance.BorderSize = 2;
            this.editprofileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editprofileBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editprofileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.editprofileBtn.Location = new System.Drawing.Point(57, 273);
            this.editprofileBtn.Name = "editprofileBtn";
            this.editprofileBtn.Size = new System.Drawing.Size(295, 44);
            this.editprofileBtn.TabIndex = 38;
            this.editprofileBtn.Text = "Edit Profile";
            this.editprofileBtn.UseVisualStyleBackColor = false;
            this.editprofileBtn.Click += new System.EventHandler(this.editprofileBtn_Click);
            // 
            // deleteaccBtn
            // 
            this.deleteaccBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
            this.deleteaccBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.deleteaccBtn.FlatAppearance.BorderSize = 2;
            this.deleteaccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteaccBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteaccBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.deleteaccBtn.Location = new System.Drawing.Point(57, 356);
            this.deleteaccBtn.Name = "deleteaccBtn";
            this.deleteaccBtn.Size = new System.Drawing.Size(295, 44);
            this.deleteaccBtn.TabIndex = 37;
            this.deleteaccBtn.Text = "Delete My Account";
            this.deleteaccBtn.UseVisualStyleBackColor = false;
            this.deleteaccBtn.Click += new System.EventHandler(this.deleteaccBtn_Click);
            // 
            // userDP
            // 
            this.userDP.BackColor = System.Drawing.Color.DarkGray;
            this.userDP.Image = ((System.Drawing.Image)(resources.GetObject("userDP.Image")));
            this.userDP.Location = new System.Drawing.Point(118, 11);
            this.userDP.Name = "userDP";
            this.userDP.Size = new System.Drawing.Size(175, 174);
            this.userDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userDP.TabIndex = 36;
            this.userDP.TabStop = false;
            this.userDP.Click += new System.EventHandler(this.userDP_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.LightCoral;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.LightCoral;
            this.CloseBtn.Location = new System.Drawing.Point(680, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(21, 22);
            this.CloseBtn.TabIndex = 49;
            this.CloseBtn.Text = "roundButton2";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizedBtn
            // 
            this.MinimizedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizedBtn.BackColor = System.Drawing.Color.LightGreen;
            this.MinimizedBtn.FlatAppearance.BorderSize = 0;
            this.MinimizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizedBtn.ForeColor = System.Drawing.Color.LightGreen;
            this.MinimizedBtn.Location = new System.Drawing.Point(653, 4);
            this.MinimizedBtn.Name = "MinimizedBtn";
            this.MinimizedBtn.Size = new System.Drawing.Size(21, 22);
            this.MinimizedBtn.TabIndex = 48;
            this.MinimizedBtn.Text = "roundButton1";
            this.MinimizedBtn.UseVisualStyleBackColor = false;
            this.MinimizedBtn.Click += new System.EventHandler(this.MinimizedBtn_Click);
            // 
            // AccountSettingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountSettingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountSettingPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDP)).EndInit();
            this.ResumeLayout(false);

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