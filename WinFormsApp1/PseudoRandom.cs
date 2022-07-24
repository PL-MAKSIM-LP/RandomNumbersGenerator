using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using noisegenerator;

namespace WinFormsApp1
{
    public partial class PseudoRandom : Form
    {
        Generator generator = new Generator();
        public PseudoRandom()
        {
            InitializeComponent();
        }

        private void buttonSetSeed_Click(object sender, EventArgs e)
        {
            Numbers check = new Numbers();

            long tmp;
            tmp = long.Parse(textBox_seed.Text);
            if (!check.checknumber(tmp))
                return;
            generator.tmpseed = (uint)tmp;
        }

        private void PseudoRandom_Load(object sender, EventArgs e)
        {
            textBox_seed.Text = generator.seed.ToString();

            generator.tmpseed = generator.seed;
        }

        private void buttonGenNumber_Click(object sender, EventArgs e)
        {
            Numbers check = new Numbers();
            long tmp;
            tmp = long.Parse(border_Box.Text);
            if (!check.checknumber(tmp))
                return;
            generator.border = (uint)tmp;

            Noise noise = new Noise();
            noise.readedNumberMicrophone(generator.border);


            generator.seed = noise.getreadednumber();
            generator.tmpseed = generator.seed;
            textBox_seed.Text = generator.seed.ToString();
        }

        private void radioButton_standart_CheckedChanged(object sender, EventArgs e)
        {
            textBox_a_arg.Enabled = false;
            textBox_c_arg.Enabled = false;
        }

        private void radioButton_custom_CheckedChanged(object sender, EventArgs e)
        {

            textBox_a_arg.Enabled = true;
            textBox_c_arg.Enabled = true;
            textBox_a_arg.Text = "1103515245";
            textBox_c_arg.Text = "12345";

            buttonGenNumber_Click(sender, e);
        }

        private void button_clearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName.ToString());
                foreach (object liItem in listBox1.Items)
                    file.WriteLine(liItem.ToString());

                file.Close();
            }
        }



        private void button_generate_Click(object sender, EventArgs e)
        {
            uint a, c, min, max;
            Numbers check = new Numbers();

            long tmp;
            tmp = long.Parse(textBox_a_arg.Text);
            if (!check.checknumber(tmp))
                return;
            a = (uint)tmp;

            tmp = long.Parse(textBox_c_arg.Text);
            if (!check.checknumber(tmp))
                return;
            c = (uint)tmp;

            tmp = long.Parse(textBox_min.Text);
            if (!check.checknumber(tmp))
                return;
            min = (uint)tmp;

            tmp = long.Parse(textBox_max.Text);
            if (!check.checknumber(tmp))
                return;
            max = (uint)tmp;

            if (min >= max)
            {
                string message = "Мінімальне число не має бути більшим або рівним";
                string title = "Error";
                MessageBox.Show(message, title);
                return;
            }

            for (int i = 0; i < uint.Parse(textBox_count.Text); i++)
                listBox1.Items.Add(generator.pseudorandom(a, c, max, min));
        }
    }
}
