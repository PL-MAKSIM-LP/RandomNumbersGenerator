using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        const string ip = "127.0.0.1";
        const int port = 8090;
        Request request = new Request();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            request.mode = "PseudoRandom";
            request.max = uint.Parse(max_number_pseudo.Text);
            request.min = uint.Parse(min_number_pseudo.Text);
            request.argA = uint.Parse(argument_a_textBox.Text);
            request.argC = uint.Parse(argument_c_textBox.Text);
            request.countNumbers = uint.Parse(count_number_pseudo.Text);
            request.newseed = false;
            request.bordervalue = uint.Parse(textBox_bordervalue_pseudo.Text);

            if (checkBox_new_Seed.Checked)
            {
                request.newseed = true;
            }

            string message = JsonConvert.SerializeObject(request);

            sendrequest(message, listBox_pseudo, request.countNumbers);

        }

        void sendrequest(string message, ListBox listBox,uint count)
        {

            var tcpEndpoint = new IPEndPoint(IPAddress.Parse(ip), port);
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
         
            var data = Encoding.UTF8.GetBytes(message);
            tcpSocket.Connect(tcpEndpoint);
            tcpSocket.Send(data);
           
            for (int i = 0; i < count; i++)
            {
                var buffer = new byte[256];
                var size = 0;
                var answer = new StringBuilder();

                    size = tcpSocket.Receive(buffer);
                    answer.Append(Encoding.UTF8.GetString(buffer, 0, size));

                var responce = JsonConvert.DeserializeObject<Responce>(answer.ToString());
                addList(responce.number, listBox);
            }

            tcpSocket.Shutdown(SocketShutdown.Both);
            tcpSocket.Close();
        }
        async void addList(string number, ListBox listBox)
        {
            await Task.Run(() =>
            {
                listBox.Items.Add(number);
            });
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            argument_a_textBox.Enabled = true;
            argument_c_textBox.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            argument_a_textBox.Enabled = false;
            argument_c_textBox.Enabled = false;
            argument_a_textBox.Text = "1103515245";
            argument_c_textBox.Text = "12345";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_randomNumbers_Click(object sender, EventArgs e)
        {
            request.mode = "Random";
            request.max = uint.Parse(max_number_random.Text);
            request.min = uint.Parse(min_number_random.Text);
            request.countNumbers = uint.Parse(count_number_random.Text);
            request.bordervalue = uint.Parse(border_random.Text);

            string message = JsonConvert.SerializeObject(request);

            sendrequest(message, listBox_random, request.countNumbers);

        }

        private void checkBox_new_Seed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_new_Seed.Checked)
            {
                textBox_bordervalue_pseudo.Enabled = true;
            }
            else
                textBox_bordervalue_pseudo.Enabled = false;
        }
    }
}