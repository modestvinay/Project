namespace WinFormsApp2
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
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
            pcrid = new TextBox();
            label8 = new Label();
            consultingdoctor = new TextBox();
            label9 = new Label();
            currentdate = new DateTimePicker();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label12 = new Label();
            currenttime = new TextBox();
            label13 = new Label();
            comboBox1 = new ComboBox();
            label14 = new Label();
            textBox1 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            textBox2 = new TextBox();
            label17 = new Label();
            textBox3 = new TextBox();
            label18 = new Label();
            comboBox2 = new ComboBox();
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
            label1.Location = new Point(500, 43);
            label1.Name = "label1";
            label1.Size = new Size(504, 76);
            label1.TabIndex = 3;
            label1.Text = "BILLING FORM";
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
            label2.TabIndex = 4;
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
            patientname.TabIndex = 5;
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
            label3.TabIndex = 6;
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
            umrid.TabIndex = 7;
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
            label4.TabIndex = 8;
            label4.Text = "DOB:";
            // 
            // dob
            // 
            dob.Anchor = AnchorStyles.Left;
            dob.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            dob.Location = new Point(244, 469);
            dob.Name = "dob";
            dob.Size = new Size(311, 45);
            dob.TabIndex = 9;
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
            label5.TabIndex = 10;
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
            age.TabIndex = 11;
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
            label6.TabIndex = 12;
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
            gender.TabIndex = 13;
            gender.SelectedIndexChanged += gender_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(495, 560);
            label7.Name = "label7";
            label7.Size = new Size(153, 42);
            label7.TabIndex = 14;
            label7.Text = "PCR ID:";
            // 
            // pcrid
            // 
            pcrid.Anchor = AnchorStyles.Left;
            pcrid.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            pcrid.Location = new Point(639, 558);
            pcrid.Name = "pcrid";
            pcrid.PlaceholderText = "PCR ID";
            pcrid.Size = new Size(234, 49);
            pcrid.TabIndex = 15;
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
            label8.TabIndex = 16;
            label8.Text = "Consulting Doctor";
            // 
            // consultingdoctor
            // 
            consultingdoctor.Anchor = AnchorStyles.Left;
            consultingdoctor.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            consultingdoctor.Location = new Point(150, 679);
            consultingdoctor.Name = "consultingdoctor";
            consultingdoctor.PlaceholderText = "Consulting Doctor";
            consultingdoctor.Size = new Size(417, 49);
            consultingdoctor.TabIndex = 17;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(618, 658);
            label9.Name = "label9";
            label9.Size = new Size(76, 29);
            label9.TabIndex = 18;
            label9.Text = "From:";
            // 
            // currentdate
            // 
            currentdate.Anchor = AnchorStyles.Right;
            currentdate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            currentdate.Location = new Point(700, 660);
            currentdate.Name = "currentdate";
            currentdate.Size = new Size(173, 27);
            currentdate.TabIndex = 19;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(618, 699);
            label10.Name = "label10";
            label10.Size = new Size(49, 29);
            label10.TabIndex = 20;
            label10.Text = "To:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(700, 701);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(173, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(1085, 217);
            label11.Name = "label11";
            label11.Size = new Size(69, 29);
            label11.TabIndex = 22;
            label11.Text = "Date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Right;
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(1160, 217);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(173, 27);
            dateTimePicker2.TabIndex = 23;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(1079, 249);
            label12.Name = "label12";
            label12.Size = new Size(75, 29);
            label12.TabIndex = 24;
            label12.Text = "Time:";
            // 
            // currenttime
            // 
            currenttime.Anchor = AnchorStyles.Right;
            currenttime.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            currenttime.Location = new Point(1160, 255);
            currenttime.Name = "currenttime";
            currenttime.PlaceholderText = "Time";
            currenttime.Size = new Size(173, 23);
            currenttime.TabIndex = 25;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(885, 335);
            label13.Name = "label13";
            label13.Size = new Size(201, 42);
            label13.TabIndex = 26;
            label13.Text = "Procedure:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dressing", "Blood Test", "General Checkup", "BP Checkup", "Full Body Checkup" });
            comboBox1.Location = new Point(1079, 332);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 45);
            comboBox1.TabIndex = 27;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(981, 386);
            label14.Name = "label14";
            label14.Size = new Size(105, 42);
            label14.TabIndex = 28;
            label14.Text = "Cost:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(1079, 383);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Cost";
            textBox1.Size = new Size(254, 49);
            textBox1.TabIndex = 29;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(891, 435);
            label15.Name = "label15";
            label15.Size = new Size(195, 42);
            label15.TabIndex = 30;
            label15.Text = "Consulting";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(993, 477);
            label16.Name = "label16";
            label16.Size = new Size(93, 42);
            label16.TabIndex = 31;
            label16.Text = "Fee:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(1079, 477);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Fee";
            textBox2.Size = new Size(254, 49);
            textBox2.TabIndex = 32;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonHighlight;
            label17.Location = new Point(975, 535);
            label17.Name = "label17";
            label17.Size = new Size(111, 42);
            label17.TabIndex = 33;
            label17.Text = "Total:";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(1079, 532);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Total";
            textBox3.Size = new Size(254, 49);
            textBox3.TabIndex = 34;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Left;
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(911, 587);
            label18.Name = "label18";
            label18.Size = new Size(175, 42);
            label18.TabIndex = 35;
            label18.Text = "Payment:";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "UPI ", "Cash", "Card" });
            comboBox2.Location = new Point(1079, 587);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(254, 45);
            comboBox2.TabIndex = 36;
            // 
            // savebutton
            // 
            savebutton.Anchor = AnchorStyles.Bottom;
            savebutton.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            savebutton.Location = new Point(501, 762);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(502, 51);
            savebutton.TabIndex = 37;
            savebutton.Text = "SAVE AND PRINT BILL";
            savebutton.UseVisualStyleBackColor = true;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1486, 855);
            Controls.Add(savebutton);
            Controls.Add(comboBox2);
            Controls.Add(label18);
            Controls.Add(textBox3);
            Controls.Add(label17);
            Controls.Add(textBox2);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(textBox1);
            Controls.Add(label14);
            Controls.Add(comboBox1);
            Controls.Add(label13);
            Controls.Add(currenttime);
            Controls.Add(label12);
            Controls.Add(dateTimePicker2);
            Controls.Add(label11);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(currentdate);
            Controls.Add(label9);
            Controls.Add(consultingdoctor);
            Controls.Add(label8);
            Controls.Add(pcrid);
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
            Name = "Form15";
            Text = "Form15";
            Load += Form15_Load;
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
        private TextBox pcrid;
        private Label label8;
        private TextBox consultingdoctor;
        private Label label9;
        private DateTimePicker currentdate;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private TextBox currenttime;
        private Label label13;
        private ComboBox comboBox1;
        private Label label14;
        private TextBox textBox1;
        private Label label15;
        private Label label16;
        private TextBox textBox2;
        private Label label17;
        private TextBox textBox3;
        private Label label18;
        private ComboBox comboBox2;
        private Button savebutton;
    }
}