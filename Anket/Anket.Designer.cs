namespace Anket
{
    partial class Anket
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
            textBox1 = new TextBox();
            button1 = new Button();
            name = new Label();
            Name_Text = new TextBox();
            Surname_Text = new TextBox();
            Surname = new Label();
            Father = new Label();
            Father_Text = new TextBox();
            Country = new Label();
            Country_Text = new TextBox();
            City = new Label();
            City_Text = new TextBox();
            Phone = new Label();
            Phone_Text = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Date = new Label();
            Gender = new Label();
            Male = new RadioButton();
            Female = new RadioButton();
            Save = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(251, 14);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 86);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 2;
            name.Text = "Name";
            // 
            // Name_Text
            // 
            Name_Text.Location = new Point(110, 79);
            Name_Text.Name = "Name_Text";
            Name_Text.Size = new Size(243, 27);
            Name_Text.TabIndex = 3;
            Name_Text.TextChanged += Name_Text_TextChanged;
            // 
            // Surname_Text
            // 
            Surname_Text.Location = new Point(110, 112);
            Surname_Text.Name = "Surname_Text";
            Surname_Text.Size = new Size(243, 27);
            Surname_Text.TabIndex = 4;
            Surname_Text.TextChanged += Surname_Text_TextChanged;
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Location = new Point(12, 115);
            Surname.Name = "Surname";
            Surname.Size = new Size(67, 20);
            Surname.TabIndex = 5;
            Surname.Text = "Surname";
            // 
            // Father
            // 
            Father.AutoSize = true;
            Father.Location = new Point(11, 148);
            Father.Name = "Father";
            Father.Size = new Size(93, 20);
            Father.TabIndex = 6;
            Father.Text = "Father Name";
            // 
            // Father_Text
            // 
            Father_Text.Location = new Point(110, 145);
            Father_Text.Name = "Father_Text";
            Father_Text.Size = new Size(243, 27);
            Father_Text.TabIndex = 7;
            Father_Text.TextChanged += Father_Text_TextChanged;
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Location = new Point(12, 228);
            Country.Name = "Country";
            Country.Size = new Size(60, 20);
            Country.TabIndex = 8;
            Country.Text = "Country";
            // 
            // Country_Text
            // 
            Country_Text.Location = new Point(110, 225);
            Country_Text.Name = "Country_Text";
            Country_Text.Size = new Size(243, 27);
            Country_Text.TabIndex = 9;
            Country_Text.TextChanged += Country_Text_TextChanged;
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(27, 261);
            City.Name = "City";
            City.Size = new Size(34, 20);
            City.TabIndex = 10;
            City.Text = "City";
            // 
            // City_Text
            // 
            City_Text.Location = new Point(110, 258);
            City_Text.Name = "City_Text";
            City_Text.Size = new Size(243, 27);
            City_Text.TabIndex = 11;
            City_Text.TextChanged += City_Text_TextChanged;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(22, 294);
            Phone.Name = "Phone";
            Phone.Size = new Size(50, 20);
            Phone.TabIndex = 12;
            Phone.Text = "Phone";
            // 
            // Phone_Text
            // 
            Phone_Text.Location = new Point(110, 291);
            Phone_Text.Name = "Phone_Text";
            Phone_Text.Size = new Size(243, 27);
            Phone_Text.TabIndex = 13;
            Phone_Text.TextChanged += Phone_Text_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(110, 373);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 27);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(20, 373);
            Date.Name = "Date";
            Date.Size = new Size(59, 20);
            Date.TabIndex = 15;
            Date.Text = "Bithday";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Location = new Point(22, 436);
            Gender.Name = "Gender";
            Gender.Size = new Size(57, 20);
            Gender.TabIndex = 16;
            Gender.Text = "Gender";
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(110, 436);
            Male.Name = "Male";
            Male.Size = new Size(63, 24);
            Male.TabIndex = 17;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(189, 436);
            Female.Name = "Female";
            Female.Size = new Size(78, 24);
            Female.TabIndex = 18;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            Save.Location = new Point(12, 488);
            Save.Name = "Save";
            Save.Size = new Size(333, 29);
            Save.TabIndex = 19;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Anket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 535);
            Controls.Add(Save);
            Controls.Add(Female);
            Controls.Add(Male);
            Controls.Add(Gender);
            Controls.Add(Date);
            Controls.Add(dateTimePicker1);
            Controls.Add(Phone_Text);
            Controls.Add(Phone);
            Controls.Add(City_Text);
            Controls.Add(City);
            Controls.Add(Country_Text);
            Controls.Add(Country);
            Controls.Add(Father_Text);
            Controls.Add(Father);
            Controls.Add(Surname);
            Controls.Add(Surname_Text);
            Controls.Add(Name_Text);
            Controls.Add(name);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Anket";
            Text = "Anket";
            Load += Anket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label name;
        private TextBox Name_Text;
        private TextBox Surname_Text;
        private Label Surname;
        private Label Father;
        private TextBox Father_Text;
        private Label Country;
        private TextBox Country_Text;
        private Label City;
        private TextBox City_Text;
        private Label Phone;
        private TextBox Phone_Text;
        private DateTimePicker dateTimePicker1;
        private Label Date;
        private Label Gender;
        private RadioButton Male;
        private RadioButton Female;
        private Button Save;
    }
}