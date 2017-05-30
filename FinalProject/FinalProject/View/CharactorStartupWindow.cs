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
    class CharactorStartupWindow : Form
    {
        private Button newCharactorButton;
        private Button loadCharactorButton;

        public CharactorStartupWindow()
        {
            this.Text = "Charactor - DnD Program";

            this.ClientSize = new Size(500, 300);
            this.MaximumSize = ClientSize;
            this.MinimumSize = MaximumSize;

            this.newCharactorButton = new Button();
            this.newCharactorButton.Text = "New";
            this.newCharactorButton.Width = 50;
            this.newCharactorButton.Font = new Font("Arial", 10);
            this.newCharactorButton.Location = new Point(120, 200);
            this.newCharactorButton.Click += new EventHandler(NewCharactorButton_Click);

            this.loadCharactorButton = new Button();
            this.loadCharactorButton.Text = "Load";
            this.loadCharactorButton.Width = 50;
            this.loadCharactorButton.Font = new Font("Arial", 10);
            this.loadCharactorButton.Location = new Point(300, 200);
            this.loadCharactorButton.Click += new EventHandler(LoadCharactorButto_Click);

            this.Controls.Add(newCharactorButton);
            this.Controls.Add(loadCharactorButton);

            this.FormClosing += Form1_FormClosing;
        }

        private void NewCharactorButton_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadCharactorButto_Click(object sender, EventArgs e)
        {
             
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
