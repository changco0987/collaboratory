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
            this.backBtn = new System.Windows.Forms.Button();
            this.noteTb = new System.Windows.Forms.TextBox();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.letterCountLb = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(590, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 26);
            this.backBtn.TabIndex = 7;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // noteTb
            // 
            this.noteTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noteTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.noteTb.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteTb.Location = new System.Drawing.Point(63, 187);
            this.noteTb.MaxLength = 280;
            this.noteTb.Multiline = true;
            this.noteTb.Name = "noteTb";
            this.noteTb.PlaceholderText = "Write a note........";
            this.noteTb.Size = new System.Drawing.Size(497, 204);
            this.noteTb.TabIndex = 9;
            this.noteTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.noteTb_KeyDown);
            // 
            // titleTb
            // 
            this.titleTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.titleTb.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTb.Location = new System.Drawing.Point(63, 122);
            this.titleTb.MaxLength = 30;
            this.titleTb.Multiline = true;
            this.titleTb.Name = "titleTb";
            this.titleTb.PlaceholderText = "Write your title........";
            this.titleTb.Size = new System.Drawing.Size(497, 29);
            this.titleTb.TabIndex = 8;
            // 
            // letterCountLb
            // 
            this.letterCountLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.letterCountLb.AutoSize = true;
            this.letterCountLb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.letterCountLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.letterCountLb.Location = new System.Drawing.Point(506, 394);
            this.letterCountLb.Name = "letterCountLb";
            this.letterCountLb.Size = new System.Drawing.Size(43, 15);
            this.letterCountLb.TabIndex = 46;
            this.letterCountLb.Text = "0/280";
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
            this.saveBtn.Location = new System.Drawing.Point(377, 451);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(183, 42);
            this.saveBtn.TabIndex = 47;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(32)))), ((int)(((byte)(79)))));
            this.deleteBtn.FlatAppearance.BorderSize = 2;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.deleteBtn.Location = new System.Drawing.Point(63, 451);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(183, 42);
            this.deleteBtn.TabIndex = 48;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(608, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "___________________________________________________________________________";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(251, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "Edit Post";
            // 
            // EditUploadPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(624, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.letterCountLb);
            this.Controls.Add(this.noteTb);
            this.Controls.Add(this.titleTb);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUploadPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditUploadPage";
            this.ResumeLayout(false);
            this.PerformLayout();

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