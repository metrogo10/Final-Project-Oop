using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using FinalProject.View;

namespace FinalProject
{
    public class StartUpWindow : Form
    { 
        private Label titleLabel;
        private Label descriptionLabel;
        private Button newButton;
        private Button loadButton;

        public StartUpWindow()
        {
            this.Text = "Proteus - Start Page";

            this.ClientSize = new Size(500,500);
            this.MaximumSize = ClientSize;
            this.MinimumSize = MaximumSize;

            this.titleLabel = new Label();
            this.titleLabel.Size = new Size(200, 40);
            this.titleLabel.Text = "Proteus - Start";
            this.titleLabel.Font = new Font("Arial", 20);
            this.titleLabel.Location = new Point(150,100);

            this.descriptionLabel = new Label();
            this.descriptionLabel.Size = new Size(300,30);
            this.descriptionLabel.Text = " - Please select the ruleset you want to work in";
            this.descriptionLabel.Font = new Font("Arial", 10);
            this.descriptionLabel.Location = new Point(100, 350);

            this.newButton = new Button();
            this.newButton.Location = new Point(100, 400);
            this.newButton.Text = " New ";
            this.newButton.Click += new EventHandler(this.NewButton_Click);

            this.loadButton = new Button();
            this.loadButton.Location = new Point(300, 400);
            this.loadButton.Text = " Load ";
            this.loadButton.Click += new EventHandler(this.LoadButton_Click);

            this.Controls.Add(titleLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(newButton);
            this.Controls.Add(loadButton);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NewRuleWindow().ShowDialog();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SavedRule().ShowDialog();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
