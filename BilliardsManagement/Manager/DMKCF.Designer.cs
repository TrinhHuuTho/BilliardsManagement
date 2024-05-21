namespace BilliardsManagement
{
    partial class DMKCF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMKCF));
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(125, 35);
            button6.Name = "button6";
            button6.Size = new Size(126, 113);
            button6.TabIndex = 16;
            button6.Text = "Tài Khoản Nhân Viên";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(432, 35);
            button1.Name = "button1";
            button1.Size = new Size(126, 113);
            button1.TabIndex = 17;
            button1.Text = "Tài Khoản Quản Lý";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(298, 164);
            button2.Name = "button2";
            button2.Size = new Size(97, 36);
            button2.TabIndex = 36;
            button2.Text = "Trở Lại";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DMKCF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 225);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DMKCF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DMKCF";
            Load += DMKCF_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button6;
        private Button button1;
        private Button button2;
    }
}