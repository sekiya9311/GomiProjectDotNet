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

namespace Base64EncoderAndDecoder
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EncodeButton_Click(object sender, RoutedEventArgs e)
        {
            var encodeStr = this.InputText.Text;
            this.OutputText.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(encodeStr));
        }

        private void DecodeButton_Click(object sender, RoutedEventArgs e)
        {
            var decodeStr = this.InputText.Text;
            this.OutputText.Text = Encoding.UTF8.GetString(Convert.FromBase64String(decodeStr));
        }
    }
}
