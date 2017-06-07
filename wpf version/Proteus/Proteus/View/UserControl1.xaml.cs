using Proteus.Attributes;
using Proteus.Engines;
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
			dependencyComboBox.ItemsSource = Enum.GetValues(typeof(Operand));
			dependencyTextBox1.Visibility = Visibility.Hidden;
			dependencyTextBox2.Visibility = Visibility.Hidden;
			AddDependencyBox.Visibility = Visibility.Hidden;
			DependencyListBox.Visibility = Visibility.Hidden;
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

		private void SaveAttribute_Click(object sender, RoutedEventArgs e)
		{
			if (!CharacterEngine.CharTemplate.Attributes.ContainsKey(AttributeNameField.Text))
			{
				switch (AttributeType.SelectedIndex)
				{
					case 0: //Text
						CharacterEngine.CharTemplate.Attributes.Add(AttributeNameField.Text, new TextAttribute(AttributeNameField.Text, "", 0, ""));
						break;
					case 1: //Number
						NumAttribute newAttribute = new NumAttribute(AttributeNameField.Text, "", 0, dependencies);
						string[] errors = CharacterEngine.ValidateAttribute(CharacterEngine.CharTemplate, newAttribute);
					
						if (errors.Length==0)
						{
							CharacterEngine.CharTemplate.Attributes.Add(newAttribute.Name, newAttribute);
						}
						else
						{
							StringBuilder consolodatedErrors = new StringBuilder();

							foreach (string error in errors)
							{
								consolodatedErrors.Append(error + "\n");
							}
							MessageBoxResult errorMessage = MessageBox.Show(consolodatedErrors.ToString());
						}
						break;
					case 2: //Bool
						CharacterEngine.CharTemplate.Attributes.Add(AttributeNameField.Text, new BoolAttribute(AttributeNameField.Text, "", 0));
						break;
				}
			}
			else
			{
				AttributeNameField.Text = "Name Already In Use";
			}
		}

		private void AddDependency_Click(object sender, RoutedEventArgs e)
		{
			//These are the parameters required to construct a dependency.
			Operand operand = (Operand)dependencyComboBox.SelectedItem;
			object V1;
			Object V2;
			bool v1IsRef;
			bool v2IsRef;

			decimal throwaway; //This is a useless variable for our TryParse to output to.

			//We need to check whether the user has entered a reference string or a number
			//Here we check V1, the most used value.
			v1IsRef = !decimal.TryParse(dependencyTextBox1.Text, out throwaway);

			//Now we set V1.

			if (v1IsRef)
			{
				V1 = dependencyTextBox1.Text; //If it did not parse, we can set it equal to the text in the box.
			}
			else
			{
				V1 = throwaway; //If the value parsed successfully, it stored itself in throwaway. We can use that before we reset it. 
			}

			//Time for the second value. First, we need to know if we're even using a second value.
			if ((int)operand < 5) //This is the range of operands which only take in one value.
			{
				V2 = ""; //We can set v2 to the empty string so it doesn't display. We'll never use it.
				v2IsRef = true;
			}
			else
			{
				v2IsRef = !decimal.TryParse(dependencyTextBox2.Text, out throwaway); //Second verse, same as the first.

				if (v2IsRef)
					V2 = dependencyTextBox2.Text;
				else
					V2 = throwaway; //Once again, this value will be set between being used the first and second time if we're ever going to use it a second time.
			}



			if (CharacterEngine.CharTemplate != null && ((v1IsRef && CharacterEngine.CharTemplate.Attributes.ContainsKey(V1.ToString())) || (v2IsRef && V2.ToString()!="" && CharacterEngine.CharTemplate.Attributes.ContainsKey(V2.ToString()))))
			{
				dependencies.Add(new NumDependency(operand, v1IsRef, v2IsRef, V1, V2));
				Label l = new Label();
				l.Width = 250;
				l.Content = $"{i}. {dependencyComboBox.SelectionBoxItem.ToString()} - {dependencyTextBox1.Text} - {dependencyTextBox2.Text}";
				i++;
				ListPanel.Children.Add(l);
				dependencyTextBox1.Text = "";
				dependencyTextBox2.Text = "";
			}
			else if (!v1IsRef && (operand>=0 && (int)operand<=4))
			{
				dependencies.Add(new NumDependency(operand, v1IsRef, v2IsRef, V1, V2));
				Label l = new Label();
				l.Width = 250;
				l.Content = $"{i}. {dependencyComboBox.SelectionBoxItem.ToString()} - {dependencyTextBox1.Text} - {dependencyTextBox2.Text}";
				i++;
				ListPanel.Children.Add(l);
				dependencyTextBox1.Text = "";
				dependencyTextBox2.Text = "";
			}
			else if (v1IsRef && !v2IsRef)
			{
				dependencyTextBox1.Text = "Invalid Reference";
				dependencyTextBox2.Text = "";
			}
			else if (!v1IsRef && v2IsRef)
			{
				dependencyTextBox1.Text = "";
				dependencyTextBox2.Text = "Invalid Reference";
			}
			else if (v1IsRef && v2IsRef)
			{
				dependencyTextBox1.Text = "Invalid Reference";
				dependencyTextBox2.Text = "Invalid Reference";
			}
			else
			{
				dependencies.Add(new NumDependency(operand, v1IsRef, v2IsRef, V1, V2));
				Label l = new Label();
				l.Width = 250;
				l.Content = $"{i}. {dependencyComboBox.SelectionBoxItem.ToString()} - {dependencyTextBox1.Text} - {dependencyTextBox2.Text}";
				i++;
				ListPanel.Children.Add(l);
				dependencyTextBox1.Text = "";
				dependencyTextBox2.Text = "";
			}

		}

		private void AttributeTypeChanged(object sender, SelectionChangedEventArgs e)
		{
			dependencyTextBox1.Text = "";
			dependencyTextBox2.Text = "";
			if (AttributeType.SelectedIndex == 1)
			{
				AddDependencyBox.Visibility = Visibility.Visible;
				DependencyListBox.Visibility = Visibility.Visible;
			}
			else
			{
				AddDependencyBox.Visibility = Visibility.Hidden;
				DependencyListBox.Visibility = Visibility.Hidden;
			}
		}

		private void DBox1Focus(object sender, RoutedEventArgs e)
		{
			dependencyTextBox1.Text = "";
		}

		private void DBox2Focus(object sender, RoutedEventArgs e)
		{
			dependencyTextBox2.Text = "";
		}
	}
}
