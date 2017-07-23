using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

namespace LinkScraper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<string> LinkList { get; set; }

       // ObservableCollection<string> lstLink = new ObservableCollection<string>();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void dwnBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!(urlBox.Text.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || urlBox.Text.StartsWith("https://", StringComparison.OrdinalIgnoreCase)))
                urlBox.Text = "http://" + urlBox.Text;
            
            Uri uriResult;
            bool result = Uri.TryCreate(urlBox.Text, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
           listBooox.Items.Clear();

            if(result)
            {
                AddToList(Downloader(urlBox.Text));
            }
            else
            {
                MessageBox.Show("Wrong url");
            }

            found.Content = "Found: " + LinkList.Count().ToString() + " links.";
          
        }

        private IEnumerable<string> Downloader(string url)
        {
            var doc = new HtmlWeb().Load(url);
            var link = doc.DocumentNode.Descendants("link");
            var linkedPages = doc.DocumentNode.Descendants("a")
                .Select(a => a.GetAttributeValue("href", null))
                .Where(u => !String.IsNullOrEmpty(u));
            return linkedPages;
        }

        private void AddToList(IEnumerable<string> links)
        {
            LinkList = new List<string>();

            

            LinkList.AddRange(links);
            LinkList = LinkList.Distinct().ToList();

            foreach (var item in LinkList)
            {
                    listBooox.Items.Add(item);

            }
            
        }
        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
