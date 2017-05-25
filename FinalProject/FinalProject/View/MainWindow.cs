using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    public class MainWindow : Form
    {
        public Button button1;
        public TextBox textbox1;
        public ListBox listbox1;

        public MainWindow()
        {
            this.ClientSize = new Size(500,500);

            this.button1 = new Button();
            this.button1.Location = new Point(10, 10);
            this.button1.Text = "Click Me!!";
            this.button1.Click += new EventHandler(this.button_Click);

            this.textbox1 = new TextBox();
            this.textbox1.Location = new Point(10, 45);
            this.textbox1.Text = "Input Something.....";
            this.textbox1.KeyPress += new KeyPressEventHandler(this.textbox_KeyPress);

            this.listbox1 = new ListBox();
            this.listbox1.Location = new Point(10, 80);
            this.listbox1.Items.Add("Choice 1");
            this.listbox1.Items.Add("Choice 2");
            this.listbox1.Items.Add("Choice 3");
            this.listbox1.Items.Add("Choice 4");
            this.listbox1.Click += new EventHandler(this.listbox_Click);

            this.Controls.Add(button1);
            this.Controls.Add(textbox1);
            this.Controls.Add(listbox1);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button click");
        }

        private void textbox_KeyPress(object sender, EventArgs e)
        {
            Console.WriteLine("key press");
        }

        private void listbox_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.listbox1.SelectedItem);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(820, 725);
            this.Name = "MainWindow";
            this.ResumeLayout(false);

        }
    }
}
