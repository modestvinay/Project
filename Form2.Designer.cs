namespace WinFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label2 = new Label();
            phone = new TextBox();
            label3 = new Label();
            pincode = new TextBox();
            city = new TextBox();
            house = new TextBox();
            area = new TextBox();
            state = new TextBox();
            label4 = new Label();
            mail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            contactname = new TextBox();
            label7 = new Label();
            contactphone = new TextBox();
            savebutton = new Button();
            label1 = new Label();
            SuspendLayout();
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
            label2.Size = new Size(269, 42);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // phone
            // 
            phone.Anchor = AnchorStyles.Left;
            phone.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(150, 262);
            phone.Name = "phone";
            phone.PlaceholderText = "Phone no.";
            phone.Size = new Size(541, 49);
            phone.TabIndex = 5;
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
            label3.Size = new Size(156, 42);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // pincode
            // 
            pincode.Anchor = AnchorStyles.Left;
            pincode.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            pincode.Location = new Point(151, 380);
            pincode.Name = "pincode";
            pincode.PlaceholderText = "Pincode";
            pincode.Size = new Size(257, 49);
            pincode.TabIndex = 7;
            // 
            // city
            // 
            city.Anchor = AnchorStyles.Left;
            city.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            city.Location = new Point(434, 380);
            city.Name = "city";
            city.PlaceholderText = "City";
            city.Size = new Size(257, 49);
            city.TabIndex = 9;
            // 
            // house
            // 
            house.Anchor = AnchorStyles.Left;
            house.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            house.Location = new Point(151, 636);
            house.Name = "house";
            house.PlaceholderText = "House/Flat No.";
            house.Size = new Size(541, 49);
            house.TabIndex = 10;
            // 
            // area
            // 
            area.Anchor = AnchorStyles.Left;
            area.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            area.Location = new Point(151, 548);
            area.Name = "area";
            area.PlaceholderText = "Area/Street";
            area.Size = new Size(541, 49);
            area.TabIndex = 11;
            // 
            // state
            // 
            state.Anchor = AnchorStyles.Left;
            state.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            state.Location = new Point(151, 466);
            state.Name = "state";
            state.PlaceholderText = "State";
            state.Size = new Size(541, 49);
            state.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(783, 217);
            label4.Name = "label4";
            label4.Size = new Size(168, 42);
            label4.TabIndex = 13;
            label4.Text = "E-mail ID";
            // 
            // mail
            // 
            mail.Anchor = AnchorStyles.Right;
            mail.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            mail.Location = new Point(790, 262);
            mail.Name = "mail";
            mail.PlaceholderText = "E-Mail";
            mail.Size = new Size(541, 49);
            mail.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(815, 383);
            label5.Name = "label5";
            label5.Size = new Size(495, 42);
            label5.TabIndex = 15;
            label5.Text = "Emergency Contact Details";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(783, 473);
            label6.Name = "label6";
            label6.Size = new Size(127, 42);
            label6.TabIndex = 16;
            label6.Text = "Name:";
            // 
            // contactname
            // 
            contactname.Anchor = AnchorStyles.Right;
            contactname.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            contactname.Location = new Point(903, 466);
            contactname.Name = "contactname";
            contactname.PlaceholderText = "Name";
            contactname.Size = new Size(428, 49);
            contactname.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(783, 548);
            label7.Name = "label7";
            label7.Size = new Size(195, 42);
            label7.TabIndex = 18;
            label7.Text = "Phone No:";
            // 
            // contactphone
            // 
            contactphone.Anchor = AnchorStyles.Right;
            contactphone.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            contactphone.Location = new Point(973, 548);
            contactphone.Name = "contactphone";
            contactphone.PlaceholderText = "Phone Number";
            contactphone.Size = new Size(358, 49);
            contactphone.TabIndex = 19;
            // 
            // savebutton
            // 
            savebutton.Anchor = AnchorStyles.Bottom;
            savebutton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            savebutton.Location = new Point(681, 750);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(129, 51);
            savebutton.TabIndex = 20;
            savebutton.Text = "Save";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 40.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(275, 43);
            label1.Name = "label1";
            label1.Size = new Size(955, 76);
            label1.TabIndex = 3;
            label1.Text = "PATIENT CONTACT DETAILS";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1486, 855);
            Controls.Add(savebutton);
            Controls.Add(contactphone);
            Controls.Add(label7);
            Controls.Add(contactname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(mail);
            Controls.Add(label4);
            Controls.Add(state);
            Controls.Add(area);
            Controls.Add(house);
            Controls.Add(city);
            Controls.Add(pincode);
            Controls.Add(label3);
            Controls.Add(phone);
            Controls.Add(label1);
            Controls.Add(label2);
            MinimumSize = new Size(1504, 848);
            Name = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox phone;
        private Label label3;
        private TextBox pincode;
        private TextBox city;
        private TextBox house;
        private TextBox area;
        private TextBox state;
        private Label label4;
        private TextBox mail;
        private Label label5;
        private Label label6;
        private TextBox contactname;
        private Label label7;
        private TextBox contactphone;
        private Button savebutton;
        private Label label1;
    }
}