namespace BilliardsManagement
{
    partial class XoaMonBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XoaMonBill));
            label4 = new Label();
            label1 = new Label();
            delBox = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            SoLuong = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)SoLuong).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(94, 9);
            label4.Name = "label4";
            label4.Size = new Size(461, 55);
            label4.TabIndex = 8;
            label4.Text = "Billiard Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 97);
            label1.Name = "label1";
            label1.Size = new Size(610, 19);
            label1.TabIndex = 23;
            label1.Text = "Chọn Món Cần Xóa                                                                                                                     ";
            // 
            // delBox
            // 
            delBox.DropDownStyle = ComboBoxStyle.DropDownList;
            delBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delBox.FormattingEnabled = true;
            delBox.ImeMode = ImeMode.NoControl;
            delBox.Items.AddRange(new object[] { "Đồ Ăn", "Đồ Uống", "Món Khác" });
            delBox.Location = new Point(24, 116);
            delBox.Name = "delBox";
            delBox.Size = new Size(610, 27);
            delBox.TabIndex = 22;
            delBox.SelectedIndexChanged += delBox_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(434, 206);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 25;
            button2.Text = "Xóa Món";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(549, 206);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 24;
            button1.Text = "Trở Lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SoLuong
            // 
            SoLuong.Cursor = Cursors.Hand;
            SoLuong.Location = new Point(279, 160);
            SoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SoLuong.Name = "SoLuong";
            SoLuong.Size = new Size(93, 23);
            SoLuong.TabIndex = 26;
            SoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // XoaMonBill
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(658, 254);
            Controls.Add(SoLuong);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(delBox);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "XoaMonBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xóa Món";
            Load += XoaMonBill_Load;
            ((System.ComponentModel.ISupportInitialize)SoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private ComboBox delBox;
        private Button button2;
        private Button button1;
        private NumericUpDown SoLuong;
    }
}