namespace FinalProject.View
{
	partial class ConsoleView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ConsoleBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// ConsoleBox
			// 
			this.ConsoleBox.Enabled = false;
			this.ConsoleBox.Location = new System.Drawing.Point(13, 13);
			this.ConsoleBox.Name = "ConsoleBox";
			this.ConsoleBox.ReadOnly = true;
			this.ConsoleBox.Size = new System.Drawing.Size(749, 246);
			this.ConsoleBox.TabIndex = 0;
			this.ConsoleBox.Text = "";
			this.ConsoleBox.Text += "Testing character creation.\n";
			Race testRace = new Race();
			testRace.setDescription("A simple test race.");
			testRace.setName("Test Race");
			Archetype a = new Archetype();
			a.setName("Test AT.");
			a.setDescription("Test archtype");
			Character c = new Character();
			c.setName("Test Character");
			c.SetClass(a);
			c.SetRace(testRace);
			this.ConsoleBox.Text += c + "\n";
			this.ConsoleBox.Text += "Testing saving.\n";
			FinalProject.Engines.MainEngine.RulesetName = "Derr";
			FinalProject.Engines.FileIO.SaveCharacter(c);
			this.ConsoleBox.Text += "Save successful.\n";
			Character c2 = FinalProject.Engines.FileIO.LoadCharacter("Test Character");
			this.ConsoleBox.Text += "Load successful.\n";
			this.ConsoleBox.Text += c2;
			// 
			// ConsoleView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 261);
			this.Controls.Add(this.ConsoleBox);
			this.Name = "ConsoleView";
			this.Text = "Console";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox ConsoleBox;
	}
}