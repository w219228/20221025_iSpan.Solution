 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_RadioButtonList
{ // 尚未錄影
	public partial class Form1 : Form
	{
		private List<RadioButton> genderItems;
		private List<RadioButton> maritalStatusItems;

		public Form1()
		{
			InitializeComponent();

			InitForm();
		}

		private void InitForm()
		{
			genderItems = genderGroup.Controls.OfType<RadioButton>().ToList();
			maritalStatusItems = maritalStatusGroup.Controls.OfType<RadioButton>().ToList();
		}

		public int? MaritalStatus
		{
			get
			{
				var item = maritalStatusItems.SingleOrDefault(x => x.Checked == true);
				if (item == null)
				{
					return null;
				}
				else
				{
					return Convert.ToInt32(item.Tag);
				}
			}
		}

		public int? Gender
		{
			get
			{
				var item = genderItems.SingleOrDefault(x => x.Checked == true);
				if (item == null)
				{
					return null;
				}
				else
				{
					return Convert.ToInt32(item.Tag);
				}
			}
		}


		private void button1_Click(object sender, EventArgs e)
		{
			int? gender = this.Gender;
			MessageBox.Show("性別:" + (gender.HasValue ? gender.Value.ToString() : "N/A"));

			int? maritalStatus = this.MaritalStatus;
			MessageBox.Show("婚姻狀況:" + (maritalStatus.HasValue ? maritalStatus.Value.ToString() : "N/A"));
		}
	}
}
