namespace BilliardsManagement
{
    partial class ThemMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemMon));
            typeBox = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            nameText = new TextBox();
            label3 = new Label();
            priceText = new TextBox();
            button1 = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // typeBox
            // 
            typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            typeBox.FormattingEnabled = true;
            typeBox.ImeMode = ImeMode.NoControl;
            typeBox.Items.AddRange(new object[] { "Đồ Ăn", "Đồ Uống", "Món Khác" });
            typeBox.Location = new Point(205, 203);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(144, 27);
            typeBox.TabIndex = 19;
            typeBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            typeBox.DropDownStyleChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(178, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 55);
            label1.TabIndex = 2;
            label1.Text = "Manager";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 73);
            label4.Name = "label4";
            label4.Size = new Size(555, 19);
            label4.TabIndex = 12;
            label4.Text = "Tên Món                                                                                                                         ";
            // 
            // nameText
            // 
            nameText.Cursor = Cursors.IBeam;
            nameText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameText.Location = new Point(12, 88);
            nameText.Name = "nameText";
            nameText.Size = new Size(555, 26);
            nameText.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(555, 19);
            label3.TabIndex = 16;
            label3.Text = "Giá Tiền                                                                                                                          ";
            // 
            // priceText
            // 
            priceText.Cursor = Cursors.IBeam;
            priceText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceText.Location = new Point(12, 149);
            priceText.Name = "priceText";
            priceText.Size = new Size(555, 26);
            priceText.TabIndex = 15;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(477, 256);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 17;
            button1.Text = "Trở Lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(362, 256);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 18;
            button2.Text = "Thêm Món";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ThemMon
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(586, 303);
            Controls.Add(typeBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(priceText);
            Controls.Add(label4);
            Controls.Add(nameText);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ThemMon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemMon";
            Load += ThemMon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox nameText;
        private Label label3;
        private TextBox priceText;
        private Button button1;
        private Button button2;
        private ComboBox typeBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}