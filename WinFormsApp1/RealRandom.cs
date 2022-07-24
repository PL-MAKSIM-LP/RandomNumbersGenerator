using noisegenerator;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinFormsApp1
{
    public partial class RealRandom : Form
    {
        Generator generator = new Generator();
        Noise noise = new Noise();
        public RealRandom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long tmp;
            uint min, max, border;
            Numbers check = new Numbers();

                tmp = long.Parse(textBox_min.Text);
                if (!check.checknumber(tmp))
                    return;
                min = (uint)tmp;

                tmp = long.Parse(textBox_max.Text);
                if (!check.checknumber(tmp))
                    return;
                max = (uint)tmp;

              tmp = long.Parse(border_box.Text);
              if (!check.checknumber(tmp))
                  return;
            border = (uint)tmp;

            for (int i = 0; i < uint.Parse(textBox1.Text); i++)
            {
                uint sample = noise.generaterandom(min, max, border);
                
                    listBox1.Items.Add(sample);
               
     
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}