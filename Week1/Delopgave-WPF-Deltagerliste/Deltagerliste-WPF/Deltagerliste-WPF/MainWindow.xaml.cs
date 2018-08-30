using System;
using System.Collections.Generic;
using System.IO;
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

namespace Deltagerliste_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void DelList_Button_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\chris\OneDrive\Desktop\4. Semester\I4GUI\i4gui\Week1\Delopgave-WPF-Deltagerliste\Deltagerliste-WPF\Deltagerliste-WPF\Files\02 deltagerliste.csv");
            var data = lines.Skip(1);
            DelList_Label.Content = data;
        }
    }
}
