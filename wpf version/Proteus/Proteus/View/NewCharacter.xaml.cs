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
            NumAttribute a = new NumAttribute(null,null,0,null);
            if (Atribute.SelectedValue.GetType() == a.GetType())
            {
                a = (NumAttribute)Atribute.SelectedValue;
                for(int i = 0; i < a.Dependancies.Count; i++) { words.Content += (a.Dependancies[i].ToString() + "\n"); }
            }
            else if (Atribute.SelectedItem.GetType() == a.GetType())
            {
                a = (NumAttribute)Atribute.SelectedItem;
                for (int i = 0; i < a.Dependancies.Count; i++) { words.Content += (a.Dependancies[i].ToString() + "\n"); }
            }
        }
        private void valuebox_TextChanged(object sender, TextChangedEventArgs e)
        {
            NumAttribute a = new NumAttribute(null, null, 0, null);
            if (Atribute.SelectedValue.GetType() == a.GetType())
            {
                a = (NumAttribute)Atribute.SelectedValue;
                decimal d = 0;
                if(decimal.TryParse(valuebox.Text,out d)) { a.Value = d; }
                else { a.Name = valuebox.Text; }
            }
            else if (Atribute.SelectedItem.GetType() == a.GetType())
            {
                a = (NumAttribute)Atribute.SelectedItem;

            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}