namespace WinFormsApp1
{
    partial class PseudoRandom
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
            this.buttonSetSeed = new System.Windows.Forms.Button();
            this.textBox_seed = new System.Windows.Forms.TextBox();
            this.buttonGenNumber = new System.Windows.Forms.Button();
            this.button_clearList = new System.Windows.Forms.Button();
            this.button_saveAs = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.border_Box = new System.Windows.Forms.TextBox();
            this.radioButton_standart = new System.Windows.Forms.RadioButton();
            this.radioButton_custom = new System.Windows.Forms.RadioButton();
            this.textBox_a_arg = new System.Windows.Forms.TextBox();
            this.textBox_c_arg = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSetSeed
            // 
            this.buttonSetSeed.Location = new System.Drawing.Point(45, 165);
            this.buttonSetSeed.Name = "buttonSetSeed";
            this.buttonSetSeed.Size = new System.Drawing.Size(160, 29);
            this.buttonSetSeed.TabIndex = 0;
            this.buttonSetSeed.Text = "Задати зерно";
            this.buttonSetSeed.UseVisualStyleBackColor = true;
            this.buttonSetSeed.Click += new System.EventHandler(this.buttonSetSeed_Click);
            // 
            // textBox_seed
            // 
            this.textBox_seed.Location = new System.Drawing.Point(66, 41);
            this.textBox_seed.Name = "textBox_seed";
            this.textBox_seed.Size = new System.Drawing.Size(125, 27);
            this.textBox_seed.TabIndex = 1;
            this.textBox_seed.Text = "548612345";
            // 
            // buttonGenNumber
            // 
            this.buttonGenNumber.Location = new System.Drawing.Point(45, 130);
            this.buttonGenNumber.Name = "buttonGenNumber";
            this.buttonGenNumber.Size = new System.Drawing.Size(160, 31);
            this.buttonGenNumber.TabIndex = 2;
            this.buttonGenNumber.Text = "Згенерувати зерно";
            this.buttonGenNumber.UseVisualStyleBackColor = true;
            this.buttonGenNumber.Click += new System.EventHandler(this.buttonGenNumber_Click);
            // 
            // button_clearList
            // 
            this.button_clearList.Location = new System.Drawing.Point(256, 143);
            this.button_clearList.Name = "button_clearList";
            this.button_clearList.Size = new System.Drawing.Size(162, 29);
            this.button_clearList.TabIndex = 3;
            this.button_clearList.Text = "Очистити список";
            this.button_clearList.UseVisualStyleBackColor = true;
            this.button_clearList.Click += new System.EventHandler(this.button_clearList_Click);
            // 
            // button_saveAs
            // 
            this.button_saveAs.Location = new System.Drawing.Point(256, 178);
            this.button_saveAs.Name = "button_saveAs";
            this.button_saveAs.Size = new System.Drawing.Size(162, 29);
            this.button_saveAs.TabIndex = 4;
            this.button_saveAs.Text = "Зберегти як";
            this.button_saveAs.UseVisualStyleBackColor = true;
            this.button_saveAs.Click += new System.EventHandler(this.button_saveAs_Click);
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(256, 89);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(162, 48);
            this.button_generate.TabIndex = 6;
            this.button_generate.Text = "Згенерувати послідовність";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // border_Box
            // 
            this.border_Box.Location = new System.Drawing.Point(66, 100);
            this.border_Box.Name = "border_Box";
            this.border_Box.Size = new System.Drawing.Size(125, 27);
            this.border_Box.TabIndex = 7;
            this.border_Box.Text = "150";
            // 
            // radioButton_standart
            // 
            this.radioButton_standart.AutoSize = true;
            this.radioButton_standart.Checked = true;
            this.radioButton_standart.Location = new System.Drawing.Point(45, 200);
            this.radioButton_standart.Name = "radioButton_standart";
            this.radioButton_standart.Size = new System.Drawing.Size(174, 24);
            this.radioButton_standart.TabIndex = 8;
            this.radioButton_standart.TabStop = true;
            this.radioButton_standart.Text = "Стандарті аргументи";
            this.radioButton_standart.UseVisualStyleBackColor = true;
            this.radioButton_standart.CheckedChanged += new System.EventHandler(this.radioButton_standart_CheckedChanged);
            // 
            // radioButton_custom
            // 
            this.radioButton_custom.AutoSize = true;
            this.radioButton_custom.Location = new System.Drawing.Point(45, 230);
            this.radioButton_custom.Name = "radioButton_custom";
            this.radioButton_custom.Size = new System.Drawing.Size(195, 24);
            this.radioButton_custom.TabIndex = 9;
            this.radioButton_custom.Text = "Аргументи користувача";
            this.radioButton_custom.UseVisualStyleBackColor = true;
            this.radioButton_custom.CheckedChanged += new System.EventHandler(this.radioButton_custom_CheckedChanged);
            // 
            // textBox_a_arg
            // 
            this.textBox_a_arg.Enabled = false;
            this.textBox_a_arg.Location = new System.Drawing.Point(66, 280);
            this.textBox_a_arg.Name = "textBox_a_arg";
            this.textBox_a_arg.Size = new System.Drawing.Size(125, 27);
            this.textBox_a_arg.TabIndex = 10;
            this.textBox_a_arg.Text = "1103515245";
            // 
            // textBox_c_arg
            // 
            this.textBox_c_arg.Enabled = false;
            this.textBox_c_arg.Location = new System.Drawing.Point(67, 333);
            this.textBox_c_arg.Name = "textBox_c_arg";
            this.textBox_c_arg.Size = new System.Drawing.Size(125, 27);
            this.textBox_c_arg.TabIndex = 11;
            this.textBox_c_arg.Text = "12345";
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(273, 289);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(125, 27);
            this.textBox_max.TabIndex = 12;
            this.textBox_max.Text = "1000";
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(273, 237);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(125, 27);
            this.textBox_min.TabIndex = 13;
            this.textBox_min.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(475, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 344);
            this.listBox1.TabIndex = 14;
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(274, 55);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(125, 27);
            this.textBox_count.TabIndex = 15;
            this.textBox_count.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Згенероване зерно";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Аргумент А";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Аргумент С";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Граничне значення";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Кількість чисел";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Мінімальне значення";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Максимальне значення";
            // 
            // PseudoRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 402);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_c_arg);
            this.Controls.Add(this.textBox_a_arg);
            this.Controls.Add(this.radioButton_custom);
            this.Controls.Add(this.radioButton_standart);
            this.Controls.Add(this.border_Box);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.button_saveAs);
            this.Controls.Add(this.button_clearList);
            this.Controls.Add(this.buttonGenNumber);
            this.Controls.Add(this.textBox_seed);
            this.Controls.Add(this.buttonSetSeed);
            this.Name = "PseudoRandom";
            this.Text = "PseudoRandom";
            this.Load += new System.EventHandler(this.PseudoRandom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSetSeed;
        private TextBox textBox_seed;
        private Button buttonGenNumber;
        private Button button_clearList;
        private Button button_saveAs;
        private Button button_generate;
        private TextBox border_Box;
        private RadioButton radioButton_standart;
        private RadioButton radioButton_custom;
        private TextBox textBox_a_arg;
        private TextBox textBox_c_arg;
        private TextBox textBox_max;
        private TextBox textBox_min;
        private ListBox listBox1;
        private TextBox textBox_count;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}