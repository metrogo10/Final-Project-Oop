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

        private Label line1Label;

        private Label attributeLabel;
        private Label attributeNameLabel;
        private Label attributeTypeLabel;
        private TextBox attributeNameTextBox;
        private ComboBox attributeList;
        private Button addAttributeButton;

        private Label dependencyLabel;
        private TextBox xxxxTextBox;
        private Button xxxx1Button;
        private Button xxxx2Button;
        private Button addDependencyButton;

        private Label line2Label;

        private Button saveButton;
        private Label line3Label;

        private Label statusLabel;

        public NewRuleWindow()
        {
            this.Text = "New Ruleset - Proteus";

            this.ClientSize = new Size(302,525);
            this.MaximumSize = ClientSize;
            this.MinimumSize = MaximumSize;
          
            this.nameLabel = new Label();
            this.nameLabel.Text = "Name";
            this.nameLabel.Font = new Font("Arial", 10);
            this.nameLabel.Width = 50;
            this.nameLabel.Location = new Point(40, 30);

            this.nameTextBox = new TextBox();
            this.nameTextBox.Width = 120;
            this.nameTextBox.Location = new Point(120, 30);

            this.xxxxxLabel = new Label();
            this.xxxxxLabel.Text = "XXXX";
            this.xxxxxLabel.Font = new Font("Arial", 10);
            this.xxxxxLabel.Width = 60;
            this.xxxxxLabel.Location = new Point(40, 60);

            this.xxxxxTextBox = new TextBox();
            this.xxxxxTextBox.Width = 120;
            this.xxxxxTextBox.Location = new Point(120, 60);

            this.ruleSetLabel = new Label();
            this.ruleSetLabel.Text = "Rule-set";
            this.ruleSetLabel.Font = new Font("Arial", 10);
            this.ruleSetLabel.Width = 70;
            this.ruleSetLabel.Location = new Point(40, 90);

            this.ruleSeTextBox = new TextBox();
            this.ruleSeTextBox.Width = 120;
            this.ruleSeTextBox.Location = new Point(120, 90);     
            
            this.line1Label = new Label();
            this.line1Label.Text = "----------------------------------------------------------------------";
            this.line1Label.Width = 290;
            this.line1Label.Location = new Point(3, 130);

            this.attributeLabel = new Label();
            this.attributeLabel.Text = " - Attribute - ";
            this.attributeLabel.Font = new Font("Arial", 13);
            this.attributeLabel.Location = new Point(90, 150);

            this.attributeNameLabel = new Label();
            this.attributeNameLabel.Text = "Name";
            this.attributeNameLabel.Font = new Font("Arial", 10);
            this.attributeNameLabel.Width = 50;
            this.attributeNameLabel.Location = new Point(40, 180);

            this.attributeNameTextBox = new TextBox();
            this.attributeNameTextBox.Width = 120;
            this.attributeNameTextBox.Location = new Point(120, 180);

            this.attributeTypeLabel = new Label();
            this.attributeTypeLabel.Text = "Type";
            this.attributeTypeLabel.Font = new Font("Arial", 10);
            this.attributeTypeLabel.Width = 50;
            this.attributeTypeLabel.Location = new Point(40, 210);

            this.attributeList = new ComboBox();
            this.attributeList.Items.Add("~~~~~~");
            this.attributeList.DropDownStyle = ComboBoxStyle.DropDownList;
            this.attributeList.Location = new Point(120, 210);

            this.addAttributeButton = new Button();
            this.addAttributeButton.Text = "Add Attribute";
            this.addAttributeButton.Font = new Font("Arial", 10);
            this.addAttributeButton.Width = 100;
            this.addAttributeButton.Location = new Point(90, 240);
            this.addAttributeButton.Click += new EventHandler(AddAttributeButton_Click);

            this.dependencyLabel = new Label();
            this.dependencyLabel.Text = " - Dependency - ";
            this.dependencyLabel.Width = 150;
            this.dependencyLabel.Font = new Font("Arial", 12);
            this.dependencyLabel.Location = new Point(80, 280);

            this.xxxxTextBox = new TextBox();
            this.xxxxTextBox.Width = 100;
            this.xxxxTextBox.Location = new Point(40, 310);

            this.xxxx1Button = new Button();
            this.xxxx1Button.Text = "X";
            this.xxxx1Button.Font = new Font("Arial", 10);
            this.xxxx1Button.Width = 30;
            this.xxxx1Button.Location = new Point(170, 310);

            this.xxxx2Button = new Button();
            this.xxxx2Button.Text = "X";
            this.xxxx2Button.Font = new Font("Arial", 10);
            this.xxxx2Button.Width = 30;
            this.xxxx2Button.Location = new Point(210, 310);

            this.addDependencyButton = new Button();
            this.addDependencyButton.Text = "Add Dependency";
            this.addDependencyButton.Font = new Font("Arial", 10);
            this.addDependencyButton.Width = 130;
            this.addDependencyButton.Location = new Point(80, 345);
            this.addDependencyButton.Click += new EventHandler(AddDependencyButton_Click);

            this.line2Label = new Label();
            this.line2Label.Text = "----------------------------------------------------------------------";
            this.line2Label.Width = 290;
            this.line2Label.Location = new Point(3, 380);

            this.saveButton = new Button();
            this.saveButton.Text = "Save";
            this.saveButton.Font = new Font("Arial", 10);
            this.saveButton.Width = 50;
            this.saveButton.Location = new Point(120, 405);
            this.saveButton.Click += new EventHandler(SaveButton_Click);

            this.line3Label = new Label();
            this.line3Label.Text = "----------------------------------------------------------------------";
            this.line3Label.Width = 290;
            this.line3Label.Location = new Point(3, 440);

            this.statusLabel = new Label();
            this.statusLabel.Text = "Status : ";
            this.statusLabel.Font = new Font("Arial", 10);
            this.statusLabel.Width = 300;
            this.statusLabel.Location = new Point(10, 460);

            this.Controls.Add(nameLabel);   
            this.Controls.Add(nameTextBox);

            this.Controls.Add(xxxxxLabel);
            this.Controls.Add(xxxxxTextBox);

            this.Controls.Add(ruleSetLabel);
            this.Controls.Add(ruleSeTextBox);
            this.Controls.Add(line1Label);

            this.Controls.Add(attributeLabel);

            this.Controls.Add(attributeNameLabel);
            this.Controls.Add(attributeNameTextBox);
            this.Controls.Add(attributeTypeLabel);
            this.Controls.Add(attributeList);
            this.Controls.Add(addAttributeButton);

            this.Controls.Add(dependencyLabel);
            this.Controls.Add(xxxxTextBox);
            this.Controls.Add(xxxx1Button);
            this.Controls.Add(xxxx2Button);
            this.Controls.Add(addDependencyButton);
            this.Controls.Add(line2Label);

            this.Controls.Add(saveButton);
            this.Controls.Add(line3Label);

            this.Controls.Add(statusLabel);

            this.FormClosing += Form1_FormClosing;
        }

        private void AddAttributeButton_Click(object sender, EventArgs e)
        {

        }

        private void AddDependencyButton_Click(object sender, EventArgs e)
        {
             
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
             
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
