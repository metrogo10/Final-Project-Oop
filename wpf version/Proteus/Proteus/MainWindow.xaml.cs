using Microsoft.Win32;
using Proteus.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Proteus.Attributes;

namespace Proteus
{
    public partial class MainWindow : Window
    {
        NewGame N = new NewGame();
        public MainWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow.Closing += new CancelEventHandler(MainWindow_Closing);
        }
        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
			Environment.Exit(0);
        }
        private void NewGame(object sender, RoutedEventArgs e)
        {
            if (N.IsVisible) { }
            else { N = new NewGame(); N.Show(); }
        }
        private void LoadGame(object sender, RoutedEventArgs e)
        {
            /*Character c = new Character();
          List<NumDependency> ld = new List<NumDependency>();
          NumDependency nd = new NumDependency(Operand.GreaterThan,true,false)
          ld.Add()
          NumAttribute n = new NumAttribute("str","stats",1,ld);
          c.Attributes.Add();
                        */
            OpenFileDialog saver = new OpenFileDialog();
          saver.Filter = "Proteus Rules Templates (*.ptemp)|*.ptemp";
          if (saver.ShowDialog() == DialogResult)
              MainEngine.Template = FileIO.LoadCharacter(saver.FileName);

        }
    }
}