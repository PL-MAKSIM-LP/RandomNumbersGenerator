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
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.argument_a_textBox = new System.Windows.Forms.TextBox();
            this.argument_c_textBox = new System.Windows.Forms.TextBox();
            this.textBox_bordervalue_pseudo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.max_number_pseudo = new System.Windows.Forms.TextBox();
            this.min_number_pseudo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.count_number_pseudo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_pseudo = new System.Windows.Forms.ListBox();
            this.checkBox_new_Seed = new System.Windows.Forms.CheckBox();
            this.button_randomNumbers = new System.Windows.Forms.Button();
            this.max_number_random = new System.Windows.Forms.TextBox();
            this.min_number_random = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox_random = new System.Windows.Forms.ListBox();
            this.count_number_random = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.border_random = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запросити послідовність";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(497, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(183, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Стандартні аргументи";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(497, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(207, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Користувацькі аргументи";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Аргумент А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Аргумент С";
            // 
            // argument_a_textBox
            // 
            this.argument_a_textBox.Enabled = false;
            this.argument_a_textBox.Location = new System.Drawing.Point(435, 273);
            this.argument_a_textBox.Name = "argument_a_textBox";
            this.argument_a_textBox.Size = new System.Drawing.Size(125, 27);
            this.argument_a_textBox.TabIndex = 7;
            this.argument_a_textBox.Text = "1103515245";
            // 
            // argument_c_textBox
            // 
            this.argument_c_textBox.Enabled = false;
            this.argument_c_textBox.Location = new System.Drawing.Point(435, 347);
            this.argument_c_textBox.Name = "argument_c_textBox";
            this.argument_c_textBox.Size = new System.Drawing.Size(125, 27);
            this.argument_c_textBox.TabIndex = 8;
            this.argument_c_textBox.Text = "12345";
            // 
            // textBox_bordervalue_pseudo
            // 
            this.textBox_bordervalue_pseudo.Enabled = false;
            this.textBox_bordervalue_pseudo.Location = new System.Drawing.Point(539, 164);
            this.textBox_bordervalue_pseudo.Name = "textBox_bordervalue_pseudo";
            this.textBox_bordervalue_pseudo.Size = new System.Drawing.Size(125, 27);
            this.textBox_bordervalue_pseudo.TabIndex = 9;
            this.textBox_bordervalue_pseudo.Text = "150";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Граничне значення";
            // 
            // max_number_pseudo
            // 
            this.max_number_pseudo.Location = new System.Drawing.Point(604, 347);
            this.max_number_pseudo.Name = "max_number_pseudo";
            this.max_number_pseudo.Size = new System.Drawing.Size(125, 27);
            this.max_number_pseudo.TabIndex = 14;
            this.max_number_pseudo.Text = "100000";
            // 
            // min_number_pseudo
            // 
            this.min_number_pseudo.Location = new System.Drawing.Point(604, 273);
            this.min_number_pseudo.Name = "min_number_pseudo";
            this.min_number_pseudo.Size = new System.Drawing.Size(125, 27);
            this.min_number_pseudo.TabIndex = 13;
            this.min_number_pseudo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Максимальне число";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Мінімальне число";
            // 
            // count_number_pseudo
            // 
            this.count_number_pseudo.Location = new System.Drawing.Point(528, 412);
            this.count_number_pseudo.Name = "count_number_pseudo";
            this.count_number_pseudo.Size = new System.Drawing.Size(125, 27);
            this.count_number_pseudo.TabIndex = 16;
            this.count_number_pseudo.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Кількість згенерованих чисел";
            // 
            // listBox_pseudo
            // 
            this.listBox_pseudo.FormattingEnabled = true;
            this.listBox_pseudo.ItemHeight = 20;
            this.listBox_pseudo.Location = new System.Drawing.Point(773, 48);
            this.listBox_pseudo.Name = "listBox_pseudo";
            this.listBox_pseudo.Size = new System.Drawing.Size(186, 364);
            this.listBox_pseudo.TabIndex = 17;
            // 
            // checkBox_new_Seed
            // 
            this.checkBox_new_Seed.AutoSize = true;
            this.checkBox_new_Seed.Location = new System.Drawing.Point(497, 114);
            this.checkBox_new_Seed.Name = "checkBox_new_Seed";
            this.checkBox_new_Seed.Size = new System.Drawing.Size(201, 24);
            this.checkBox_new_Seed.TabIndex = 18;
            this.checkBox_new_Seed.Text = "Згенерувати нове зерно";
            this.checkBox_new_Seed.UseVisualStyleBackColor = true;
            this.checkBox_new_Seed.CheckedChanged += new System.EventHandler(this.checkBox_new_Seed_CheckedChanged);
            // 
            // button_randomNumbers
            // 
            this.button_randomNumbers.Location = new System.Drawing.Point(10, 120);
            this.button_randomNumbers.Name = "button_randomNumbers";
            this.button_randomNumbers.Size = new System.Drawing.Size(214, 29);
            this.button_randomNumbers.TabIndex = 19;
            this.button_randomNumbers.Text = "Запросити послідовність";
            this.button_randomNumbers.UseVisualStyleBackColor = true;
            this.button_randomNumbers.Click += new System.EventHandler(this.button_randomNumbers_Click);
            // 
            // max_number_random
            // 
            this.max_number_random.Location = new System.Drawing.Point(49, 264);
            this.max_number_random.Name = "max_number_random";
            this.max_number_random.Size = new System.Drawing.Size(125, 27);
            this.max_number_random.TabIndex = 23;
            this.max_number_random.Text = "100000";
            // 
            // min_number_random
            // 
            this.min_number_random.Location = new System.Drawing.Point(49, 190);
            this.min_number_random.Name = "min_number_random";
            this.min_number_random.Size = new System.Drawing.Size(125, 27);
            this.min_number_random.TabIndex = 22;
            this.min_number_random.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Максимальне число";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Мінімальне число";
            // 
            // listBox_random
            // 
            this.listBox_random.FormattingEnabled = true;
            this.listBox_random.ItemHeight = 20;
            this.listBox_random.Location = new System.Drawing.Point(230, 64);
            this.listBox_random.Name = "listBox_random";
            this.listBox_random.Size = new System.Drawing.Size(186, 364);
            this.listBox_random.TabIndex = 24;
            // 
            // count_number_random
            // 
            this.count_number_random.Location = new System.Drawing.Point(49, 324);
            this.count_number_random.Name = "count_number_random";
            this.count_number_random.Size = new System.Drawing.Size(125, 27);
            this.count_number_random.TabIndex = 26;
            this.count_number_random.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Кількість згенерованих чисел";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Граничне значення";
            // 
            // border_random
            // 
            this.border_random.Location = new System.Drawing.Point(49, 87);
            this.border_random.Name = "border_random";
            this.border_random.Size = new System.Drawing.Size(125, 27);
            this.border_random.TabIndex = 27;
            this.border_random.Text = "150";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.border_random);
            this.Controls.Add(this.count_number_random);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox_random);
            this.Controls.Add(this.max_number_random);
            this.Controls.Add(this.min_number_random);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_randomNumbers);
            this.Controls.Add(this.checkBox_new_Seed);
            this.Controls.Add(this.listBox_pseudo);
            this.Controls.Add(this.count_number_pseudo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.max_number_pseudo);
            this.Controls.Add(this.min_number_pseudo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_bordervalue_pseudo);
            this.Controls.Add(this.argument_c_textBox);
            this.Controls.Add(this.argument_a_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ClentApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private Label label2;
        private TextBox argument_a_textBox;
        private TextBox argument_c_textBox;
        private TextBox textBox_bordervalue_pseudo;
        private Label label3;
        private TextBox max_number_pseudo;
        private TextBox min_number_pseudo;
        private Label label4;
        private Label label5;
        private TextBox count_number_pseudo;
        private Label label6;
        private ListBox listBox_pseudo;
        private CheckBox checkBox_new_Seed;
        private Button button_randomNumbers;
        private TextBox max_number_random;
        private TextBox min_number_random;
        private Label label7;
        private Label label8;
        private ListBox listBox_random;
        private TextBox count_number_random;
        private Label label9;
        private Label label10;
        private TextBox border_random;
    }
}