namespace Collaboratory
{
    partial class EditUploadPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUploadPage));
            backBtn = new Button();
            noteTb = new TextBox();
            titleTb = new TextBox();
            letterCountLb = new Label();
            saveBtn = new Button();
            deleteBtn = new Button();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.ForeColor = Color.Transparent;
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(590, 6);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(28, 26);
            backBtn.TabIndex = 7;
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // noteTb
            // 
            noteTb.Anchor = AnchorStyles.None;
            noteTb.BackColor = Color.FromArgb(224, 235, 237);
            noteTb.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            noteTb.Location = new Point(63, 187);
            noteTb.MaxLength = 280;
            noteTb.Multiline = true;
            noteTb.Name = "noteTb";
            noteTb.PlaceholderText = "Write a note........";
            noteTb.Size = new Size(497, 204);
            noteTb.TabIndex = 9;
            noteTb.KeyDown += noteTb_KeyDown;
            // 
            // titleTb
            // 
            titleTb.Anchor = AnchorStyles.None;
            titleTb.BackColor = Color.FromArgb(224, 235, 237);
            titleTb.Font = new Font("Bahnschrift SemiLight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleTb.Location = new Point(63, 122);
            titleTb.MaxLength = 30;
            titleTb.Multiline = true;
            titleTb.Name = "titleTb";
            titleTb.PlaceholderText = "Write your title........";
            titleTb.Size = new Size(497, 29);
            titleTb.TabIndex = 8;
            // 
            // letterCountLb
            // 
            letterCountLb.Anchor = AnchorStyles.None;
            letterCountLb.AutoSize = true;
            letterCountLb.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            letterCountLb.ForeColor = Color.Black;
            letterCountLb.Location = new Point(506, 394);
            letterCountLb.Name = "letterCountLb";
            letterCountLb.Size = new Size(43, 15);
            letterCountLb.TabIndex = 46;
            letterCountLb.Text = "0/280";
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.None;
            saveBtn.BackColor = Color.FromArgb(36, 83, 130);
            saveBtn.FlatAppearance.BorderColor = Color.FromArgb(37, 32, 79);
            saveBtn.FlatAppearance.BorderSize = 2;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.FromArgb(224, 235, 237);
            saveBtn.Location = new Point(388, 458);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(172, 35);
            saveBtn.TabIndex = 47;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.None;
            deleteBtn.BackColor = Color.FromArgb(36, 83, 130);
            deleteBtn.FlatAppearance.BorderColor = Color.FromArgb(37, 32, 79);
            deleteBtn.FlatAppearance.BorderSize = 2;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.FromArgb(224, 235, 237);
            deleteBtn.Location = new Point(63, 458);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(172, 35);
            deleteBtn.TabIndex = 48;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(36, 83, 130);
            label3.Location = new Point(9, 53);
            label3.Name = "label3";
            label3.Size = new Size(608, 18);
            label3.TabIndex = 50;
            label3.Text = "___________________________________________________________________________";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(261, 10);
            label1.Name = "label1";
            label1.Size = new Size(93, 22);
            label1.TabIndex = 49;
            label1.Text = "Edit Post";
            // 
            // EditUploadPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(108, 171, 217);
            ClientSize = new Size(624, 515);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(deleteBtn);
            Controls.Add(saveBtn);
            Controls.Add(letterCountLb);
            Controls.Add(noteTb);
            Controls.Add(titleTb);
            Controls.Add(backBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditUploadPage";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditUploadPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private TextBox noteTb;
        private TextBox titleTb;
        private Label letterCountLb;
        private Button saveBtn;
        private Button deleteBtn;
        private Label label3;
        private Label label1;
    }
}