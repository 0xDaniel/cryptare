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
using System.IO;
using System.Diagnostics;

namespace test_de_criptare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();

        public MainWindow()
        {
            InitializeComponent();
            textBox.Document.Blocks.Clear();
            AllocConsole();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd).Text != string.Empty)
            {
                //MessageBox.Show(Encrypt.text(new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd).Text));
                //var watch = System.Diagnostics.Stopwatch.StartNew(); //time execution                                                                                   
                Console.WriteLine(Encrypt.text(new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd).Text));
                //watch.Stop();
                //var elapsedMs = watch.ElapsedMilliseconds;
               // Console.WriteLine(elapsedMs);
            }
            else if (new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd).Text == string.Empty)
            {
                //MessageBox.Show("De cate ori sa-ti spun ca nu pot cripta spatii! :(", "Bulan esti prost!");
                Console.WriteLine("liber");
            }

        }

        private void buttondec_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Decrypt.text(new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd).Text));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("muie");
        }
    }
}
