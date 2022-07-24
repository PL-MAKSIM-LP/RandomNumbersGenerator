namespace WinFormsApp1
{
    using NAudio;
    using NAudio.CoreAudioApi;
    using NAudio.FileFormats;
    using NAudio.Wave;
    using noisegenerator;

    partial class RealRandom
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
            this.text_label = new System.Windows.Forms.Label();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.border_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Згенерувати послідовність";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_label
            // 
            this.text_label.AutoSize = true;
            this.text_label.Location = new System.Drawing.Point(65, 9);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(272, 20);
            this.text_label.TabIndex = 1;
            this.text_label.Text = "Згенерувати випадкову послідовність";
            this.text_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(59, 206);
            this.textBox_min.MaxLength = 10;
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(125, 27);
            this.textBox_min.TabIndex = 3;
            this.textBox_min.Text = "0";
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(59, 260);
            this.textBox_max.MaxLength = 10;
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(125, 27);
            this.textBox_max.TabIndex = 4;
            this.textBox_max.Text = "4294967295";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Мінімальне число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Максимальне число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кількість чисел";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 60);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(243, 32);
            this.listBox1.MaximumSize = new System.Drawing.Size(150, 344);
            this.listBox1.MinimumSize = new System.Drawing.Size(150, 344);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 344);
            this.listBox1.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(51, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 36);
            this.button4.TabIndex = 24;
            this.button4.Text = "Зберегти як";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 36);
            this.button3.TabIndex = 23;
            this.button3.Text = "Очистити список";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // border_box
            // 
            this.border_box.Location = new System.Drawing.Point(59, 119);
            this.border_box.MaxLength = 10;
            this.border_box.Name = "border_box";
            this.border_box.Size = new System.Drawing.Size(125, 27);
            this.border_box.TabIndex = 25;
            this.border_box.Text = "150";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Граничне значення";
            // 
            // RealRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.border_box);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.text_label);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(428, 430);
            this.MinimumSize = new System.Drawing.Size(428, 430);
            this.Name = "RealRandom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label text_label;
        private TextBox textBox_min;
        private TextBox textBox_max;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button4;
        private Button button3;
        private TextBox border_box;
        private Label label4;
    }
}