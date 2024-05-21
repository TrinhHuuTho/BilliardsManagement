namespace BilliardsManagement
{
    partial class LBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LBill));
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            ThanhTien = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(622, 441);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 31;
            button1.Text = "Trở Lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 243);
            dataGridView1.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 98);
            label4.Name = "label4";
            label4.Size = new Size(642, 19);
            label4.TabIndex = 29;
            label4.Text = "Danh Sách Bill Tháng Này                                                                                                                  ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(250, 19);
            label1.Name = "label1";
            label1.Size = new Size(209, 55);
            label1.TabIndex = 28;
            label1.Text = "Manager";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(44, 380);
            label5.Name = "label5";
            label5.Size = new Size(639, 19);
            label5.TabIndex = 41;
            label5.Text = "Tổng Doanh Thu Tháng Này                                                                                                              ";
            // 
            // ThanhTien
            // 
            ThanhTien.AllowDrop = true;
            ThanhTien.Cursor = Cursors.IBeam;
            ThanhTien.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ThanhTien.Location = new Point(44, 395);
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            ThanhTien.Size = new Size(639, 26);
            ThanhTien.TabIndex = 40;
            ThanhTien.TextChanged += ThanhTien_TextChanged;
            // 
            // LBill
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(731, 489);
            Controls.Add(label5);
            Controls.Add(ThanhTien);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill Trong Tháng             ";
            Load += LBill_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label1;
        private Label label5;
        private TextBox ThanhTien;
    }
}