using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FinalProject
{
    public class Driver
    {
        public static void Main()
        {
			System.Threading.Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
			//Application.Run(new MainWindow());
			UITestWindow window = new UITestWindow();
			window.Show();
        }
    }
}
