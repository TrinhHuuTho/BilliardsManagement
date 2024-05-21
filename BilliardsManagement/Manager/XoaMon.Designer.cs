namespace BilliardsManagement
{
    partial class XoaMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XoaMon));
            label1 = new Label();
            delBox = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 55);
            label1.TabIndex = 3;
            label1.Text = "Manager";
            // 
            // delBox
            // 
            delBox.DropDownStyle = ComboBoxStyle.DropDownList;
            delBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delBox.FormattingEnabled = true;
            delBox.ImeMode = ImeMode.NoControl;
            delBox.Items.AddRange(new object[] { "Đồ Ăn", "Đồ Uống", "Món Khác" });
            delBox.Location = new Point(44, 111);
            delBox.Name = "delBox";
            delBox.Size = new Size(610, 27);
            delBox.TabIndex = 20;
            delBox.SelectedIndexChanged += delBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 92);
            label4.Name = "label4";
            label4.Size = new Size(610, 19);
            label4.TabIndex = 21;
            label4.Text = "Chọn Món Cần Xóa                                                                                                                     ";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(593, 166);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 22;
            button1.Text = "Trở Lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(481, 166);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 23;
            button2.Text = "Xóa Món";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // XoaMon
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 218);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(delBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "XoaMon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XoaMon";
            Load += XoaMon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox delBox;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}