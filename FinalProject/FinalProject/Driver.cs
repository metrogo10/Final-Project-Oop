using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.View;
using FinalProject.Models1;
using FinalProject.Engines;

namespace FinalProject
{
    public class Driver
    {
        public static void Main()
        {
			Application.Run(new ConsoleView());
        }

    }
}
