namespace WinFormsApp2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(518, 143);
            label1.Name = "label1";
            label1.Size = new Size(30, 31);
            label1.TabIndex = 0;
            label1.Text = "<";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(518, 264);
            label2.Name = "label2";
            label2.Size = new Size(161, 38);
            label2.TabIndex = 1;
            label2.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(518, 189);
            label3.Name = "label3";
            label3.Size = new Size(196, 54);
            label3.TabIndex = 2;
            label3.Text = "Welcome ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(528, 305);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(442, 43);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(518, 375);
            label4.Name = "label4";
            label4.Size = new Size(138, 38);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(528, 416);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(442, 43);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(518, 485);
            label5.Name = "label5";
            label5.Size = new Size(249, 38);
            label5.TabIndex = 6;
            label5.Text = "Re Enter Password:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(528, 526);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(442, 43);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(528, 625);
            button1.Name = "button1";
            button1.Size = new Size(442, 47);
            button1.TabIndex = 8;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(617, 685);
            label6.Name = "label6";
            label6.Size = new Size(267, 25);
            label6.TabIndex = 10;
            label6.Text = "Already have an account ? Login";
            label6.Click += label6_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1486, 855);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(1504, 848);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Button button1;
        private Label label6;
    }
}