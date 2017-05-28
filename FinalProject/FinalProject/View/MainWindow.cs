using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using FinalProject.View;

namespace FinalProject
{
    public class MainWindow : Form
    { 
        private Label titleLabel;
        private Button newButton;
        private Button loadButton;

        public MainWindow()
        {
            this.ClientSize = new Size(500,500);
            this.Text = "New - DnD Program";

            this.newButton = new Button();
            this.newButton.Location = new Point(100, 400);
            this.newButton.Text = " New ";
            this.newButton.Click += new EventHandler(this.NewButton_Click);

            this.loadButton = new Button();
            this.loadButton.Location = new Point(300, 400);
            this.loadButton.Text = " Load ";
            this.loadButton.Click += new EventHandler(this.LoadButton_Click);

            this.Controls.Add(newButton);
            this.Controls.Add(loadButton);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button click");
//            this.Hide();
//            new SavedRule().ShowDialog();

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button click");
            this.Hide();
            new SavedRule().ShowDialog();
        }
    }
}
