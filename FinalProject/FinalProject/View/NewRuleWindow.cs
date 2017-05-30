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
    class NewRuleWindow : Form
    {
        private Label nameLabel;
        private TextBox nameTextBox;

        private Label xxxxxLabel;
        private TextBox xxxxxTextBox;

        private Label ruleSetLabel;
        private TextBox ruleSeTextBox;

        private Label lineLabel;

        private Label attributeLabel;
        private Label attributeNameLabel;
        private TextBox attributeNameTextBox;
        private ComboBox attributeList;
        private Button addAttributeButton;

        private Label dependencyLabel;
        private TextBox xxxxTextBox;
        private Button xxxx1Button;
        private Button xxxx2Button;
        private Button addDependencyButton;

        private Button saveBuuton;

        public NewRuleWindow()
        {
            this.Text = " New Ruleset - DnD Program";

            this.ClientSize = new Size(302,600);
            this.MaximumSize = ClientSize;
            this.MinimumSize = MaximumSize;
          
            this.nameLabel = new Label();
            this.nameLabel.Text = "Name - ";
            this.nameLabel.Font = new Font("Arial", 10);
            this.nameLabel.Width = 50;
            this.nameLabel.Location = new Point(30, 30);

            this.nameTextBox = new TextBox();
            this.nameTextBox.Location = new Point(85, 30);

            this.xxxxxLabel = new Label();
            this.xxxxxLabel.Text = "XXXX - ";
            this.xxxxxLabel.Font = new Font("Arial", 10);
            this.xxxxxLabel.Width = 60;
            this.xxxxxLabel.Location = new Point(30, 60);

            this.xxxxxTextBox = new TextBox();
            this.xxxxxTextBox.Location = new Point(90, 60);

            this.ruleSetLabel = new Label();
            this.ruleSetLabel.Text = "Rule-set - ";
            this.ruleSetLabel.Font = new Font("Arial", 10);
            this.ruleSetLabel.Width = 70;
            this.ruleSetLabel.Location = new Point(30, 90);

            this.ruleSeTextBox = new TextBox();
            this.ruleSeTextBox.Location = new Point(100, 90);     
            
            this.lineLabel = new Label();
            this.lineLabel.Text = "----------------------------------------------------------------------";
            this.lineLabel.Width = 300;
            this.lineLabel.Location = new Point(3, 130);

            this.Controls.Add(nameLabel);   
            this.Controls.Add(nameTextBox);

            this.Controls.Add(xxxxxLabel);
            this.Controls.Add(xxxxxTextBox);

            this.Controls.Add(ruleSetLabel);
            this.Controls.Add(ruleSeTextBox);
            this.Controls.Add(lineLabel);


            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
