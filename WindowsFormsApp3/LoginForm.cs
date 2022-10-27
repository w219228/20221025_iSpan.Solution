using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			// todo 判斷帳密是否正確

			// 開啟 form1
			Form1 frm = new Form1();
			// frm.Owner = this;
			// frm.Show();
			frm.ShowDialog();

			// 隱藏自己,不可以關閉自己
			// this.Hide();
		}
	}
}
