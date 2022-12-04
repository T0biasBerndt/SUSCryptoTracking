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
using System.Net;
using System.IO;
using MySql.Data.MySqlClient.Memcached;
using RestSharp;
using System.Runtime.Serialization;

namespace CryptoTracker.View
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var client = new RestClient("https://pro-api.coinmarketcap.com/v2/cryptocurrency/quotes/latest?slug=bitcoin");
            var request = new RestRequest();
            request.AddHeader("X-CMC_PRO_API_KEY", "1ea6a73e-b7b8-44e0-85c0-d68e1ad6abd7");
            RestResponse response = client.Execute(request);
            string responseText = response.Content;


        }
    }
}
