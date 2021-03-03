using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Labs
{
	/// <summary>
	/// Summary description for AddShapeForm.
	/// </summary>
	public class AddShapeForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1; 
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddShapeForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();			
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Enabled = false;
			this.okButton.Location = new System.Drawing.Point(80, 160);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(80, 30);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "OK";
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(195, 160);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(80, 30);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(16, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 16);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Circle";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(136, 112);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(16, 80);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(72, 16);
			this.radioButton3.TabIndex = 4;
			this.radioButton3.Text = "Triangle";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(16, 52);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(88, 16);
			this.radioButton2.TabIndex = 3;
			this.radioButton2.Text = "Square";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(184, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Radius:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(184, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(136, 22);
			this.textBox1.TabIndex = 5;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// AddShapeForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(354, 210);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddShapeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Insert new shape";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
		
		public double getTextBoxInput()
		{
			double textBoxValue;
			double.TryParse(textBox1.Text, out textBoxValue);
			textBox1.Clear();
			return textBoxValue;
		}
		public int getSelectedType()
		{
			int choiceNumber;
			if (radioButton1.Checked)
				choiceNumber = 1;
			else if (radioButton2.Checked)
				choiceNumber = 2;
			else
				choiceNumber = 3;
			return choiceNumber;
		}
		private void radioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked)
			{
				label1.Text="Radius:";

			}
			else if(radioButton2.Checked)
			{
				label1.Text="Side of square:";
			}
			else if(radioButton3.Checked)
			{
				label1.Text="Side of triangle:";
			}		
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			double parsedValue;
			if (double.TryParse(textBox1.Text, out parsedValue) && (textBox1.Text.Contains(".") && parsedValue > 0))
			{
				if (!(textBox1.Text.StartsWith(".") || textBox1.Text.EndsWith(".")))
				{
					okButton.Enabled = true;
				}
				else
					okButton.Enabled = false;

			}
			

		}
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;

			}
			
			
		}

	}
}
