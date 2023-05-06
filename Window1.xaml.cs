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

namespace LocalMessenger
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public LocalMessengerServer _server;
        public LocalMessengerClient _client;
        private string _username;
        public Window1(LocalMessengerServer server, LocalMessengerClient client, string username)
        {
            InitializeComponent();
            _server = server;
            _client = client;
            _username = username;

        }

        private void UserListUpdated(object sender, string username)
        {
            Dispatcher.Invoke(() =>
            {
                lstUsers.Items.Add(username);
            });
        }
    }
    
}
