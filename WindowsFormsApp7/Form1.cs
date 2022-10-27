using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			comboBox1.SelectedIndex = 0;
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			// 取得被選取的數值
			int firstNumber = GetFirstNumber();

			// 生成單一乘法表
			string table = RenderSingleTable(firstNumber);

			// 呈現結果
			textBox1.Text = table;
		}

		private string RenderSingleTable(int firstNumber)
		{
			string result = string.Empty;

			for(int i = 1; i < 10; i++)
			{
				result += $"{firstNumber} * {i} = {firstNumber * i}\r\n";
			}

			return result;
		}

		//private int GetFirstNumber()
		//{
		//	return Convert.ToInt32(comboBox1.SelectedItem);
		//}
		private int GetFirstNumber()
		=>Convert.ToInt32(comboBox1.SelectedItem);
		//  =>讀作( goes to)
	}
}
