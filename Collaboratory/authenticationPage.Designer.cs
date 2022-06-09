namespace Collaboratory
{
    partial class authenticationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authenticationPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizedBtn = new System.Windows.Forms.Button();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.reqcodeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.MinimizedBtn);
            this.panel1.Location = new System.Drawing.Point(-27, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 28);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.label4.Location = new System.Drawing.Point(48, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "ollaboratory";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
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
            this.CloseBtn.Location = new System.Drawing.Point(495, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(21, 22);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizedBtn
            // 
            this.MinimizedBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinimizedBtn.BackColor = System.Drawing.Color.LightGreen;
            this.MinimizedBtn.FlatAppearance.BorderSize = 0;
            this.MinimizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizedBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizedBtn.ForeColor = System.Drawing.Color.LightGreen;
            this.MinimizedBtn.Location = new System.Drawing.Point(468, 3);
            this.MinimizedBtn.Name = "MinimizedBtn";
            this.MinimizedBtn.Size = new System.Drawing.Size(21, 22);
            this.MinimizedBtn.TabIndex = 10;
            this.MinimizedBtn.UseVisualStyleBackColor = false;
            this.MinimizedBtn.Click += new System.EventHandler(this.MinimizedBtn_Click);
            // 
            // emailTb
            // 
            this.emailTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.emailTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTb.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailTb.Location = new System.Drawing.Point(105, 110);
            this.emailTb.MaxLength = 80;
            this.emailTb.Multiline = true;
            this.emailTb.Name = "emailTb";
            this.emailTb.PlaceholderText = "Enter your Email address";
            this.emailTb.Size = new System.Drawing.Size(286, 29);
            this.emailTb.TabIndex = 2;
            this.emailTb.WordWrap = false;
            // 
            // reqcodeBtn
            // 
            this.reqcodeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reqcodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.reqcodeBtn.FlatAppearance.BorderSize = 0;
            this.reqcodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reqcodeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reqcodeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.reqcodeBtn.Location = new System.Drawing.Point(105, 177);
            this.reqcodeBtn.Name = "reqcodeBtn";
            this.reqcodeBtn.Size = new System.Drawing.Size(286, 42);
            this.reqcodeBtn.TabIndex = 3;
            this.reqcodeBtn.Text = "Request Code";
            this.reqcodeBtn.UseVisualStyleBackColor = false;
            this.reqcodeBtn.Click += new System.EventHandler(this.reqcodeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(12, 39);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 26);
            this.backBtn.TabIndex = 4;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // authenticationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(495, 291);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.reqcodeBtn);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "authenticationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "authenticationPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Button CloseBtn;
        private Button MinimizedBtn;
        private TextBox emailTb;
        private Button reqcodeBtn;
        private Button backBtn;
        private Label label4;
        private PictureBox pictureBox2;
    }
}