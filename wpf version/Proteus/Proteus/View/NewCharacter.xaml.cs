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
using System.Windows.Shapes;
namespace Proteus.View
{
    /// <summary>
    /// Interaction logic for NewCharacter.xaml
    /// </summary>
    public partial class NewCharacter : Window
    {
        public NewCharacter()
        {
            InitializeComponent();
        }
        private void SaveCharacter_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Atribute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            words.Content = "";
            NumAttribute a = new NumAttribute(null, null, 0, null);
            a = (NumAttribute)MainEngine.Character.Attributes.Values.ElementAt(Atribute.SelectedIndex);
            for (int i = 0; i < a.Dependancies.Count; i++) { words.Content += (a.Dependancies[i].ToString() + "\n"); }
        }
        private void valuebox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveValue_Click(object sender, RoutedEventArgs e)
        {
            NumAttribute a = new NumAttribute(null, null, 0, null);
            decimal d = 0;
            a = (NumAttribute)MainEngine.Character.Attributes.Values.ElementAt(Atribute.SelectedIndex);
            if (decimal.TryParse(valuebox.Text, out d)) { a.Value = d; }
            else { a.Name = valuebox.Text; }
        }
    }
}