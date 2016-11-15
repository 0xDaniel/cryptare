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
using EncryptionCls;
using DecryptionCls;
using System.Runtime.InteropServices;

namespace test_de_criptare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            textBox.Document.Blocks.Clear();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd).Text != string.Empty)
            {
                MessageBox.Show(Encrypt.text(new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd).Text));
            }
            else if (new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd).Text == string.Empty)
            {
                MessageBox.Show("De cate ori sa-ti spun ca nu pot cripta spatii! :(", "Bulan esti prost!");
            }

        }

        private void buttondec_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Decrypt.text(new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd).Text));
        }
    }
}
