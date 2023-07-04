namespace Collaboratory
{
    partial class AppSettingsPage
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
            label1 = new Label();
            dbPasswordInput = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 49);
            label1.Name = "label1";
            label1.Size = new Size(188, 18);
            label1.TabIndex = 4;
            label1.Text = "PostgreSQL Password";
            // 
            // dbPasswordInput
            // 
            dbPasswordInput.BackColor = Color.FromArgb(224, 235, 237);
            dbPasswordInput.BorderStyle = BorderStyle.None;
            dbPasswordInput.Font = new Font("Bahnschrift SemiLight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dbPasswordInput.Location = new Point(12, 73);
            dbPasswordInput.MaxLength = 20;
            dbPasswordInput.Multiline = true;
            dbPasswordInput.Name = "dbPasswordInput";
            dbPasswordInput.PasswordChar = '*';
            dbPasswordInput.Size = new Size(225, 25);
            dbPasswordInput.TabIndex = 5;
            dbPasswordInput.WordWrap = false;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(36, 83, 130);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.Location = new Point(28, 115);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(197, 30);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Submit";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // AppSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 20, 51);
            ClientSize = new Size(249, 167);
            Controls.Add(loginBtn);
            Controls.Add(dbPasswordInput);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(224, 235, 237);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AppSettingsPage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AppSettingsPage";
            Load += AppSettingsPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox dbPasswordInput;
        private Button loginBtn;
    }
}