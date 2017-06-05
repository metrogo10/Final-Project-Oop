using Microsoft.Win32;
using Proteus.View;
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
using Proteus.Engines;
namespace Proteus
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NewGame(object sender, RoutedEventArgs e)
        {
            ObjectsFromRules O = new ObjectsFromRules();
        }
        private void LoadGame(object sender, RoutedEventArgs e)
        {
           
        }
    }
}