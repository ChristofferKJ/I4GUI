﻿using System;
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

namespace Delopgave_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           /* Button btn = new Button();
            btn.Name = "btn1";
            btn.Click += btn1_Click; */

        }

        

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
       
            MessageBox.Show("Are you wanted to fucked");

        }
    }
}
