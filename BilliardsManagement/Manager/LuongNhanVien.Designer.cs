namespace BilliardsManagement
{
    partial class LuongNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuongNhanVien));
            label1 = new Label();
            label4 = new Label();
            delBox = new ComboBox();
            label2 = new Label();
            SoGiolam = new TextBox();
            label3 = new Label();
            LuongTra = new TextBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(113, 25);
            label1.Name = "label1";
            label1.Size = new Size(209, 55);
            label1.TabIndex = 6;
            label1.Text = "Manager";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(58, 111);
            label4.Name = "label4";
            label4.Size = new Size(330, 19);
            label4.TabIndex = 23;
            label4.Text = "Chọn Nhân Viên                                                     ";
            // 
            // delBox
            // 
            delBox.DropDownStyle = ComboBoxStyle.DropDownList;
            delBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delBox.FormattingEnabled = true;
            delBox.ImeMode = ImeMode.NoControl;
            delBox.Items.AddRange(new object[] { "Đồ Ăn", "Đồ Uống", "Món Khác" });
            delBox.Location = new Point(58, 126);
            delBox.Name = "delBox";
            delBox.Size = new Size(330, 27);
            delBox.TabIndex = 22;
            delBox.SelectedIndexChanged += delBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 177);
            label2.Name = "label2";
            label2.Size = new Size(329, 19);
            label2.TabIndex = 35;
            label2.Text = "Số Giờ Làm                                                            ";
            // 
            // SoGiolam
            // 
            SoGiolam.Cursor = Cursors.IBeam;
            SoGiolam.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SoGiolam.Location = new Point(58, 192);
            SoGiolam.Name = "SoGiolam";
            SoGiolam.ReadOnly = true;
            SoGiolam.Size = new Size(329, 26);
            SoGiolam.TabIndex = 34;
            SoGiolam.TextChanged += TongTien_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 240);
            label3.Name = "label3";
            label3.Size = new Size(329, 19);
            label3.TabIndex = 37;
            label3.Text = "Lương Trả                                                              ";
            // 
            // LuongTra
            // 
            LuongTra.Cursor = Cursors.IBeam;
            LuongTra.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LuongTra.Location = new Point(58, 256);
            LuongTra.Name = "LuongTra";
            LuongTra.ReadOnly = true;
            LuongTra.Size = new Size(329, 26);
            LuongTra.TabIndex = 36;
            LuongTra.TextChanged += LuongTra_TextChanged;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(226, 311);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 39;
            button2.Text = "Trả Lương";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(338, 311);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 38;
            button1.Text = "Trở Lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LuongNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(447, 363);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(LuongTra);
            Controls.Add(label2);
            Controls.Add(SoGiolam);
            Controls.Add(label4);
            Controls.Add(delBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LuongNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LuongNhanVien";
            Load += LuongNhanVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private ComboBox delBox;
        private Label label2;
        private TextBox SoGiolam;
        private Label label3;
        private TextBox LuongTra;
        private Button button2;
        private Button button1;
    }
}