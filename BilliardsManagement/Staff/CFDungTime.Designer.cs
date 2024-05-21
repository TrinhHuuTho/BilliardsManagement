namespace BilliardsManagement
{
    partial class CFDungTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFDungTime));
            button1 = new Button();
            button3 = new Button();
            label2 = new Label();
            passText = new TextBox();
            label4 = new Label();
            label1 = new Label();
            userText = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(508, 210);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 21;
            button1.Text = "Trở Lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(393, 210);
            button3.Name = "button3";
            button3.Size = new Size(97, 36);
            button3.TabIndex = 20;
            button3.Text = "Xác Nhận";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 152);
            label2.Name = "label2";
            label2.Size = new Size(554, 19);
            label2.TabIndex = 19;
            label2.Text = "Mật Khẩu                                                                                                                       ";
            // 
            // passText
            // 
            passText.Cursor = Cursors.IBeam;
            passText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passText.Location = new Point(29, 166);
            passText.Name = "passText";
            passText.Size = new Size(554, 26);
            passText.TabIndex = 18;
            passText.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 93);
            label4.Name = "label4";
            label4.Size = new Size(553, 19);
            label4.TabIndex = 17;
            label4.Text = "Tên Đăng Nhập Quản Lý                                                                                              ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(80, 20);
            label1.Name = "label1";
            label1.Size = new Size(461, 55);
            label1.TabIndex = 16;
            label1.Text = "Billiard Management";
            // 
            // userText
            // 
            userText.Cursor = Cursors.IBeam;
            userText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userText.Location = new Point(29, 108);
            userText.Name = "userText";
            userText.Size = new Size(553, 26);
            userText.TabIndex = 15;
            // 
            // CFDungTime
            // 
            AcceptButton = button3;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(617, 258);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(passText);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(userText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CFDungTime";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CFDungTime";
            Load += CFDungTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Label label2;
        private TextBox passText;
        private Label label4;
        private Label label1;
        private TextBox userText;
    }
}