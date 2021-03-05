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
using Microsoft.Web.WebView2.Core;

namespace Mattermost_MsWebViewApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //WebView2.CoreWebView2.Navigate("https://chat.reactos.org");
            //WebView2.CoreWebView2.NewWindowRequested += WebView_NewWindowRequested;
        }
        private void WebView_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            //System.Diagnostics.Process.Start(e.Uri);
            //System.Diagnostics.Process.Start("https://bing.com");
            MessageBox.Show(e.Uri, "NewWindowRequested", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
