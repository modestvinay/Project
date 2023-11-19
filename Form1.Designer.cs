namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            patientname = new TextBox();
            label3 = new Label();
            umrid = new TextBox();
            label4 = new Label();
            dob = new DateTimePicker();
            label5 = new Label();
            age = new TextBox();
            label6 = new Label();
            gender = new ComboBox();
            label7 = new Label();
            referaldoctor = new TextBox();
            label8 = new Label();
            currenttime = new TextBox();
            currentdate = new DateTimePicker();
            label9 = new Label();
            photo = new PictureBox();
            capture = new Button();
            label10 = new Label();
            aadhar = new TextBox();
            label12 = new Label();
            label14 = new Label();
            religion = new TextBox();
            profession = new TextBox();
            nextbutton = new Button();
            generateumr = new Button();
            start = new Button();
            ((System.ComponentModel.ISupportInitialize)photo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 40.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(244, 43);
            label1.Name = "label1";
            label1.Size = new Size(1011, 76);
            label1.TabIndex = 0;
            label1.Text = "NEW PATIENT REGISTRATION";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(139, 217);
            label2.Name = "label2";
            label2.Size = new Size(339, 42);
            label2.TabIndex = 1;
            label2.Text = "Patient's Full Name";
            // 
            // patientname
            // 
            patientname.Anchor = AnchorStyles.Left;
            patientname.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            patientname.Location = new Point(150, 262);
            patientname.Name = "patientname";
            patientname.PlaceholderText = "Name";
            patientname.Size = new Size(723, 49);
            patientname.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(139, 335);
            label3.Name = "label3";
            label3.Size = new Size(301, 42);
            label3.TabIndex = 3;
            label3.Text = "Patient's UMR ID";
            // 
            // umrid
            // 
            umrid.Anchor = AnchorStyles.Left;
            umrid.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            umrid.Location = new Point(151, 380);
            umrid.Name = "umrid";
            umrid.PlaceholderText = "UMR ID";
            umrid.Size = new Size(541, 49);
            umrid.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(139, 471);
            label4.Name = "label4";
            label4.Size = new Size(109, 42);
            label4.TabIndex = 5;
            label4.Text = "DOB:";
            // 
            // dob
            // 
            dob.Anchor = AnchorStyles.Left;
            dob.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            dob.Location = new Point(244, 469);
            dob.Name = "dob";
            dob.Size = new Size(311, 45);
            dob.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(610, 470);
            label5.Name = "label5";
            label5.Size = new Size(95, 42);
            label5.TabIndex = 7;
            label5.Text = "Age:";
            // 
            // age
            // 
            age.Anchor = AnchorStyles.Left;
            age.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            age.Location = new Point(700, 468);
            age.Name = "age";
            age.PlaceholderText = "Age";
            age.Size = new Size(173, 49);
            age.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(139, 560);
            label6.Name = "label6";
            label6.Size = new Size(153, 42);
            label6.TabIndex = 9;
            label6.Text = "Gender:";
            // 
            // gender
            // 
            gender.Anchor = AnchorStyles.Left;
            gender.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Female", "Male", "Others" });
            gender.Location = new Point(289, 557);
            gender.Name = "gender";
            gender.Size = new Size(266, 50);
            gender.TabIndex = 10;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(139, 634);
            label7.Name = "label7";
            label7.Size = new Size(258, 42);
            label7.TabIndex = 11;
            label7.Text = "Referal Doctor";
            // 
            // referaldoctor
            // 
            referaldoctor.Anchor = AnchorStyles.Left;
            referaldoctor.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            referaldoctor.Location = new Point(150, 679);
            referaldoctor.Name = "referaldoctor";
            referaldoctor.PlaceholderText = "Referal Doctor";
            referaldoctor.Size = new Size(541, 49);
            referaldoctor.TabIndex = 12;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(1085, 217);
            label8.Name = "label8";
            label8.Size = new Size(69, 29);
            label8.TabIndex = 13;
            label8.Text = "Date:";
            // 
            // currenttime
            // 
            currenttime.Anchor = AnchorStyles.Right;
            currenttime.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            currenttime.Location = new Point(1160, 255);
            currenttime.Name = "currenttime";
            currenttime.PlaceholderText = "Time";
            currenttime.Size = new Size(173, 23);
            currenttime.TabIndex = 14;
            // 
            // currentdate
            // 
            currentdate.Anchor = AnchorStyles.Right;
            currentdate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            currentdate.Location = new Point(1160, 217);
            currentdate.Name = "currentdate";
            currentdate.Size = new Size(173, 27);
            currentdate.TabIndex = 15;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(1079, 249);
            label9.Name = "label9";
            label9.Size = new Size(75, 29);
            label9.TabIndex = 16;
            label9.Text = "Time:";
            // 
            // photo
            // 
            photo.Anchor = AnchorStyles.Right;
            photo.Location = new Point(1160, 309);
            photo.Name = "photo";
            photo.Size = new Size(173, 204);
            photo.TabIndex = 17;
            photo.TabStop = false;
            // 
            // capture
            // 
            capture.Anchor = AnchorStyles.Right;
            capture.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            capture.Location = new Point(1264, 519);
            capture.Name = "capture";
            capture.Size = new Size(69, 29);
            capture.TabIndex = 18;
            capture.Text = "Click";
            capture.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(783, 557);
            label10.Name = "label10";
            label10.Size = new Size(197, 42);
            label10.TabIndex = 19;
            label10.Text = "Aadhar No";
            // 
            // aadhar
            // 
            aadhar.Anchor = AnchorStyles.Right;
            aadhar.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            aadhar.Location = new Point(792, 602);
            aadhar.Name = "aadhar";
            aadhar.PlaceholderText = "Aadhar No";
            aadhar.Size = new Size(541, 49);
            aadhar.TabIndex = 20;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(783, 682);
            label12.Name = "label12";
            label12.Size = new Size(153, 42);
            label12.TabIndex = 21;
            label12.Text = "Religion";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(1060, 686);
            label14.Name = "label14";
            label14.Size = new Size(195, 42);
            label14.TabIndex = 23;
            label14.Text = "Profession";
            // 
            // religion
            // 
            religion.Anchor = AnchorStyles.Right;
            religion.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            religion.Location = new Point(792, 727);
            religion.Name = "religion";
            religion.PlaceholderText = "Religion";
            religion.Size = new Size(257, 49);
            religion.TabIndex = 24;
            // 
            // profession
            // 
            profession.Anchor = AnchorStyles.Right;
            profession.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            profession.Location = new Point(1076, 727);
            profession.Name = "profession";
            profession.PlaceholderText = "Profession";
            profession.Size = new Size(257, 49);
            profession.TabIndex = 26;
            // 
            // nextbutton
            // 
            nextbutton.Anchor = AnchorStyles.Bottom;
            nextbutton.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            nextbutton.Location = new Point(681, 782);
            nextbutton.Name = "nextbutton";
            nextbutton.Size = new Size(129, 51);
            nextbutton.TabIndex = 27;
            nextbutton.Text = "Next";
            nextbutton.UseVisualStyleBackColor = true;
            nextbutton.Click += nextbutton_Click;
            // 
            // generateumr
            // 
            generateumr.Anchor = AnchorStyles.Left;
            generateumr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            generateumr.Location = new Point(717, 380);
            generateumr.Name = "generateumr";
            generateumr.Size = new Size(156, 49);
            generateumr.TabIndex = 28;
            generateumr.Text = "Generate UMR";
            generateumr.UseVisualStyleBackColor = true;
            generateumr.Click += generateumr_Click;
            // 
            // start
            // 
            start.Anchor = AnchorStyles.Right;
            start.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            start.Location = new Point(1160, 519);
            start.Name = "start";
            start.Size = new Size(69, 29);
            start.TabIndex = 29;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1486, 855);
            Controls.Add(start);
            Controls.Add(generateumr);
            Controls.Add(nextbutton);
            Controls.Add(profession);
            Controls.Add(religion);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(aadhar);
            Controls.Add(label10);
            Controls.Add(capture);
            Controls.Add(photo);
            Controls.Add(label9);
            Controls.Add(currentdate);
            Controls.Add(currenttime);
            Controls.Add(label8);
            Controls.Add(referaldoctor);
            Controls.Add(label7);
            Controls.Add(gender);
            Controls.Add(label6);
            Controls.Add(age);
            Controls.Add(label5);
            Controls.Add(dob);
            Controls.Add(label4);
            Controls.Add(umrid);
            Controls.Add(label3);
            Controls.Add(patientname);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(1504, 848);
            Name = "Form1";
            Text = "0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)photo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox patientname;
        private Label label3;
        private TextBox umrid;
        private Label label4;
        private DateTimePicker dob;
        private Label label5;
        private TextBox age;
        private Label label6;
        private ComboBox gender;
        private Label label7;
        private TextBox referaldoctor;
        private Label label8;
        private TextBox currenttime;
        private DateTimePicker currentdate;
        private Label label9;
        private PictureBox photo;
        private Button capture;
        private Label label10;
        private TextBox aadhar;
        private Label label12;
        private Label label14;
        private TextBox religion;
        private TextBox profession;
        private Button nextbutton;
        private Button generateumr;
        private Button start;
    }
}