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

namespace Tab_UserControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private int i = 1;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void AddDependency_Click(object sender, RoutedEventArgs e)
        {
            Label l = new Label();
            l.Width = 250;
            l.Content = $"{i}. {dependencyTextBox1.Text} - {dependencyComboBox.SelectionBoxItem.ToString()} - {dependencyTextBox2.Text}";
            i++;
            ListPanel.Children.Add(l);
        }
    }
}
