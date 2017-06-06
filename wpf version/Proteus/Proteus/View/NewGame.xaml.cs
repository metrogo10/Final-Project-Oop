using Proteus.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Proteus.Attributes;
using Proteus.View;
namespace Proteus.View
{
    /// <summary>
    /// Interaction logic for NewGame.xaml
    /// </summary>
    public partial class NewGame : Window
    {
        private int i = 1;
        private int j = 1;
		List<NumDependency> dependencies = new List<NumDependency>();


		public NewGame()
        {
            InitializeComponent();
			/*dependencyComboBox.ItemsSource = Enum.GetValues(typeof(Operand));
			dependencyTextBox1.Visibility = Visibility.Hidden;
			dependencyTextBox2.Visibility = Visibility.Hidden;*/
			Application.Current.MainWindow.Closing += new CancelEventHandler(MainWindow_Closing);
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            i = 1;
            j = 1;
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            i = 1;
            j = 1;
            this.Close();
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            // Perform tasks at application exit
        }
        private void AddAttributeButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl1 u1 = new UserControl1();
            j++;
            TabItem t1 = new TabItem();
            t1.Content = u1;
            t1.Header = $"Attribute {j}";
            AttributeTabControl.Items.Add(t1);        
        }

        private void AddDependency_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}