namespace BilliardsManagement
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            label4 = new Label();
            nameText = new TextBox();
            label2 = new Label();
            numbText = new TextBox();
            label3 = new Label();
            userText = new TextBox();
            label5 = new Label();
            passText = new TextBox();
            label6 = new Label();
            passAText = new TextBox();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(83, 21);
            label1.Name = "label1";
            label1.Size = new Size(461, 55);
            label1.TabIndex = 2;
            label1.Text = "Billiard Management";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 103);
            label4.Name = "label4";
            label4.Size = new Size(554, 19);
            label4.TabIndex = 12;
            label4.Text = "Họ Và Tên                                                                                                                      ";
            // 
            // nameText
            // 
            nameText.Cursor = Cursors.IBeam;
            nameText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameText.Location = new Point(44, 118);
            nameText.Name = "nameText";
            nameText.Size = new Size(554, 26);
            nameText.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 171);
            label2.Name = "label2";
            label2.Size = new Size(556, 19);
            label2.TabIndex = 14;
            label2.Text = "Số Điện Thoại                                                                                                                 ";
            // 
            // numbText
            // 
            numbText.Cursor = Cursors.IBeam;
            numbText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numbText.Location = new Point(44, 186);
            numbText.Name = "numbText";
            numbText.Size = new Size(556, 26);
            numbText.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(44, 240);
            label3.Name = "label3";
            label3.Size = new Size(555, 19);
            label3.TabIndex = 16;
            label3.Text = "Tên Đăng Nhập                                                                                                              ";
            // 
            // userText
            // 
            userText.Cursor = Cursors.IBeam;
            userText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userText.Location = new Point(44, 255);
            userText.Name = "userText";
            userText.Size = new Size(555, 26);
            userText.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(44, 309);
            label5.Name = "label5";
            label5.Size = new Size(554, 19);
            label5.TabIndex = 18;
            label5.Text = "Nhập Mật Khẩu                                                                                                             ";
            // 
            // passText
            // 
            passText.Cursor = Cursors.IBeam;
            passText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passText.Location = new Point(44, 324);
            passText.Name = "passText";
            passText.Size = new Size(555, 26);
            passText.TabIndex = 17;
            passText.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(44, 376);
            label6.Name = "label6";
            label6.Size = new Size(556, 19);
            label6.TabIndex = 20;
            label6.Text = "Nhập Lại Mật Khẩu                                                                                                       ";
            // 
            // passAText
            // 
            passAText.Cursor = Cursors.IBeam;
            passAText.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passAText.Location = new Point(44, 391);
            passAText.Name = "passAText";
            passAText.Size = new Size(556, 26);
            passAText.TabIndex = 19;
            passAText.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(532, 459);
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
            button3.Location = new Point(412, 459);
            button3.Name = "button3";
            button3.Size = new Size(97, 36);
            button3.TabIndex = 22;
            button3.Text = "Đăng Ký";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SignUp
            // 
            AcceptButton = button3;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            ClientSize = new Size(641, 510);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(passAText);
            Controls.Add(label5);
            Controls.Add(passText);
            Controls.Add(label3);
            Controls.Add(userText);
            Controls.Add(label2);
            Controls.Add(numbText);
            Controls.Add(label4);
            Controls.Add(nameText);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox nameText;
        private Label label2;
        private TextBox numbText;
        private Label label3;
        private TextBox userText;
        private Label label5;
        private TextBox passText;
        private Label label6;
        private TextBox passAText;
        private Button button1;
        private Button button3;
    }
}