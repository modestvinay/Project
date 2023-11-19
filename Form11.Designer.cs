namespace WinFormsApp2
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(540, 53);
            label1.Name = "label1";
            label1.Size = new Size(424, 81);
            label1.TabIndex = 0;
            label1.Text = "DASH BOARD";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(300, 182);
            button1.Name = "button1";
            button1.Size = new Size(252, 64);
            button1.TabIndex = 1;
            button1.Text = "MY PROFILE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(195, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 88);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(195, 317);
            button2.Name = "button2";
            button2.Size = new Size(474, 64);
            button2.TabIndex = 3;
            button2.Text = "NEW PATIENT REGISTRATION";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(195, 450);
            button3.Name = "button3";
            button3.Size = new Size(474, 64);
            button3.TabIndex = 4;
            button3.Text = "OPD SERVICES";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(195, 579);
            button4.Name = "button4";
            button4.Size = new Size(474, 64);
            button4.TabIndex = 5;
            button4.Text = "PRINT RECEIPTS";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(835, 317);
            button5.Name = "button5";
            button5.Size = new Size(474, 64);
            button5.TabIndex = 6;
            button5.Text = "CONSULTATION";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left;
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(835, 450);
            button6.Name = "button6";
            button6.Size = new Size(474, 64);
            button6.TabIndex = 7;
            button6.Text = "DUES CONSULTATION";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Left;
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(835, 579);
            button7.Name = "button7";
            button7.Size = new Size(474, 64);
            button7.TabIndex = 8;
            button7.Text = "BOOK APPOINTMENT";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Left;
            button8.BackColor = SystemColors.ButtonHighlight;
            button8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(515, 709);
            button8.Name = "button8";
            button8.Size = new Size(474, 64);
            button8.TabIndex = 9;
            button8.Text = "FINANCIAL REPORTS";
            button8.UseVisualStyleBackColor = false;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1486, 855);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            MinimumSize = new Size(1504, 848);
            Name = "Form11";
            Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}