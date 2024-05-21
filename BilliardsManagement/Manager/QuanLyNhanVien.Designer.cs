namespace BilliardsManagement
{
    partial class QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhanVien));
            button4 = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            menuStrip1 = new MenuStrip();
            cáNhânToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            thoátChươngTrìnhToolStripMenuItem = new ToolStripMenuItem();
            button6 = new Button();
            button7 = new Button();
            button5 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(713, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Trở Lại";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(248, 49);
            label1.Name = "label1";
            label1.Size = new Size(281, 73);
            label1.TabIndex = 9;
            label1.Text = "Manager";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(90, 154);
            button1.Name = "button1";
            button1.Size = new Size(126, 113);
            button1.TabIndex = 10;
            button1.Text = "Đổi Mật Khẩu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(566, 154);
            button2.Name = "button2";
            button2.Size = new Size(126, 113);
            button2.TabIndex = 11;
            button2.Text = "Xóa Tài Khoản";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(566, 277);
            button3.Name = "button3";
            button3.Size = new Size(126, 113);
            button3.TabIndex = 12;
            button3.Text = "Danh Sách Tài Khoản";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GrayText;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cáNhânToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // cáNhânToolStripMenuItem
            // 
            cáNhânToolStripMenuItem.BackColor = Color.White;
            cáNhânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, thoátChươngTrìnhToolStripMenuItem });
            cáNhânToolStripMenuItem.Name = "cáNhânToolStripMenuItem";
            cáNhânToolStripMenuItem.Size = new Size(70, 20);
            cáNhânToolStripMenuItem.Text = "Tùy Chọn";
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
            // button6
            // 
            button6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(327, 277);
            button6.Name = "button6";
            button6.Size = new Size(126, 113);
            button6.TabIndex = 15;
            button6.Text = "Lương Nhân Viên";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(90, 277);
            button7.Name = "button7";
            button7.Size = new Size(126, 113);
            button7.TabIndex = 16;
            button7.Text = "Quên Mặt Khẩu";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(327, 154);
            button5.Name = "button5";
            button5.Size = new Size(126, 113);
            button5.TabIndex = 14;
            button5.Text = "Thêm Quản Lý";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(menuStrip1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuanLyNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Viên";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cáNhânToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private Button button6;
        private Button button7;
        private Button button5;
    }
}