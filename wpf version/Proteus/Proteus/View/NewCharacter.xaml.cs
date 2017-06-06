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
            CustomAttribute a = (CustomAttribute)Atribute.SelectedValue;
            a.
        }
    }
}