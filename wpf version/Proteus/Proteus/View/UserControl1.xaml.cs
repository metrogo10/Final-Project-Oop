using Proteus.Attributes;
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

namespace Proteus.View
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private int i = 1;
		List<NumDependency> dependencies = new List<NumDependency>();


		public UserControl1()
        {
            InitializeComponent();
        }

		private void DependencySelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (((ComboBox)sender).SelectedIndex >= 0 && ((ComboBox)sender).SelectedIndex <= 4)
			{
				this.dependencyTextBox1.Visibility = Visibility.Visible;
				this.dependencyTextBox2.Visibility = Visibility.Hidden;
			}
			else
			{
				this.dependencyTextBox1.Visibility = Visibility.Visible;
				this.dependencyTextBox2.Visibility = Visibility.Visible;
			}
		}

		private void AddDependency_Click(object sender, RoutedEventArgs e)
        {
            Label l = new Label();
            l.Width = 250;
            l.Content = $"{i}. {dependencyTextBox1.Text} - {dependencyComboBox.SelectionBoxItem.ToString()} - {dependencyTextBox2.Text}";
            i++;
            ListPanel.Children.Add(l);
        }

		private void SaveAttribute_Click(object sender, RoutedEventArgs e)
		{

		}

		private void AddDependency_Click(object sender, RoutedEventArgs e)
		{
			Operand operand = (Operand)dependencyComboBox.SelectedItem;
			decimal throwaway;
			object V1 = !decimal.TryParse(dependencyTextBox1.Text, out throwaway) ? (object)throwaway : (object)dependencyTextBox1.Text;
			object V2 = !decimal.TryParse(dependencyTextBox2.Text, out throwaway) ? (object)throwaway : (object)dependencyTextBox2.Text;
			bool v1IsRef = !decimal.TryParse(dependencyTextBox1.Text, out throwaway);
			bool v2IsRef = !decimal.TryParse(dependencyTextBox2.Text, out throwaway);
			dependencies.Add(new NumDependency(operand, v1IsRef, v2IsRef, V1, V2));
			Label l = new Label();
			l.Width = 250;
			l.Content = $"{i}. {dependencyComboBox.SelectionBoxItem.ToString()} - {dependencyTextBox1.Text} - {dependencyTextBox2.Text}";
			i++;
			ListPanel.Children.Add(l);
		}
	}
}
