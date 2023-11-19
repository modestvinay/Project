namespace WinFormsApp2
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
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
            label8 = new Label();
            consultingdoctor = new TextBox();
            label9 = new Label();
            currentdate = new DateTimePicker();
            label10 = new Label();
            currenttime = new TextBox();
            label7 = new Label();
            aadhar = new TextBox();
            label12 = new Label();
            cost = new TextBox();
            label11 = new Label();
            procedure = new TextBox();
            savebutton = new Button();
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
            label1.Location = new Point(395, 43);
            label1.Name = "label1";
            label1.Size = new Size(750, 76);
            label1.TabIndex = 2;
            label1.Text = "OPD SERVICES FORM";
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
            label2.TabIndex = 3;
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
            patientname.TabIndex = 4;
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
            label3.TabIndex = 5;
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
            umrid.TabIndex = 6;
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
            label4.TabIndex = 7;
            label4.Text = "DOB:";
            // 
            // dob
            // 
            dob.Anchor = AnchorStyles.Left;
            dob.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            dob.Location = new Point(244, 469);
            dob.Name = "dob";
            dob.Size = new Size(311, 45);
            dob.TabIndex = 8;
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
            label5.TabIndex = 9;
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
            age.TabIndex = 10;
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
            label6.TabIndex = 11;
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
            gender.Size = new Size(189, 50);
            gender.TabIndex = 12;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(139, 634);
            label8.Name = "label8";
            label8.Size = new Size(315, 42);
            label8.TabIndex = 15;
            label8.Text = "Consulting Doctor";
            // 
            // consultingdoctor
            // 
            consultingdoctor.Anchor = AnchorStyles.Left;
            consultingdoctor.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            consultingdoctor.Location = new Point(150, 679);
            consultingdoctor.Name = "consultingdoctor";
            consultingdoctor.PlaceholderText = "Referal Doctor";
            consultingdoctor.Size = new Size(541, 49);
            consultingdoctor.TabIndex = 16;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(1085, 217);
            label9.Name = "label9";
            label9.Size = new Size(69, 29);
            label9.TabIndex = 17;
            label9.Text = "Date:";
            label9.Click += label9_Click;
            // 
            // currentdate
            // 
            currentdate.Anchor = AnchorStyles.Right;
            currentdate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            currentdate.Location = new Point(1160, 217);
            currentdate.Name = "currentdate";
            currentdate.Size = new Size(173, 27);
            currentdate.TabIndex = 18;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(1079, 249);
            label10.Name = "label10";
            label10.Size = new Size(75, 29);
            label10.TabIndex = 19;
            label10.Text = "Time:";
            // 
            // currenttime
            // 
            currenttime.Anchor = AnchorStyles.Right;
            currenttime.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            currenttime.Location = new Point(1160, 255);
            currenttime.Name = "currenttime";
            currenttime.PlaceholderText = "Time";
            currenttime.Size = new Size(173, 23);
            currenttime.TabIndex = 20;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(589, 560);
            label7.Name = "label7";
            label7.Size = new Size(207, 42);
            label7.TabIndex = 21;
            label7.Text = "Aadhar No:";
            // 
            // aadhar
            // 
            aadhar.Anchor = AnchorStyles.Right;
            aadhar.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            aadhar.Location = new Point(792, 557);
            aadhar.Name = "aadhar";
            aadhar.PlaceholderText = "Aadhar No";
            aadhar.Size = new Size(541, 49);
            aadhar.TabIndex = 22;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(783, 634);
            label12.Name = "label12";
            label12.Size = new Size(191, 42);
            label12.TabIndex = 23;
            label12.Text = "Procedure";
            // 
            // cost
            // 
            cost.Anchor = AnchorStyles.Right;
            cost.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            cost.Location = new Point(1072, 679);
            cost.Name = "cost";
            cost.PlaceholderText = "Cost";
            cost.Size = new Size(261, 49);
            cost.TabIndex = 28;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(1063, 634);
            label11.Name = "label11";
            label11.Size = new Size(95, 42);
            label11.TabIndex = 29;
            label11.Text = "Cost";
            label11.Click += label11_Click;
            // 
            // procedure
            // 
            procedure.Anchor = AnchorStyles.Right;
            procedure.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            procedure.Location = new Point(792, 679);
            procedure.Name = "procedure";
            procedure.PlaceholderText = "Procedure";
            procedure.Size = new Size(261, 49);
            procedure.TabIndex = 30;
            // 
            // savebutton
            // 
            savebutton.Anchor = AnchorStyles.Bottom;
            savebutton.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            savebutton.Location = new Point(681, 770);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(129, 51);
            savebutton.TabIndex = 31;
            savebutton.Text = "Save";
            savebutton.UseVisualStyleBackColor = true;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1486, 855);
            Controls.Add(savebutton);
            Controls.Add(procedure);
            Controls.Add(label11);
            Controls.Add(cost);
            Controls.Add(label12);
            Controls.Add(aadhar);
            Controls.Add(label7);
            Controls.Add(currenttime);
            Controls.Add(label10);
            Controls.Add(currentdate);
            Controls.Add(label9);
            Controls.Add(consultingdoctor);
            Controls.Add(label8);
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
            Name = "Form14";
            Text = "Form14";
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
        private Label label8;
        private TextBox consultingdoctor;
        private Label label9;
        private DateTimePicker currentdate;
        private Label label10;
        private TextBox currenttime;
        private Label label7;
        private TextBox aadhar;
        private Label label12;
        private TextBox cost;
        private Label label11;
        private TextBox procedure;
        private Button savebutton;
    }
}