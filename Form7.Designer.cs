namespace WinFormsApp2
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(571, 193);
            label1.Name = "label1";
            label1.Size = new Size(36, 38);
            label1.TabIndex = 0;
            label1.Text = "<";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(580, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 49);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(633, 254);
            label2.Name = "label2";
            label2.Size = new Size(280, 38);
            label2.TabIndex = 2;
            label2.Text = "CHANGE PASSWORD";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(571, 313);
            label3.Name = "label3";
            label3.Size = new Size(177, 28);
            label3.TabIndex = 3;
            label3.Text = "Current Password : ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(580, 344);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 43);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(571, 415);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 5;
            label4.Text = "New Password : ";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(580, 446);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 43);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(571, 516);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 7;
            label5.Text = "Re Enter Password : ";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(580, 547);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 43);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(676, 623);
            button1.Name = "button1";
            button1.Size = new Size(124, 45);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1486, 855);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MinimumSize = new Size(1504, 848);
            Name = "Form7";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Button button1;
    }
}