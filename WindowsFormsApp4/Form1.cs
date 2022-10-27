using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new Form2();
			frm.MdiParent = this;
			frm.Show();
		}

		private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new Form3();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 維護會員ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
