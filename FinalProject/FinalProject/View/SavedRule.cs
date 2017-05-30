using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.View
{
    public class SavedRule : Form
    {


        public SavedRule()
        {
            this.Text = "Saved Ruleset - DnD Program";

            this.ClientSize = new Size(305,450);
            this.MaximumSize = ClientSize;
            this.MinimumSize = MaximumSize;

     
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
