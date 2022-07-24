namespace WinFormsApp1
{
    partial class MainForm
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
            this.random_button = new System.Windows.Forms.Button();
            this.not_random_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // random_button
            // 
            this.random_button.Location = new System.Drawing.Point(74, 119);
            this.random_button.Name = "random_button";
            this.random_button.Size = new System.Drawing.Size(144, 29);
            this.random_button.TabIndex = 0;
            this.random_button.Text = "Випадкові числа";
            this.random_button.UseVisualStyleBackColor = true;
            this.random_button.Click += new System.EventHandler(this.random_button_Click);
            // 
            // not_random_button
            // 
            this.not_random_button.Location = new System.Drawing.Point(58, 182);
            this.not_random_button.Name = "not_random_button";
            this.not_random_button.Size = new System.Drawing.Size(183, 29);
            this.not_random_button.TabIndex = 1;
            this.not_random_button.Text = "Псевдовипадкові числа";
            this.not_random_button.UseVisualStyleBackColor = true;
            this.not_random_button.Click += new System.EventHandler(this.not_random_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 392);
            this.Controls.Add(this.not_random_button);
            this.Controls.Add(this.random_button);
            this.MaximumSize = new System.Drawing.Size(312, 439);
            this.MinimumSize = new System.Drawing.Size(312, 439);
            this.Name = "MainForm";
            this.Text = "ServerApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button random_button;
        private Button not_random_button;
    }
}