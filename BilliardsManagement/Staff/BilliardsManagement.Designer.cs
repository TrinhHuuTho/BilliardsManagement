namespace BilliardsManagement
{
    partial class BilliardsManagement
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilliardsManagement));
            menuStrip1 = new MenuStrip();
            cáNhânToolStripMenuItem = new ToolStripMenuItem();
            điểmDanhToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            thoátChươngTrìnhToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            Ban5 = new Button();
            Ban4 = new Button();
            Ban3 = new Button();
            Ban2 = new Button();
            Ban6 = new Button();
            Ban1 = new Button();
            panel2 = new Panel();
            XoaMon = new Button();
            startTime = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            SDTBox = new TextBox();
            label1 = new Label();
            listView1 = new ListView();
            button2 = new Button();
            listView2 = new ListView();
            panel3 = new Panel();
            SoLuongM = new NumericUpDown();
            SoLuongD = new NumericUpDown();
            SoLuongF = new NumericUpDown();
            button1 = new Button();
            moreBox = new ComboBox();
            drinkBox = new ComboBox();
            foodBox = new ComboBox();
            foodAndDrinkBindingSource = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label4 = new Label();
            button9 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            nameUser = new Label();
            label3 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SoLuongM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SoLuongD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SoLuongF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodAndDrinkBindingSource).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GrayText;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cáNhânToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1128, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cáNhânToolStripMenuItem
            // 
            cáNhânToolStripMenuItem.BackColor = Color.White;
            cáNhânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { điểmDanhToolStripMenuItem, logOutToolStripMenuItem, thoátChươngTrìnhToolStripMenuItem });
            cáNhânToolStripMenuItem.Name = "cáNhânToolStripMenuItem";
            cáNhânToolStripMenuItem.Size = new Size(70, 20);
            cáNhânToolStripMenuItem.Text = "Tùy Chọn";
            cáNhânToolStripMenuItem.Click += cáNhânToolStripMenuItem_Click;
            // 
            // điểmDanhToolStripMenuItem
            // 
            điểmDanhToolStripMenuItem.Name = "điểmDanhToolStripMenuItem";
            điểmDanhToolStripMenuItem.Size = new Size(179, 22);
            điểmDanhToolStripMenuItem.Text = "Điểm Danh";
            điểmDanhToolStripMenuItem.Click += điểmDanhToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(179, 22);
            logOutToolStripMenuItem.Text = "Đăng Xuất";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            thoátChươngTrìnhToolStripMenuItem.Size = new Size(179, 22);
            thoátChươngTrìnhToolStripMenuItem.Text = "Thoát Chương Trình";
            thoátChươngTrìnhToolStripMenuItem.Click += thoátChươngTrìnhToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(Ban5);
            panel1.Controls.Add(Ban4);
            panel1.Controls.Add(Ban3);
            panel1.Controls.Add(Ban2);
            panel1.Controls.Add(Ban6);
            panel1.Controls.Add(Ban1);
            panel1.Location = new Point(12, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 326);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // Ban5
            // 
            Ban5.BackColor = Color.Gray;
            Ban5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ban5.ForeColor = SystemColors.ControlLightLight;
            Ban5.Location = new Point(263, 181);
            Ban5.Name = "Ban5";
            Ban5.Size = new Size(120, 120);
            Ban5.TabIndex = 28;
            Ban5.Text = "BÀN 5\r\n(Carom)";
            Ban5.UseVisualStyleBackColor = false;
            Ban5.Click += Ban5_Click;
            // 
            // Ban4
            // 
            Ban4.BackColor = Color.Gray;
            Ban4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ban4.ForeColor = SystemColors.ControlLightLight;
            Ban4.Location = new Point(59, 181);
            Ban4.Name = "Ban4";
            Ban4.Size = new Size(120, 120);
            Ban4.TabIndex = 27;
            Ban4.Text = "BÀN 4\r\n(Carom)";
            Ban4.UseVisualStyleBackColor = false;
            Ban4.Click += Ban4_Click;
            // 
            // Ban3
            // 
            Ban3.BackColor = Color.Gray;
            Ban3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ban3.ForeColor = SystemColors.ControlLightLight;
            Ban3.Location = new Point(465, 18);
            Ban3.Name = "Ban3";
            Ban3.Size = new Size(120, 120);
            Ban3.TabIndex = 26;
            Ban3.Text = "BÀN 3\r\n(Pool)\r\n";
            Ban3.UseVisualStyleBackColor = false;
            Ban3.Click += Ban3_Click;
            // 
            // Ban2
            // 
            Ban2.BackColor = Color.Gray;
            Ban2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ban2.ForeColor = SystemColors.ControlLightLight;
            Ban2.Location = new Point(263, 18);
            Ban2.Name = "Ban2";
            Ban2.Size = new Size(120, 120);
            Ban2.TabIndex = 25;
            Ban2.Text = "BÀN 2\r\n(Pool)\r\n";
            Ban2.UseVisualStyleBackColor = false;
            Ban2.Click += Ban2_Click;
            // 
            // Ban6
            // 
            Ban6.BackColor = Color.Gray;
            Ban6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ban6.ForeColor = SystemColors.ControlLightLight;
            Ban6.Location = new Point(465, 181);
            Ban6.Name = "Ban6";
            Ban6.Size = new Size(120, 120);
            Ban6.TabIndex = 10;
            Ban6.Text = "BÀN 6\r\n(Carom)";
            Ban6.UseVisualStyleBackColor = false;
            Ban6.Click += Ban6_Click;
            // 
            // Ban1
            // 
            Ban1.BackColor = Color.Gray;
            Ban1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ban1.ForeColor = SystemColors.ControlLightLight;
            Ban1.Location = new Point(59, 18);
            Ban1.Name = "Ban1";
            Ban1.Size = new Size(120, 120);
            Ban1.TabIndex = 8;
            Ban1.Text = "BÀN 1\r\n(Pool)\r\n";
            Ban1.UseVisualStyleBackColor = false;
            Ban1.Click += Ban1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(XoaMon);
            panel2.Controls.Add(startTime);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(SDTBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listView1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(listView2);
            panel2.Location = new Point(670, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 372);
            panel2.TabIndex = 3;
            // 
            // XoaMon
            // 
            XoaMon.Cursor = Cursors.Hand;
            XoaMon.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            XoaMon.Location = new Point(357, 46);
            XoaMon.Name = "XoaMon";
            XoaMon.Size = new Size(82, 21);
            XoaMon.TabIndex = 8;
            XoaMon.Text = "Xóa Món";
            XoaMon.UseVisualStyleBackColor = true;
            XoaMon.Click += XoaMon_Click;
            // 
            // startTime
            // 
            startTime.AutoSize = true;
            startTime.BackColor = Color.Transparent;
            startTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startTime.Location = new Point(7, 46);
            startTime.Name = "startTime";
            startTime.Size = new Size(80, 21);
            startTime.TabIndex = 7;
            startTime.Text = "Đang Tải...";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(433, 251);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(152, 9);
            label2.Name = "label2";
            label2.Size = new Size(90, 36);
            label2.TabIndex = 5;
            label2.Text = "BILL";
            label2.Click += label2_Click;
            // 
            // SDTBox
            // 
            SDTBox.Cursor = Cursors.SizeNS;
            SDTBox.Location = new Point(138, 337);
            SDTBox.Name = "SDTBox";
            SDTBox.Size = new Size(192, 23);
            SDTBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 338);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 4;
            label1.Text = "SĐT Khách Hàng: ";
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 327);
            listView1.Name = "listView1";
            listView1.Size = new Size(338, 42);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Green;
            button2.Location = new Point(347, 331);
            button2.Name = "button2";
            button2.Size = new Size(92, 33);
            button2.TabIndex = 2;
            button2.Text = "Thanh Toán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView2
            // 
            listView2.Location = new Point(3, 3);
            listView2.Name = "listView2";
            listView2.Size = new Size(440, 322);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(SoLuongM);
            panel3.Controls.Add(SoLuongD);
            panel3.Controls.Add(SoLuongF);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(moreBox);
            panel3.Controls.Add(drinkBox);
            panel3.Controls.Add(foodBox);
            panel3.Location = new Point(670, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(446, 131);
            panel3.TabIndex = 4;
            // 
            // SoLuongM
            // 
            SoLuongM.Cursor = Cursors.Hand;
            SoLuongM.Location = new Point(215, 88);
            SoLuongM.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SoLuongM.Name = "SoLuongM";
            SoLuongM.Size = new Size(93, 23);
            SoLuongM.TabIndex = 5;
            SoLuongM.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SoLuongD
            // 
            SoLuongD.Cursor = Cursors.Hand;
            SoLuongD.Location = new Point(215, 53);
            SoLuongD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SoLuongD.Name = "SoLuongD";
            SoLuongD.Size = new Size(93, 23);
            SoLuongD.TabIndex = 4;
            SoLuongD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SoLuongF
            // 
            SoLuongF.Cursor = Cursors.Hand;
            SoLuongF.Location = new Point(215, 19);
            SoLuongF.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SoLuongF.Name = "SoLuongF";
            SoLuongF.Size = new Size(93, 23);
            SoLuongF.TabIndex = 3;
            SoLuongF.Value = new decimal(new int[] { 1, 0, 0, 0 });
            SoLuongF.ValueChanged += SoLuongF_ValueChanged;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(322, 34);
            button1.Name = "button1";
            button1.Size = new Size(117, 60);
            button1.TabIndex = 2;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // moreBox
            // 
            moreBox.Cursor = Cursors.Hand;
            moreBox.DropDownStyle = ComboBoxStyle.DropDownList;
            moreBox.FormattingEnabled = true;
            moreBox.Location = new Point(11, 88);
            moreBox.Name = "moreBox";
            moreBox.Size = new Size(195, 23);
            moreBox.TabIndex = 2;
            moreBox.SelectedIndexChanged += moreBox_SelectedIndexChanged;
            // 
            // drinkBox
            // 
            drinkBox.Cursor = Cursors.Hand;
            drinkBox.DropDownStyle = ComboBoxStyle.DropDownList;
            drinkBox.FormattingEnabled = true;
            drinkBox.Location = new Point(11, 53);
            drinkBox.Name = "drinkBox";
            drinkBox.Size = new Size(195, 23);
            drinkBox.TabIndex = 1;
            drinkBox.SelectedIndexChanged += drinkBox_SelectedIndexChanged;
            // 
            // foodBox
            // 
            foodBox.Cursor = Cursors.Hand;
            foodBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foodBox.FormattingEnabled = true;
            foodBox.Location = new Point(11, 18);
            foodBox.Name = "foodBox";
            foodBox.Size = new Size(195, 23);
            foodBox.TabIndex = 0;
            foodBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // foodAndDrinkBindingSource
            // 
            foodAndDrinkBindingSource.DataSource = typeof(FoodAndDrink);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(103, 32);
            label4.Name = "label4";
            label4.Size = new Size(461, 55);
            label4.TabIndex = 7;
            label4.Text = "Billiard Management";
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.HotTrack;
            button9.Location = new Point(13, 13);
            button9.Name = "button9";
            button9.Size = new Size(162, 89);
            button9.TabIndex = 7;
            button9.Text = "Bắt Đầu Tính Giờ";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button9);
            panel4.Location = new Point(350, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(314, 115);
            panel4.TabIndex = 8;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(194, 12);
            button3.Name = "button3";
            button3.Size = new Size(109, 91);
            button3.TabIndex = 8;
            button3.Text = "Dừng Tính Giờ\r\n(Xóa Bill)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientInactiveCaption;
            panel5.Controls.Add(nameUser);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(14, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(330, 115);
            panel5.TabIndex = 9;
            // 
            // nameUser
            // 
            nameUser.AutoSize = true;
            nameUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameUser.Location = new Point(97, 15);
            nameUser.Name = "nameUser";
            nameUser.Size = new Size(18, 20);
            nameUser.TabIndex = 13;
            nameUser.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 15);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 12;
            label3.Text = "Nhân Viên:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(204, 78);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 11;
            label9.Text = "Bàn Có Khách";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 78);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 10;
            label8.Text = "Bàn Trống";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Red;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(173, 78);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 9;
            label7.Text = "5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(11, 42);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 8;
            label6.Text = "Trạng Thái Bàn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gray;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(43, 77);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 7;
            label5.Text = "5";
            // 
            // BilliardsManagement
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1128, 559);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "BilliardsManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BilliardsManagement";
            Load += BilliardsManagement_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SoLuongM).EndInit();
            ((System.ComponentModel.ISupportInitialize)SoLuongD).EndInit();
            ((System.ComponentModel.ISupportInitialize)SoLuongF).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodAndDrinkBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cáNhânToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private NumericUpDown SoLuongF;
        private Button button1;
        private ComboBox moreBox;
        private ComboBox drinkBox;
        private ComboBox foodBox;
        private TextBox SDTBox;
        private Label label1;
        private ListView listView1;
        private ListView listView2;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BindingSource foodAndDrinkBindingSource;
        private Label label4;
        private Button Ban5;
        private Button Ban4;
        private Button Ban3;
        private Button Ban2;
        private Button Ban6;
        private Button Ban1;
        private DataGridView dataGridView1;
        private Button button9;
        private Panel panel4;
        private Panel panel5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label startTime;
        private Button XoaMon;
        private NumericUpDown SoLuongM;
        private NumericUpDown SoLuongD;
        private Button button3;
        private ToolStripMenuItem điểmDanhToolStripMenuItem;
        private Label nameUser;
        private Label label3;
    }
}