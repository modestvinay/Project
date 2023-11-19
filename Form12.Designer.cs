namespace WinFormsApp2
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            button6 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(540, 53);
            label1.Name = "label1";
            label1.Size = new Size(401, 81);
            label1.TabIndex = 1;
            label1.Text = "DASH BOARD";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(195, 255);
            button2.Name = "button2";
            button2.Size = new Size(474, 64);
            button2.TabIndex = 4;
            button2.Text = "SWIFT COLLECTION";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(195, 425);
            button1.Name = "button1";
            button1.Size = new Size(474, 64);
            button1.TabIndex = 5;
            button1.Text = "DAY COLLECTION";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(195, 595);
            button3.Name = "button3";
            button3.Size = new Size(474, 64);
            button3.TabIndex = 6;
            button3.Text = "DUE COLLECTION";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(835, 255);
            button5.Name = "button5";
            button5.Size = new Size(474, 64);
            button5.TabIndex = 7;
            button5.Text = "DUE REPORTS";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(835, 425);
            button4.Name = "button4";
            button4.Size = new Size(474, 64);
            button4.TabIndex = 8;
            button4.Text = "BETWEEN DATES COLLECTION SUMMARY";
            button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left;
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(835, 595);
            button6.Name = "button6";
            button6.Size = new Size(474, 64);
            button6.TabIndex = 9;
            button6.Text = "DOCTOR WISE COLLECTION SUMMARY";
            button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Left;
            button8.BackColor = SystemColors.ButtonHighlight;
            button8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(515, 745);
            button8.Name = "button8";
            button8.Size = new Size(474, 64);
            button8.TabIndex = 10;
            button8.Text = "FINANCIAL REPORTS";
            button8.UseVisualStyleBackColor = false;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1486, 855);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            MinimumSize = new Size(1504, 848);
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button8;
    }
}