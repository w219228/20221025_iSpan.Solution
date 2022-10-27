using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MinimizeBox = this.MaximizeBox = false;

			this.button1.Click += Button1_Click;

			this.label1.Text = String.Empty;

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hi");
		}
	}
}
