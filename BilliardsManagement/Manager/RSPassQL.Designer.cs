﻿namespace BilliardsManagement
{
    partial class RSPassQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSPassQL));
            label4 = new Label();
            delBox = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(41, 90);
            label4.Name = "label4";
            label4.Size = new Size(330, 19);
            label4.TabIndex = 34;
            label4.Text = "Chọn Tài Khoản                                                     ";
            // 
            // delBox
            // 
            delBox.DropDownStyle = ComboBoxStyle.DropDownList;
            delBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delBox.FormattingEnabled = true;
            delBox.ImeMode = ImeMode.NoControl;
            delBox.Items.AddRange(new object[] { "Đồ Ăn", "Đồ Uống", "Món Khác" });
            delBox.Location = new Point(41, 105);
            delBox.Name = "delBox";
            delBox.Size = new Size(330, 27);
            delBox.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(74, 18);
            label1.Name = "label1";
            label1.Size = new Size(246, 55);
            label1.TabIndex = 32;
            label1.Text = "QUẢN LÝ";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(299, 170);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 31;
            button2.Text = "Trở Lại";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(168, 170);
            button1.Name = "button1";
            button1.Size = new Size(117, 36);
            button1.TabIndex = 30;
            button1.Text = "Reset Mặt Khẩu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RSPassQL
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(405, 217);
            Controls.Add(label4);
            Controls.Add(delBox);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RSPassQL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RSPassQL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox delBox;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}