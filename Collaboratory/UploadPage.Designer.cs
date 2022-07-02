namespace Collaboratory
{
    partial class UploadPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadPage));
            this.uploadFileBtn = new System.Windows.Forms.Button();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.noteTb = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.filenameLb = new System.Windows.Forms.Label();
            this.letterCountLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uploadFileBtn
            // 
            this.uploadFileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uploadFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.uploadFileBtn.FlatAppearance.BorderSize = 0;
            this.uploadFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadFileBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uploadFileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.uploadFileBtn.Location = new System.Drawing.Point(63, 148);
            this.uploadFileBtn.Name = "uploadFileBtn";
            this.uploadFileBtn.Size = new System.Drawing.Size(138, 35);
            this.uploadFileBtn.TabIndex = 3;
            this.uploadFileBtn.Text = "Upload File";
            this.uploadFileBtn.UseVisualStyleBackColor = false;
            this.uploadFileBtn.Click += new System.EventHandler(this.uploadFileBtn_Click);
            // 
            // titleTb
            // 
            this.titleTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.titleTb.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTb.Location = new System.Drawing.Point(63, 96);
            this.titleTb.MaxLength = 30;
            this.titleTb.Multiline = true;
            this.titleTb.Name = "titleTb";
            this.titleTb.PlaceholderText = "Write your title........";
            this.titleTb.Size = new System.Drawing.Size(497, 29);
            this.titleTb.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(79)))));
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.saveBtn.Location = new System.Drawing.Point(212, 446);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(183, 42);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // noteTb
            // 
            this.noteTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noteTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.noteTb.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteTb.Location = new System.Drawing.Point(63, 207);
            this.noteTb.MaxLength = 280;
            this.noteTb.Multiline = true;
            this.noteTb.Name = "noteTb";
            this.noteTb.PlaceholderText = "Write a note........";
            this.noteTb.Size = new System.Drawing.Size(497, 204);
            this.noteTb.TabIndex = 4;
            this.noteTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.noteTb_KeyDown);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(14, 19);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 26);
            this.backBtn.TabIndex = 6;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // filenameLb
            // 
            this.filenameLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filenameLb.AutoSize = true;
            this.filenameLb.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filenameLb.Location = new System.Drawing.Point(206, 159);
            this.filenameLb.Name = "filenameLb";
            this.filenameLb.Size = new System.Drawing.Size(0, 14);
            this.filenameLb.TabIndex = 1;
            // 
            // letterCountLb
            // 
            this.letterCountLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.letterCountLb.AutoSize = true;
            this.letterCountLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.letterCountLb.ForeColor = System.Drawing.Color.Black;
            this.letterCountLb.Location = new System.Drawing.Point(506, 414);
            this.letterCountLb.Name = "letterCountLb";
            this.letterCountLb.Size = new System.Drawing.Size(43, 15);
            this.letterCountLb.TabIndex = 45;
            this.letterCountLb.Text = "0/280";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(265, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "Create Post";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(608, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "___________________________________________________________________________";
            // 
            // UploadPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(171)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(624, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letterCountLb);
            this.Controls.Add(this.filenameLb);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.noteTb);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.uploadFileBtn);
            this.Controls.Add(this.titleTb);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button uploadFileBtn;
        private TextBox titleTb;
        private Button saveBtn;
        private TextBox noteTb;
        private Button backBtn;
        private Label filenameLb;
        private Label letterCountLb;
        private Label label1;
        private Label label3;
    }
}