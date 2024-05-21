namespace BilliardsManagement
{
    partial class DMKQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMKQL));
            label3 = new Label();
            passAAText = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            passAText = new TextBox();
            label5 = new Label();
            passText = new TextBox();
            label4 = new Label();
            userText = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 349);
            label3.Name = "label3";
            label3.Size = new Size(557, 19);
            label3.TabIndex = 37;
            label3.Text = "Nhập Lại Mật Khẩu Mới                                                                                               ";
            // 
            // passAAText
            // 
            passAAText.Cursor = Cursors.IBeam;
            passAAText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passAAText.Location = new Point(50, 365);
            passAAText.Name = "passAAText";
            passAAText.Size = new Size(557, 26);
            passAAText.TabIndex = 36;
            passAAText.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(548, 419);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 35;
            button2.Text = "Trở Lại";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(429, 419);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 34;
            button1.Text = "Cập Nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 277);
            label2.Name = "label2";
            label2.Size = new Size(555, 19);
            label2.TabIndex = 33;
            label2.Text = "Nhập Mật Khẩu Mới                                                                                                     ";
            // 
            // passAText
            // 
            passAText.Cursor = Cursors.IBeam;
            passAText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passAText.Location = new Point(50, 293);
            passAText.Name = "passAText";
            passAText.Size = new Size(555, 26);
            passAText.TabIndex = 32;
            passAText.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(50, 203);
            label5.Name = "label5";
            label5.Size = new Size(554, 19);
            label5.TabIndex = 31;
            label5.Text = "Nhập Mật Khẩu                                                                                                             ";
            // 
            // passText
            // 
            passText.Cursor = Cursors.IBeam;
            passText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passText.Location = new Point(50, 219);
            passText.Name = "passText";
            passText.Size = new Size(554, 26);
            passText.TabIndex = 30;
            passText.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 127);
            label4.Name = "label4";
            label4.Size = new Size(555, 19);
            label4.TabIndex = 29;
            label4.Text = "Tên Đăng Nhập                                                                                                              ";
            // 
            // userText
            // 
            userText.Cursor = Cursors.IBeam;
            userText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userText.Location = new Point(50, 143);
            userText.Name = "userText";
            userText.Size = new Size(555, 26);
            userText.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(56, 39);
            label1.Name = "label1";
            label1.Size = new Size(538, 55);
            label1.TabIndex = 27;
            label1.Text = "TÀI KHOẢN QUẢN LÝ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // DMKQL
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(662, 469);
            Controls.Add(label3);
            Controls.Add(passAAText);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(passAText);
            Controls.Add(label5);
            Controls.Add(passText);
            Controls.Add(label4);
            Controls.Add(userText);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DMKQL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DMKQL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox passAAText;
        private Button button2;
        private Button button1;
        private Label label2;
        private TextBox passAText;
        private Label label5;
        private TextBox passText;
        private Label label4;
        private TextBox userText;
        private Label label1;
    }
}