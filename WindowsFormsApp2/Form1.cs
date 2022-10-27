using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void drawButton_Click(object sender, EventArgs e)
		{
			Lottery lottery = new Lottery();
			int[] numbers = lottery.Draw(49, 6);
			
			Array.Sort(numbers);

			string msg = string.Join(", ", numbers); // "1,22,5,3,9,18"
			label1.Text = msg;
		}
	}
	public class Lottery
	{
		/// <summary>
		/// 從多個數字中,取出N個不重覆的數值
		/// </summary>
		/// <param name="numbers">1~numbers 是取亂數的對象</param>
		/// <param name="drawNumbers">要取出幾個不重覆的值</param>
		/// <returns>傳回陣列,內含不重覆的值</returns>
		public int[] Draw(int numbers, int drawNumbers)
		{
			// todo 檢查 numbers, drawNumbers大小關係
			// todo 用洗牌的方式, 找出前N個不重覆亂數

			return new int[] {1,22,5,3,9,18 };

			//int[] source = new int[numbers];
			//// 初始化陣列的值
			//for (int i = 0; i < source.Length; i++)
			//{
			//	source[i] = i+1;
			//}

			//// 洗牌
			//var random = new Random(Guid.NewGuid().GetHashCode());
			//for (int i = 0; i < source.Length; i++)
			//{
			//	int position = random.Next(0, source.Length); // [0,49)
			//	// 對調source[i], source[postion]的值
			//	int temp = source[i];
			//	source[i] = source[position];
			//	source[position] = temp;
			//}

			//// 傳回前N個值
			//int[] result = new int[drawNumbers];
			//Array.Copy(source, result, result.Length);

			//return result;
		}
	}
}
