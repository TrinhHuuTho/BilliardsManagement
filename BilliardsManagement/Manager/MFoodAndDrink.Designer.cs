namespace BilliardsManagement
{
    partial class MFoodAndDrink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MFoodAndDrink));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            cáNhânToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            thoátChươngTrìnhToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(261, 55);
            label1.Name = "label1";
            label1.Size = new Size(281, 73);
            label1.TabIndex = 3;
            label1.Text = "Manager";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(161, 188);
            button1.Name = "button1";
            button1.Size = new Size(126, 113);
            button1.TabIndex = 4;
            button1.Text = "Thêm Món";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(521, 188);
            button2.Name = "button2";
            button2.Size = new Size(126, 113);
            button2.TabIndex = 5;
            button2.Text = "Xóa Món";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(713, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Trở Lại";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GrayText;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cáNhânToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 8;
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
            // button3
            // 
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(341, 254);
            button3.Name = "button3";
            button3.Size = new Size(126, 113);
            button3.TabIndex = 9;
            button3.Text = "Danh Sách Món";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MFoodAndDrink
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(menuStrip1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MFoodAndDrink";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Món";
            Load += MFoodAndDrink_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cáNhânToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private Button button3;
    }
}