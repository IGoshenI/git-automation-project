﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace git_automation_project
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void commitInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void commitInputText_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text == "")
            {
                textBox.Text = "> Enter your commit here";
                textBox.Foreground = Brushes.SlateGray;
            }
        }

        private void commitInputText_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.Text = "";
            textBox.Foreground = Brushes.SlateGray;
        }

        private void pushButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.commitInputText.Text);
        }

        private void openDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(GetDirectory());
        }

        private string GetDirectory()
        {
            return System.IO.Directory.GetParent
                (System.IO.Directory.GetParent
                (System.IO.Directory.GetParent
                (System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString()).ToString(); // :/
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1. Add your files to the shared directory\n" +
                "2. Enter your commit message\n" +
                "3. Press the 'PUSH!' button");
        }
    }
}
