using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows;
using noisegenerator;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        List<string> result_list = new List<string>();
        Generator generator = new Generator();
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void random_button_Click(object sender, EventArgs e)
        {
            var realRandomForm = new RealRandom();
            realRandomForm.Show();
        }

        private void not_random_button_Click(object sender, EventArgs e)
        {
          
            var notRandomForm = new PseudoRandom();
            notRandomForm.Show();
        }

        async void  Server()
        {
            await Task.Run(() =>
            {

                const string ip = "127.0.0.1";
                const int port = 8090;
                var tcpEndpoint = new IPEndPoint(IPAddress.Parse(ip), port);
                var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                tcpSocket.Bind(tcpEndpoint);
                tcpSocket.Listen(1);

                var answer = new StringBuilder();

                while (true)
                {
                    var listener = tcpSocket.Accept();
                    var buffer = new byte[256];
                    int size = 0;
                    var data = new StringBuilder();

                    do
                    {
                        size = listener.Receive(buffer);
                        data.Append(Encoding.UTF8.GetString(buffer, 0, size));

                    } while (listener.Available > 2);
                    requestHandler(data);

                    for (int i = 0; i < result_list.Count; i++)
                    {
                        var responce = new
                        {
                            number = result_list[i]
                        };
                        string message = JsonConvert.SerializeObject(responce);
                        listener.Send(Encoding.UTF8.GetBytes(message));
                        System.Threading.Thread.Sleep(40);
                    }

                    result_list.Clear();
                    listener.Shutdown(SocketShutdown.Both);
                    listener.Close();
                }
            });                         
        }

        void requestHandler(StringBuilder data)
        {
            var request = JsonConvert.DeserializeObject<Request>(data.ToString());

            if (request.mode == "PseudoRandom")
            {
                pseudoMode(request);
            }
            else
            {
                randomMode(request);
            }

        }

        void pseudoMode(Request request)
        {
            if (request.newseed)
            {
                Noise noise = new Noise();
                noise.readedNumberMicrophone(request.bordervalue);

                generator.tmpseed = noise.getreadednumber();


            }
            for (int i = 0; i < request.countNumbers; i++)
            {
                result_list.Add(generator.pseudorandom(request.argA, request.argC, request.max, request.min).ToString());
            }
        }

        void randomMode(Request request)
        {
            Noise noise = new Noise();
            for (int i = 0; i < request.countNumbers; i++)
            {
                noise.readedNumberMicrophone(request.bordervalue);
                result_list.Add(noise.generaterandom(request.min, request.max, request.bordervalue).ToString());
            }       
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            generator.tmpseed = generator.seed;
            Server();
        }
    }
}
