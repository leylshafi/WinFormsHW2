namespace WinFormsHW2
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
            this.SearchName = new System.Windows.Forms.TextBox();
            this.Load = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtFatherName = new System.Windows.Forms.TextBox();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.Survey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Genders = new System.Windows.Forms.GroupBox();
            this.Genders.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(167, 21);
            this.SearchName.Name = "SearchName";
            this.SearchName.PlaceholderText = "Name";
            this.SearchName.Size = new System.Drawing.Size(100, 23);
            this.SearchName.TabIndex = 0;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(320, 21);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 1;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(123, 85);
            this.TxtName.Name = "TxtName";
            this.TxtName.PlaceholderText = "Name";
            this.TxtName.Size = new System.Drawing.Size(272, 23);
            this.TxtName.TabIndex = 3;
            this.TxtName.Tag = "Name";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(123, 123);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.PlaceholderText = "Surname";
            this.TxtSurname.Size = new System.Drawing.Size(272, 23);
            this.TxtSurname.TabIndex = 4;
            this.TxtSurname.Tag = "Surname";
            // 
            // TxtFatherName
            // 
            this.TxtFatherName.Location = new System.Drawing.Point(123, 162);
            this.TxtFatherName.Name = "TxtFatherName";
            this.TxtFatherName.PlaceholderText = "Father name";
            this.TxtFatherName.Size = new System.Drawing.Size(272, 23);
            this.TxtFatherName.TabIndex = 5;
            this.TxtFatherName.Tag = "Father Name";
            // 
            // TxtCountry
            // 
            this.TxtCountry.Location = new System.Drawing.Point(123, 236);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.PlaceholderText = "Country";
            this.TxtCountry.Size = new System.Drawing.Size(272, 23);
            this.TxtCountry.TabIndex = 6;
            this.TxtCountry.Tag = "Country";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(123, 276);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.PlaceholderText = "City";
            this.TxtCity.Size = new System.Drawing.Size(272, 23);
            this.TxtCity.TabIndex = 7;
            this.TxtCity.Tag = "City";
            // 
            // Survey
            // 
            this.Survey.AutoSize = true;
            this.Survey.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Survey.Location = new System.Drawing.Point(12, 44);
            this.Survey.Name = "Survey";
            this.Survey.Size = new System.Drawing.Size(57, 20);
            this.Survey.TabIndex = 8;
            this.Survey.Text = "Survey";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Father Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "City";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(123, 317);
            this.TxtPhone.Mask = "(999) 000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(272, 23);
            this.TxtPhone.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(27, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone";
            // 
            // TxtBirthday
            // 
            this.TxtBirthday.CustomFormat = "\"dd/MM/yyyy\"";
            this.TxtBirthday.Location = new System.Drawing.Point(123, 366);
            this.TxtBirthday.Name = "TxtBirthday";
            this.TxtBirthday.Size = new System.Drawing.Size(272, 23);
            this.TxtBirthday.TabIndex = 16;
            this.TxtBirthday.Tag = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Birthday";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(31, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 21);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(175, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 21);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(20, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Gender";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(383, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Genders
            // 
            this.Genders.Controls.Add(this.radioButton1);
            this.Genders.Controls.Add(this.radioButton2);
            this.Genders.Location = new System.Drawing.Point(118, 409);
            this.Genders.Name = "Genders";
            this.Genders.Size = new System.Drawing.Size(277, 40);
            this.Genders.TabIndex = 22;
            this.Genders.TabStop = false;
            this.Genders.Text = "Genders";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 516);
            this.Controls.Add(this.Genders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtBirthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Survey);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.TxtFatherName);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.SearchName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Genders.ResumeLayout(false);
            this.Genders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SearchName;
        private Button Load;
        private TextBox TxtName;
        private TextBox TxtSurname;
        private TextBox TxtFatherName;
        private TextBox TxtCountry;
        private TextBox TxtCity;
        private Label Survey;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox TxtPhone;
        private Label label6;
        private DateTimePicker TxtBirthday;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label8;
        private Button button1;
        private GroupBox Genders;
    }
}