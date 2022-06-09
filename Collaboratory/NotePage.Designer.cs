namespace Collaboratory
{
    partial class NotePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePage));
            this.label1 = new System.Windows.Forms.Label();
            this.noteTb = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(339, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Note";
            // 
            // noteTb
            // 
            this.noteTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noteTb.BackColor = System.Drawing.Color.LightGray;
            this.noteTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTb.Font = new System.Drawing.Font("Bahnschrift SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteTb.Location = new System.Drawing.Point(53, 73);
            this.noteTb.MaxLength = 280;
            this.noteTb.Multiline = true;
            this.noteTb.Name = "noteTb";
            this.noteTb.PlaceholderText = "Empty Note";
            this.noteTb.ReadOnly = true;
            this.noteTb.Size = new System.Drawing.Size(620, 327);
            this.noteTb.TabIndex = 51;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(696, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(28, 26);
            this.backBtn.TabIndex = 50;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // NotePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(730, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteTb);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotePage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NotePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox noteTb;
        private Button backBtn;
    }
}