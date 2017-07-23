using HtmlAgilityPack;
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

namespace LinkScraper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> LinkList;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dwnBtn_Click(object sender, RoutedEventArgs e)
        {
            listBooox.Items.Clear();
            AddToList(Downloader(urlBox.Text));
          

         

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

            foreach (var item in LinkList)
            {
                listBooox.Items.Add(item);

            }
        }
    }
}
