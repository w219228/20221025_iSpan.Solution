﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			// this指的是目前這個物件,也就是 Form1
			this.CancelButton = this.closeButton;
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您真的要離開本程式?", 
								"關閉程式", 
								MessageBoxButtons.YesNo, 
								MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
