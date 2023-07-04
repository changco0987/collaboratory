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
            panel1 = new Panel();
            CloseBtn = new CustomControls.RoundButton();
            MinimizedBtn = new CustomControls.RoundButton();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            emailTb = new TextBox();
            reqcodeBtn = new Button();
            backBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(36, 83, 130);
            panel1.Controls.Add(CloseBtn);
            panel1.Controls.Add(MinimizedBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-27, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 28);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            CloseBtn.Location = new Point(391, 4);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(21, 22);
            CloseBtn.TabIndex = 16;
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
            MinimizedBtn.Location = new Point(364, 4);
            MinimizedBtn.Name = "MinimizedBtn";
            MinimizedBtn.Size = new Size(21, 22);
            MinimizedBtn.TabIndex = 15;
            MinimizedBtn.Text = "roundButton1";
            MinimizedBtn.UseVisualStyleBackColor = false;
            MinimizedBtn.Click += MinimizedBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 235, 237);
            label4.Location = new Point(48, 5);
            label4.Name = "label4";
            label4.Size = new Size(105, 18);
            label4.TabIndex = 16;
            label4.Text = "ollaboratory";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // emailTb
            // 
            emailTb.Anchor = AnchorStyles.None;
            emailTb.BackColor = Color.FromArgb(224, 235, 237);
            emailTb.BorderStyle = BorderStyle.None;
            emailTb.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailTb.ForeColor = SystemColors.ActiveCaptionText;
            emailTb.Location = new Point(60, 84);
            emailTb.MaxLength = 80;
            emailTb.Multiline = true;
            emailTb.Name = "emailTb";
            emailTb.PlaceholderText = "Enter your Email address";
            emailTb.Size = new Size(286, 29);
            emailTb.TabIndex = 2;
            emailTb.WordWrap = false;
            emailTb.KeyDown += emailTb_KeyDown;
            // 
            // reqcodeBtn
            // 
            reqcodeBtn.Anchor = AnchorStyles.None;
            reqcodeBtn.BackColor = Color.FromArgb(36, 83, 130);
            reqcodeBtn.FlatAppearance.BorderSize = 0;
            reqcodeBtn.FlatStyle = FlatStyle.Flat;
            reqcodeBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reqcodeBtn.ForeColor = Color.FromArgb(224, 235, 237);
            reqcodeBtn.Location = new Point(123, 143);
            reqcodeBtn.Name = "reqcodeBtn";
            reqcodeBtn.Size = new Size(155, 33);
            reqcodeBtn.TabIndex = 3;
            reqcodeBtn.Text = "Request Code";
            reqcodeBtn.UseVisualStyleBackColor = false;
            reqcodeBtn.Click += reqcodeBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.ForeColor = Color.Transparent;
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(12, 39);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(28, 26);
            backBtn.TabIndex = 4;
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // authenticationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 20, 51);
            ClientSize = new Size(394, 209);
            Controls.Add(backBtn);
            Controls.Add(reqcodeBtn);
            Controls.Add(emailTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "authenticationPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "authenticationPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox emailTb;
        private Button reqcodeBtn;
        private Button backBtn;
        private Label label4;
        private PictureBox pictureBox2;
        private CustomControls.RoundButton CloseBtn;
        private CustomControls.RoundButton MinimizedBtn;
    }
}