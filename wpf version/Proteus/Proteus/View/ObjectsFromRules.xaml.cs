﻿using Microsoft.Win32;
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
using System.Windows.Shapes;
namespace Proteus.View
{
    /// <summary>
    /// Interaction logic for ObjectsFromRules.xaml
    /// </summary>
    public partial class ObjectsFromRules : Window
    {
        public ObjectsFromRules()
        {
            InitializeComponent();
        }
        private void CreateCharacter(object sender, RoutedEventArgs e)
        {

        }
        private void LoadCharacter(object sender, RoutedEventArgs e)
        {
            OpenFileDialog files = new OpenFileDialog();
            files.ShowDialog();
        }
        private void CreateItemTemplate(object sender, RoutedEventArgs e)
        {

        }
        private void LoadItemTemplate(object sender, RoutedEventArgs e)
        {
            OpenFileDialog files = new OpenFileDialog();
            files.ShowDialog();
        }
        private void CreateItem(object sender, RoutedEventArgs e)
        {

        }
        private void LoadItem(object sender, RoutedEventArgs e)
        {
            OpenFileDialog files = new OpenFileDialog();
            files.ShowDialog();
        }
    }
}
