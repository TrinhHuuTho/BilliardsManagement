namespace BilliardsManagement
{
    partial class XTKQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XTKQL));
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            delBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(584, 179);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 30;
            button1.Text = "Trở Lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(466, 179);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 29;
            button2.Text = "Xóa ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 113);
            label4.Name = "label4";
            label4.Size = new Size(608, 19);
            label4.TabIndex = 28;
            label4.Text = "Chọn Tài Khoản Cần Xóa                                                                                                           ";
            // 
            // delBox
            // 
            delBox.DropDownStyle = ComboBoxStyle.DropDownList;
            delBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delBox.FormattingEnabled = true;
            delBox.ImeMode = ImeMode.NoControl;
            delBox.Items.AddRange(new object[] { "Đồ Ăn", "Đồ Uống", "Món Khác" });
            delBox.Location = new Point(34, 132);
            delBox.Name = "delBox";
            delBox.Size = new Size(608, 27);
            delBox.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(64, 40);
            label1.Name = "label1";
            label1.Size = new Size(538, 55);
            label1.TabIndex = 26;
            label1.Text = "TÀI KHOẢN QUẢN LÝ";
            // 
            // XTKQL
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(694, 227);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(delBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "XTKQL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XTKQL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label4;
        private ComboBox delBox;
        private Label label1;
    }
}