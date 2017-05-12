using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net.Sockets;
using System.Net;
using System.Windows.Threading;


namespace JustaButton
{
    /// <summary>
    /// Interaction logic for ButtonList.xaml
    /// </summary>
    public partial class ButtonList : Window
    {
        public UdpClient udpClient = new UdpClient(Properties.Settings.Default.IncomingPort, AddressFamily.InterNetwork);
        //ReceiveBuffer String
        public static Byte[] rBytes;
        List<char> buffer = new List<char>(); //UDP Char Buffer List
        public delegate void MyDelegate(char DG); //Deligate for buffer

        public delegate void NextPrimeDelegate(string DG);


        List<string> ListButtonID = new List<string>();




        public ButtonList()
        {
            InitializeComponent();
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            Setup win2 = new Setup();
            win2.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            udpClient.BeginReceive(new AsyncCallback(ReceiveCallback), udpClient);
        }

        //Receive Callback
        public void ReceiveCallback(IAsyncResult ar)
        {
            UdpClient u = (UdpClient)ar.AsyncState;
            IPEndPoint e = new IPEndPoint(IPAddress.Any, Properties.Settings.Default.OutgoingPort);

            Byte[] receiveBytes = u.EndReceive(ar, ref e);
            char[] array = Encoding.ASCII.GetChars(receiveBytes);
          
            Dispatcher.BeginInvoke(DispatcherPriority.Normal, new NextPrimeDelegate(CommandBuilder), new string(array));
            u.BeginReceive(new AsyncCallback(ReceiveCallback), u);

        }


        //Builds command string from char array derived from UDP datagrams
        public void CommandBuilder(string Buffer)
        {

            if (Buffer.StartsWith("$") && Buffer.EndsWith("?"))
            {   

                string ButtonID = Buffer.Substring(Buffer.IndexOf("$") + 1, Buffer.IndexOf(":") - 1);
                string BatLevel = Buffer.Substring(Buffer.IndexOf(":")+1, 2);

                if ((ListButtonID != null) && (!ListButtonID.Any()))
                {
                    ListButtonID.Add(ButtonID);
                    listButtonListView.Items.Add(ButtonID + " Battery:" + BatLevel + "%");
                    SendPacket("!&0:" + ButtonID + "&#");

                }

                else if (!ListButtonID.Contains(ButtonID))
                {
                    ListButtonID.Add(ButtonID);
                   listButtonListView.Items.Add(ButtonID + " Battery:" + BatLevel + "%");
                    SendPacket("!&0:" + ButtonID + "&#");

                }

                 //MessageBox.Show(Buffer);
            }


        }

        //Send Message
        private void SendPacket(string cmd)
        {
            byte[] SendCMD = Encoding.ASCII.GetBytes(cmd);

            IPEndPoint ip = new IPEndPoint(IPAddress.Broadcast, Properties.Settings.Default.OutgoingPort);
            udpClient.Send(SendCMD, SendCMD.Length, ip);           

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            udpClient.Close();
        }
    }
}
