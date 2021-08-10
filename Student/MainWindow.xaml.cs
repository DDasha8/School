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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;

namespace Student
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int port = 9001; // Порт для сервера
        static string addr = "127.0.0.1"; // Адрес сервера


        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(addr), port);

                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                socket.Connect(ipPoint);

                StatusLabel.Content = "Подключение установлено";
                StatusLabel.Foreground = Brushes.Green;
            }
            catch (Exception err)
            {
                MessageBox.Show("Connection error...", err.Message);
            }
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}