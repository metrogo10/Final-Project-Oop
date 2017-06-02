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
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void NewGame(object sender, RoutedEventArgs e)
		{
			NewGame secondWindow = new NewGame();
			secondWindow.Show();
		}
		private void LoadGame(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Character Templates (*.ptemp)|*.ptemp";
			if (openFileDialog.ShowDialog() == DialogResult)
				MainEngine.Template = FileIO.LoadCharacter(openFileDialog.FileName);
		}
	}
}