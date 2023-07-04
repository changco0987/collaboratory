namespace Collaboratory
{
    partial class RepositoryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepositoryPage));
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            panel1 = new Panel();
            CloseBtn = new CustomControls.RoundButton();
            maximizeBtn = new CustomControls.RoundButton();
            MinimizedBtn = new CustomControls.RoundButton();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            settingsBtn = new Button();
            useridLb = new Label();
            usernameLb = new Label();
            backBtn = new Button();
            userDP = new CustomControls.OvalPictureBox();
            chatBtn = new Button();
            editRepoBtn = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            emptyLb = new Label();
            emptyImg = new PictureBox();
            updateList = new DataGridView();
            idCol = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn3 = new DataGridViewTextBoxColumn();
            spaceCol = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            spaceCol2 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn4 = new DataGridViewTextBoxColumn();
            editCol = new DataGridViewImageColumn();
            noteCol = new DataGridViewImageColumn();
            downloadCol = new DataGridViewImageColumn();
            tabPage2 = new TabPage();
            label2 = new Label();
            myContriList = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            myPost = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pieChart1 = new LiveCharts.WinForms.PieChart();
            threadBtn = new Button();
            uploadBtn = new Button();
            contributionBtn = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            reponameLb = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDP).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emptyImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updateList).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myContriList).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(36, 83, 130);
            panel1.Controls.Add(CloseBtn);
            panel1.Controls.Add(maximizeBtn);
            panel1.Controls.Add(MinimizedBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1429, 28);
            panel1.TabIndex = 9;
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
            CloseBtn.Location = new Point(1397, 4);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(21, 22);
            CloseBtn.TabIndex = 39;
            CloseBtn.Text = "roundButton2";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // maximizeBtn
            // 
            maximizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximizeBtn.BackColor = Color.Gold;
            maximizeBtn.FlatAppearance.BorderSize = 0;
            maximizeBtn.FlatStyle = FlatStyle.Flat;
            maximizeBtn.ForeColor = Color.Gold;
            maximizeBtn.Location = new Point(1370, 4);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(21, 22);
            maximizeBtn.TabIndex = 43;
            maximizeBtn.Text = "roundButton1";
            maximizeBtn.UseVisualStyleBackColor = false;
            maximizeBtn.Click += maximizeBtn_Click;
            // 
            // MinimizedBtn
            // 
            MinimizedBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizedBtn.BackColor = Color.LightGreen;
            MinimizedBtn.FlatAppearance.BorderSize = 0;
            MinimizedBtn.FlatStyle = FlatStyle.Flat;
            MinimizedBtn.ForeColor = Color.LightGreen;
            MinimizedBtn.Location = new Point(1343, 4);
            MinimizedBtn.Name = "MinimizedBtn";
            MinimizedBtn.Size = new Size(21, 22);
            MinimizedBtn.TabIndex = 38;
            MinimizedBtn.Text = "roundButton1";
            MinimizedBtn.UseVisualStyleBackColor = false;
            MinimizedBtn.Click += MinimizedBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 235, 237);
            label4.Location = new Point(23, 5);
            label4.Name = "label4";
            label4.Size = new Size(105, 18);
            label4.TabIndex = 18;
            label4.Text = "ollaboratory";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(21, 77, 133);
            panel2.Controls.Add(settingsBtn);
            panel2.Controls.Add(useridLb);
            panel2.Controls.Add(usernameLb);
            panel2.Controls.Add(backBtn);
            panel2.Controls.Add(userDP);
            panel2.Controls.Add(chatBtn);
            panel2.Controls.Add(editRepoBtn);
            panel2.Location = new Point(12, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(1403, 233);
            panel2.TabIndex = 34;
            // 
            // settingsBtn
            // 
            settingsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            settingsBtn.BackColor = Color.Transparent;
            settingsBtn.BackgroundImage = (Image)resources.GetObject("settingsBtn.BackgroundImage");
            settingsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Location = new Point(1320, 10);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(31, 31);
            settingsBtn.TabIndex = 39;
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // useridLb
            // 
            useridLb.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            useridLb.ForeColor = Color.FromArgb(224, 235, 237);
            useridLb.Location = new Point(222, 107);
            useridLb.Name = "useridLb";
            useridLb.Size = new Size(343, 21);
            useridLb.TabIndex = 38;
            useridLb.Text = "onahmarie22";
            useridLb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // usernameLb
            // 
            usernameLb.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLb.ForeColor = Color.FromArgb(224, 235, 237);
            usernameLb.Location = new Point(222, 76);
            usernameLb.Name = "usernameLb";
            usernameLb.Size = new Size(343, 31);
            usernameLb.TabIndex = 37;
            usernameLb.Text = "Onah Marie A. Naputo";
            usernameLb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // backBtn
            // 
            backBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backBtn.BackColor = Color.Transparent;
            backBtn.BackgroundImage = (Image)resources.GetObject("backBtn.BackgroundImage");
            backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(1362, 10);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(32, 32);
            backBtn.TabIndex = 36;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // userDP
            // 
            userDP.BackColor = Color.DarkGray;
            userDP.Image = (Image)resources.GetObject("userDP.Image");
            userDP.Location = new Point(38, 29);
            userDP.Name = "userDP";
            userDP.Size = new Size(175, 174);
            userDP.SizeMode = PictureBoxSizeMode.StretchImage;
            userDP.TabIndex = 35;
            userDP.TabStop = false;
            // 
            // chatBtn
            // 
            chatBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chatBtn.BackColor = Color.FromArgb(36, 83, 130);
            chatBtn.FlatAppearance.BorderColor = Color.FromArgb(23, 20, 51);
            chatBtn.FlatAppearance.BorderSize = 2;
            chatBtn.FlatStyle = FlatStyle.Flat;
            chatBtn.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chatBtn.ForeColor = Color.FromArgb(224, 235, 237);
            chatBtn.Location = new Point(1125, 195);
            chatBtn.Name = "chatBtn";
            chatBtn.Size = new Size(138, 36);
            chatBtn.TabIndex = 34;
            chatBtn.Text = "Chat";
            chatBtn.UseVisualStyleBackColor = false;
            chatBtn.Click += chatBtn_Click;
            // 
            // editRepoBtn
            // 
            editRepoBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editRepoBtn.BackColor = Color.FromArgb(36, 83, 130);
            editRepoBtn.FlatAppearance.BorderColor = Color.FromArgb(23, 20, 51);
            editRepoBtn.FlatAppearance.BorderSize = 2;
            editRepoBtn.FlatStyle = FlatStyle.Flat;
            editRepoBtn.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editRepoBtn.ForeColor = Color.FromArgb(224, 235, 237);
            editRepoBtn.Location = new Point(1263, 195);
            editRepoBtn.Name = "editRepoBtn";
            editRepoBtn.Size = new Size(138, 36);
            editRepoBtn.TabIndex = 33;
            editRepoBtn.Text = "Edit Repository";
            editRepoBtn.UseVisualStyleBackColor = false;
            editRepoBtn.Click += editRepoBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 309);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1403, 504);
            tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(37, 32, 79);
            tabPage1.Controls.Add(emptyLb);
            tabPage1.Controls.Add(emptyImg);
            tabPage1.Controls.Add(updateList);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1395, 476);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // emptyLb
            // 
            emptyLb.Anchor = AnchorStyles.None;
            emptyLb.BackColor = Color.FromArgb(37, 32, 79);
            emptyLb.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emptyLb.ForeColor = Color.FromArgb(224, 235, 237);
            emptyLb.Location = new Point(597, 196);
            emptyLb.Name = "emptyLb";
            emptyLb.Size = new Size(343, 37);
            emptyLb.TabIndex = 42;
            emptyLb.Text = "There is nothing here";
            emptyLb.TextAlign = ContentAlignment.MiddleLeft;
            emptyLb.Visible = false;
            // 
            // emptyImg
            // 
            emptyImg.Anchor = AnchorStyles.None;
            emptyImg.BackColor = Color.FromArgb(37, 32, 79);
            emptyImg.Image = (Image)resources.GetObject("emptyImg.Image");
            emptyImg.Location = new Point(520, 185);
            emptyImg.Name = "emptyImg";
            emptyImg.Size = new Size(63, 57);
            emptyImg.SizeMode = PictureBoxSizeMode.StretchImage;
            emptyImg.TabIndex = 41;
            emptyImg.TabStop = false;
            emptyImg.Visible = false;
            // 
            // updateList
            // 
            updateList.AllowUserToAddRows = false;
            updateList.AllowUserToDeleteRows = false;
            updateList.AllowUserToResizeColumns = false;
            updateList.AllowUserToResizeRows = false;
            updateList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            updateList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            updateList.BackgroundColor = Color.FromArgb(37, 32, 79);
            updateList.BorderStyle = BorderStyle.Fixed3D;
            updateList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            updateList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            updateList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            updateList.ColumnHeadersHeight = 20;
            updateList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            updateList.ColumnHeadersVisible = false;
            updateList.Columns.AddRange(new DataGridViewColumn[] { idCol, dataGridViewImageColumn3, spaceCol, dataGridViewTextBoxColumn2, spaceCol2, dataGridViewImageColumn4, editCol, noteCol, downloadCol });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(224, 235, 237);
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            updateList.DefaultCellStyle = dataGridViewCellStyle13;
            updateList.GridColor = Color.FromArgb(36, 83, 130);
            updateList.Location = new Point(-4, 0);
            updateList.MultiSelect = false;
            updateList.Name = "updateList";
            updateList.ReadOnly = true;
            updateList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            updateList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            updateList.RowHeadersVisible = false;
            updateList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(36, 83, 130);
            dataGridViewCellStyle15.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(224, 235, 237);
            dataGridViewCellStyle15.Padding = new Padding(4, 7, 0, 7);
            updateList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            updateList.RowTemplate.DefaultCellStyle.NullValue = null;
            updateList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(36, 83, 130);
            updateList.RowTemplate.DividerHeight = 1;
            updateList.RowTemplate.Height = 80;
            updateList.RowTemplate.ReadOnly = true;
            updateList.RowTemplate.Resizable = DataGridViewTriState.False;
            updateList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            updateList.Size = new Size(1403, 480);
            updateList.TabIndex = 40;
            updateList.CellClick += updateList_CellClick;
            // 
            // idCol
            // 
            dataGridViewCellStyle12.BackColor = Color.Red;
            idCol.DefaultCellStyle = dataGridViewCellStyle12;
            idCol.FillWeight = 5F;
            idCol.HeaderText = "idCol";
            idCol.Name = "idCol";
            idCol.ReadOnly = true;
            idCol.Visible = false;
            // 
            // dataGridViewImageColumn3
            // 
            dataGridViewImageColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewImageColumn3.FillWeight = 15F;
            dataGridViewImageColumn3.HeaderText = "titleCol";
            dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            dataGridViewImageColumn3.ReadOnly = true;
            dataGridViewImageColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewImageColumn3.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewImageColumn3.Width = 5;
            // 
            // spaceCol
            // 
            spaceCol.FillWeight = 6.931818F;
            spaceCol.HeaderText = "spaceCol";
            spaceCol.Name = "spaceCol";
            spaceCol.ReadOnly = true;
            spaceCol.Resizable = DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.FillWeight = 7F;
            dataGridViewTextBoxColumn2.HeaderText = "nameCol";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn2.Width = 5;
            // 
            // spaceCol2
            // 
            spaceCol2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            spaceCol2.FillWeight = 10F;
            spaceCol2.HeaderText = "spaceCol2";
            spaceCol2.Name = "spaceCol2";
            spaceCol2.ReadOnly = true;
            spaceCol2.Resizable = DataGridViewTriState.False;
            spaceCol2.Width = 5;
            // 
            // dataGridViewImageColumn4
            // 
            dataGridViewImageColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewImageColumn4.FillWeight = 7F;
            dataGridViewImageColumn4.HeaderText = "datetimeCol";
            dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            dataGridViewImageColumn4.ReadOnly = true;
            dataGridViewImageColumn4.Resizable = DataGridViewTriState.False;
            dataGridViewImageColumn4.Width = 5;
            // 
            // editCol
            // 
            editCol.FillWeight = 1.386364F;
            editCol.HeaderText = "editCol";
            editCol.Image = (Image)resources.GetObject("editCol.Image");
            editCol.Name = "editCol";
            editCol.ReadOnly = true;
            // 
            // noteCol
            // 
            noteCol.FillWeight = 1.386364F;
            noteCol.HeaderText = "noteCol";
            noteCol.Image = (Image)resources.GetObject("noteCol.Image");
            noteCol.Name = "noteCol";
            noteCol.ReadOnly = true;
            // 
            // downloadCol
            // 
            downloadCol.FillWeight = 1.386364F;
            downloadCol.HeaderText = "downloadCol";
            downloadCol.Image = (Image)resources.GetObject("downloadCol.Image");
            downloadCol.Name = "downloadCol";
            downloadCol.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(34, 82, 129);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(myContriList);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(pieChart1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1395, 476);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Ebrima", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 235, 237);
            label2.Location = new Point(924, 7);
            label2.Name = "label2";
            label2.Size = new Size(343, 31);
            label2.TabIndex = 41;
            label2.Text = "My Contribution";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // myContriList
            // 
            myContriList.AllowUserToAddRows = false;
            myContriList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(21, 77, 133);
            myContriList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            myContriList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            myContriList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            myContriList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            myContriList.BackgroundColor = Color.FromArgb(37, 32, 79);
            myContriList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            myContriList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(43, 93, 107);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            myContriList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            myContriList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            myContriList.ColumnHeadersVisible = false;
            myContriList.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, myPost });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(43, 93, 107);
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.FromArgb(224, 235, 237);
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            myContriList.DefaultCellStyle = dataGridViewCellStyle18;
            myContriList.GridColor = Color.FromArgb(36, 83, 130);
            myContriList.Location = new Point(801, 51);
            myContriList.Name = "myContriList";
            myContriList.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(43, 93, 107);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            myContriList.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            myContriList.RowHeadersVisible = false;
            myContriList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(36, 83, 130);
            dataGridViewCellStyle20.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.FromArgb(224, 235, 237);
            dataGridViewCellStyle20.Padding = new Padding(4, 7, 0, 7);
            myContriList.RowsDefaultCellStyle = dataGridViewCellStyle20;
            myContriList.RowTemplate.Height = 25;
            myContriList.Size = new Size(579, 408);
            myContriList.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "idCol";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // myPost
            // 
            myPost.HeaderText = "myPost";
            myPost.Name = "myPost";
            myPost.ReadOnly = true;
            // 
            // label1
            // 
            label1.Font = new Font("Ebrima", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 235, 237);
            label1.Location = new Point(215, 7);
            label1.Name = "label1";
            label1.Size = new Size(343, 31);
            label1.TabIndex = 38;
            label1.Text = "Project Contributor Chart";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pieChart1
            // 
            pieChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pieChart1.Location = new Point(34, 51);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(678, 408);
            pieChart1.TabIndex = 0;
            pieChart1.Text = "pieChart1";
            // 
            // threadBtn
            // 
            threadBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            threadBtn.BackColor = Color.FromArgb(37, 32, 79);
            threadBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 235, 237);
            threadBtn.FlatStyle = FlatStyle.Flat;
            threadBtn.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            threadBtn.ForeColor = Color.FromArgb(224, 235, 237);
            threadBtn.Location = new Point(726, 19);
            threadBtn.Name = "threadBtn";
            threadBtn.Size = new Size(168, 37);
            threadBtn.TabIndex = 44;
            threadBtn.Text = "Thread";
            threadBtn.UseVisualStyleBackColor = false;
            threadBtn.Click += threadBtn_Click;
            // 
            // uploadBtn
            // 
            uploadBtn.Anchor = AnchorStyles.Right;
            uploadBtn.BackColor = Color.Transparent;
            uploadBtn.BackgroundImage = (Image)resources.GetObject("uploadBtn.BackgroundImage");
            uploadBtn.BackgroundImageLayout = ImageLayout.Stretch;
            uploadBtn.FlatAppearance.BorderSize = 0;
            uploadBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            uploadBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            uploadBtn.FlatStyle = FlatStyle.Flat;
            uploadBtn.Location = new Point(1350, 10);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(34, 35);
            uploadBtn.TabIndex = 43;
            uploadBtn.UseVisualStyleBackColor = false;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // contributionBtn
            // 
            contributionBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            contributionBtn.BackColor = Color.FromArgb(36, 83, 130);
            contributionBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 235, 237);
            contributionBtn.FlatStyle = FlatStyle.Flat;
            contributionBtn.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            contributionBtn.ForeColor = Color.FromArgb(224, 235, 237);
            contributionBtn.Location = new Point(895, 19);
            contributionBtn.Name = "contributionBtn";
            contributionBtn.Size = new Size(168, 37);
            contributionBtn.TabIndex = 42;
            contributionBtn.Text = "Contribution";
            contributionBtn.UseVisualStyleBackColor = false;
            contributionBtn.Click += contributionBtn_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(37, 32, 79);
            panel3.Controls.Add(threadBtn);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(uploadBtn);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(contributionBtn);
            panel3.Controls.Add(reponameLb);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(12, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(1403, 55);
            panel3.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3460, 7);
            button1.Name = "button1";
            button1.Size = new Size(34, 35);
            button1.TabIndex = 39;
            button1.UseVisualStyleBackColor = false;
            // 
            // reponameLb
            // 
            reponameLb.Anchor = AnchorStyles.Left;
            reponameLb.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            reponameLb.ForeColor = Color.FromArgb(224, 235, 237);
            reponameLb.Location = new Point(68, 15);
            reponameLb.Name = "reponameLb";
            reponameLb.Size = new Size(343, 31);
            reponameLb.TabIndex = 37;
            reponameLb.Text = "Repository Collab";
            reponameLb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(3513, 7);
            button2.Name = "button2";
            button2.Size = new Size(34, 35);
            button2.TabIndex = 36;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(36, 83, 130);
            button3.FlatAppearance.BorderColor = Color.FromArgb(23, 20, 51);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(224, 235, 237);
            button3.Location = new Point(3215, 86);
            button3.Name = "button3";
            button3.Size = new Size(168, 55);
            button3.TabIndex = 34;
            button3.Text = "Chat";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(36, 83, 130);
            button4.FlatAppearance.BorderColor = Color.FromArgb(23, 20, 51);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(224, 235, 237);
            button4.Location = new Point(3383, 86);
            button4.Name = "button4";
            button4.Size = new Size(168, 55);
            button4.TabIndex = 33;
            button4.Text = "Edit Repository";
            button4.UseVisualStyleBackColor = false;
            // 
            // RepositoryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 20, 51);
            ClientSize = new Size(1427, 825);
            Controls.Add(panel3);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(224, 235, 237);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RepositoryPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += RepositoryPage_Load;
            Resize += RepositoryPage_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userDP).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)emptyImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)updateList).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)myContriList).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label useridLb;
        private Label usernameLb;
        private Button backBtn;
        private CustomControls.OvalPictureBox userDP;
        private Button chatBtn;
        private Button editRepoBtn;
        private Button settingsBtn;
        private Label label4;
        private PictureBox pictureBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label emptyLb;
        private PictureBox emptyImg;
        private DataGridView updateList;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn dataGridViewImageColumn3;
        private DataGridViewTextBoxColumn spaceCol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn spaceCol2;
        private DataGridViewTextBoxColumn dataGridViewImageColumn4;
        private DataGridViewImageColumn editCol;
        private DataGridViewImageColumn noteCol;
        private DataGridViewImageColumn downloadCol;
        private TabPage tabPage2;
        private LiveCharts.WinForms.PieChart pieChart1;
        private Label label1;
        private Button threadBtn;
        private Button uploadBtn;
        private Button contributionBtn;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button button1;
        private Label reponameLb;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView myContriList;
        private Label label2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn myPost;
        private CustomControls.RoundButton CloseBtn;
        private CustomControls.RoundButton maximizeBtn;
        private CustomControls.RoundButton MinimizedBtn;
    }
}