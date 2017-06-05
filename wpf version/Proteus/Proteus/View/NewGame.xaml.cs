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
namespace Proteus.View
{
    /// <summary>
    /// Interaction logic for NewGame.xaml
    /// </summary>
    public partial class NewGame : Window
    {
        private int i = 1;
        private int j = 1;

        public NewGame()
        {
			dependencyComboBox.ItemsSource = Enum.GetValues(typeof(Operand));
            InitializeComponent();
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

        private void AddDependency_Click(object sender, RoutedEventArgs e)
        {           
            Label l = new Label();
            l.Width = 250;
            l.Content = $"{i}. {dependencyTextBox1.Text} - {dependencyComboBox.SelectionBoxItem.ToString()} - {dependencyTextBox2.Text}";
            i++;
            ListPanel.Children.Add(l);
        }
        private void AddAttributeButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl u1 = new Tab_UserControl.UserControl1();
            j++;
            TabItem t1 = new TabItem();
            t1.Content = u1;
            t1.Header = $"Attribute {j}";
            AttributeTabControl.Items.Add(t1);        
        }
    }
}