namespace BilliardsManagement
{
    partial class ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToan));
            button1 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ban = new Label();
            button2 = new Button();
            label1 = new Label();
            sdtText = new TextBox();
            label2 = new Label();
            TongTien = new TextBox();
            GioChoi = new Label();
            button3 = new Button();
            label3 = new Label();
            solanBox = new TextBox();
            label5 = new Label();
            ThanhTien = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(397, 615);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 25;
            button1.Text = "Trở Lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(24, 9);
            label4.Name = "label4";
            label4.Size = new Size(461, 55);
            label4.TabIndex = 26;
            label4.Text = "Billiard Management";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(461, 224);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ban
            // 
            ban.AutoSize = true;
            ban.BackColor = Color.Transparent;
            ban.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            ban.ForeColor = SystemColors.Info;
            ban.Location = new Point(22, 85);
            ban.Name = "ban";
            ban.Size = new Size(74, 32);
            ban.TabIndex = 28;
            ban.Text = "Bàn:";
            ban.Click += label1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Green;
            button2.Location = new Point(294, 615);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 29;
            button2.Text = "Thanh Toán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 364);
            label1.Name = "label1";
            label1.Size = new Size(459, 19);
            label1.TabIndex = 31;
            label1.Text = "Số Điện Thoại Khách                                                                             ";
            // 
            // sdtText
            // 
            sdtText.AllowDrop = true;
            sdtText.Cursor = Cursors.IBeam;
            sdtText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sdtText.Location = new Point(22, 379);
            sdtText.Name = "sdtText";
            sdtText.ReadOnly = true;
            sdtText.Size = new Size(459, 26);
            sdtText.TabIndex = 30;
            sdtText.TextChanged += userText_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 427);
            label2.Name = "label2";
            label2.Size = new Size(457, 19);
            label2.TabIndex = 33;
            label2.Text = "Tổng Tiền                                                                                               ";
            // 
            // TongTien
            // 
            TongTien.Cursor = Cursors.IBeam;
            TongTien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TongTien.Location = new Point(22, 442);
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Size = new Size(457, 26);
            TongTien.TabIndex = 32;
            // 
            // GioChoi
            // 
            GioChoi.AutoSize = true;
            GioChoi.BackColor = Color.Transparent;
            GioChoi.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            GioChoi.ForeColor = SystemColors.Info;
            GioChoi.Location = new Point(177, 85);
            GioChoi.Name = "GioChoi";
            GioChoi.Size = new Size(175, 32);
            GioChoi.TabIndex = 34;
            GioChoi.Text = "Số Giờ Chơi:";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 629);
            button3.Name = "button3";
            button3.Size = new Size(58, 24);
            button3.TabIndex = 35;
            button3.Text = "Lưu Ý";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 490);
            label3.Name = "label3";
            label3.Size = new Size(459, 19);
            label3.TabIndex = 37;
            label3.Text = "Số Lần Khách Ghé                                                                                 ";
            // 
            // solanBox
            // 
            solanBox.AllowDrop = true;
            solanBox.Cursor = Cursors.IBeam;
            solanBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            solanBox.Location = new Point(22, 505);
            solanBox.Name = "solanBox";
            solanBox.ReadOnly = true;
            solanBox.Size = new Size(459, 26);
            solanBox.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 554);
            label5.Name = "label5";
            label5.Size = new Size(457, 19);
            label5.TabIndex = 39;
            label5.Text = "Thành Tiền                                                                                             ";
            // 
            // ThanhTien
            // 
            ThanhTien.AllowDrop = true;
            ThanhTien.Cursor = Cursors.IBeam;
            ThanhTien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ThanhTien.Location = new Point(22, 569);
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            ThanhTien.Size = new Size(457, 26);
            ThanhTien.TabIndex = 38;
            ThanhTien.TextChanged += textBox2_TextChanged;
            // 
            // ThanhToan
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(506, 665);
            Controls.Add(label5);
            Controls.Add(ThanhTien);
            Controls.Add(label3);
            Controls.Add(solanBox);
            Controls.Add(button3);
            Controls.Add(GioChoi);
            Controls.Add(label2);
            Controls.Add(TongTien);
            Controls.Add(label1);
            Controls.Add(sdtText);
            Controls.Add(button2);
            Controls.Add(ban);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh Toán";
            Load += ThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private DataGridView dataGridView1;
        private Label ban;
        private Button button2;
        private Label label1;
        private TextBox sdtText;
        private Label label2;
        private TextBox TongTien;
        private Label GioChoi;
        private Button button3;
        private Label label3;
        private TextBox solanBox;
        private Label label5;
        private TextBox ThanhTien;
    }
}