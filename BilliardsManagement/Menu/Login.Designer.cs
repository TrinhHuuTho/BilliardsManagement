namespace BilliardsManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            userText = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            passText = new TextBox();
            button3 = new Button();
            button1 = new Button();
            check = new CheckBox();
            SuspendLayout();
            // 
            // userText
            // 
            userText.Cursor = Cursors.IBeam;
            userText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userText.Location = new Point(19, 110);
            userText.Name = "userText";
            userText.Size = new Size(555, 26);
            userText.TabIndex = 5;
            userText.TextChanged += userText_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(70, 22);
            label1.Name = "label1";
            label1.Size = new Size(461, 55);
            label1.TabIndex = 9;
            label1.Text = "Billiard Management";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 95);
            label4.Name = "label4";
            label4.Size = new Size(555, 19);
            label4.TabIndex = 10;
            label4.Text = "Tên Đăng Nhập                                                                                                              ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 154);
            label2.Name = "label2";
            label2.Size = new Size(554, 19);
            label2.TabIndex = 12;
            label2.Text = "Mật Khẩu                                                                                                                       ";
            // 
            // passText
            // 
            passText.Cursor = Cursors.IBeam;
            passText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passText.Location = new Point(19, 168);
            passText.Name = "passText";
            passText.Size = new Size(554, 26);
            passText.TabIndex = 11;
            passText.UseSystemPasswordChar = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(371, 221);
            button3.Name = "button3";
            button3.Size = new Size(97, 36);
            button3.TabIndex = 13;
            button3.Text = "Đăng Nhập";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(485, 221);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 14;
            button1.Text = "Trở Lại";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // check
            // 
            check.AutoSize = true;
            check.BackColor = Color.Transparent;
            check.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            check.ForeColor = SystemColors.ActiveCaptionText;
            check.Location = new Point(131, 210);
            check.Name = "check";
            check.Size = new Size(192, 26);
            check.TabIndex = 15;
            check.Text = "Tài Khoản Quản Lý";
            check.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AcceptButton = button3;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(594, 269);
            Controls.Add(check);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(passText);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(userText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userText;
        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox passText;
        private Button button3;
        private Button button1;
        private CheckBox check;
    }
}