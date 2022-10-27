using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_CheckBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (chkEDM.Checked)
			{
				MessageBox.Show("感謝訂閱電子報");
			}
			else
			{
				MessageBox.Show("您日後可以隨時訂閱電子報");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (chkEDM.CheckState == CheckState.Checked)
			{
				MessageBox.Show("感謝訂閱電子報2");
			}
			else
			{
				MessageBox.Show("您日後可以隨時訂閱電子報2");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			chkEDM.CheckState = CheckState.Indeterminate;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			chkEDM.CheckState = CheckState.Checked;
		}

		private void chkEDM_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void chkEDM_CheckStateChanged(object sender, EventArgs e)
		{

		}
	}
}
