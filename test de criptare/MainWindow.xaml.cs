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
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using EncryptionCls;
using DecryptionCls;

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
            AllocConsole();
            
        }       
        private void crypt_btn_Click(object sender, RoutedEventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); //time execution
            //MessageBox.Show(Encrypt.text(textBox.Text));
            Console.WriteLine(textBox.Text);
            Console.WriteLine(Encrypt.text(textBox.Text));
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
        }

        private void buttondec_Click(object sender, RoutedEventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //MessageBox.Show(Decrypt.text(textBox_Copy.Text));
            Console.WriteLine(Decrypt.text(textBox_Copy.Text));
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
        }
    }
}
